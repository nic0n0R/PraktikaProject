using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace PraktikaProject.CRUD.Create
{
    public partial class newBrigade1 : Form
    {
        DataWorker DW = new DataWorker();
        string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");

        Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
        public newBrigade1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 1) // 2 человека в бригаде
            {
                // первый сотрудник ВКЛ
                comboBox2.Visible = true;
                label2.Visible = true;
                // второй сотрудник ВЫКЛ
                comboBox3.Visible = false;
                label3.Visible = false;
                // третий сотрудник ВЫКЛ
                comboBox4.Visible = false;
                label4.Visible = false;
            }
            else // 3 человека в бригаде
            {
                //первый сотрудник ВКЛ
                comboBox2.Visible = true;
                label2.Visible = true;
                // второй сотрудник ВЫКЛ
                comboBox3.Visible = false;
                label3.Visible = false;
                // третий сотрудник ВЫКЛ
                comboBox4.Visible = false;
                label4.Visible = false;
            }

        }
        // водитель
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                comboBox3.Items.Clear();
                // включаем помощника
                comboBox3.Visible = true;
                label3.Visible = true;

                // подгружаем данные в помощника
                int driverId = GetEmployeeIdByFIO(comboBox2.SelectedItem.ToString());
                foreach (KeyValuePair<int, Employee> employee in employees)
                    if (employee.Key != driverId)
                        comboBox3.Items.Add($"{employee.Value.LastName} {employee.Value.Name} {employee.Value.Patronymic}");

            }
        }

        // помощник
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1) // если 3 человека в бригаде
            {
                if (comboBox3.SelectedIndex != -1)
                {
                    comboBox4.Items.Clear();
                    // включаем инструктора
                    comboBox4.Visible = true;
                    label4.Visible = true;

                    // подгружаем данные в инструктора
                    foreach (KeyValuePair<int, Employee> employee in employees)
                    {
                        int driverId = GetEmployeeIdByFIO(comboBox2.SelectedItem.ToString());
                        int helperId = GetEmployeeIdByFIO(comboBox3.SelectedItem.ToString());
                        if (employee.Key != driverId && employee.Key != helperId)
                            comboBox4.Items.Add($"{employee.Value.LastName} {employee.Value.Name} {employee.Value.Patronymic}");
                    }
                }
            }
        }

        private void newBrigade_Load(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            label2.Visible = false;
            comboBox3.Visible = false;
            label3.Visible = false;
            comboBox4.Visible = false;
            label4.Visible = false;

            var connection = new OracleConnection(ConnectionString);
            connection.Open();
            OracleCommand OC = new OracleCommand($"select id, lastname, name, patronymic from employee", connection);
            OracleDataReader odr = OC.ExecuteReader();
            while (odr.Read())
            {

                Employee newEmployee = new Employee()
                {
                    LastName = odr.GetString(1),
                    Name = odr.GetString(2),
                    Patronymic = odr.GetString(3)
                };
                employees.Add(odr.GetInt32(0), newEmployee);
                comboBox2.Items.Add($"{newEmployee.LastName} {newEmployee.Name} {newEmployee.Patronymic}");
            }
            connection.Close();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Вы не выбрали ничего!");
            else if (comboBox2.SelectedIndex == -1)
                MessageBox.Show("Вы не выбрали водителя!");
            else if (comboBox3.SelectedIndex == -1)
                MessageBox.Show("Вы не выбрали помощника!");
            else if (comboBox1.SelectedIndex == 1 && comboBox4.SelectedIndex == -1)
                MessageBox.Show("Вы не выбрали инструктора!");
            else
            {
                int InstructorId = -1;
                if (comboBox1.SelectedIndex == 1)
                    InstructorId = GetEmployeeIdByFIO(comboBox4.SelectedItem.ToString());
                

                var connection = new OracleConnection(ConnectionString);
                connection.Open();

                int driverId = GetEmployeeIdByFIO(comboBox2.SelectedItem.ToString());
                int helperId = GetEmployeeIdByFIO(comboBox3.SelectedItem.ToString());
                OracleCommand OC;
                if(InstructorId == -1)
                    OC = new OracleCommand($"select count(*) from brigade where driver = '{driverId}' and Assistant = '{helperId}'", connection);
                else
                    OC = new OracleCommand($"select count(*) from brigade where driver = '{driverId}' and Assistant = '{helperId}' and Instructor = '{InstructorId}'", connection);

                int cntOfRowsInDb = Convert.ToInt32(OC.ExecuteScalar().ToString());
                if (cntOfRowsInDb > 0)
                    MessageBox.Show("Такая бригада уже существует в базе данных!");
                else
                {
                    if (comboBox1.SelectedIndex == 0) // 2 человека
                        DW.InsertDataIntoTable("brigade", new string[] { driverId.ToString(), helperId.ToString(), null });
                    else
                        DW.InsertDataIntoTable("brigade", new string[] { driverId.ToString(), helperId.ToString(), InstructorId.ToString()});
                }
                connection.Close();
            }
        }

        private int GetEmployeeIdByFIO(string FIO)
        {
            string[] tmp = FIO.Split(' ');
            return employees.Where(x => x.Value.LastName == tmp[0] && x.Value.Name == tmp[1] && x.Value.Patronymic == tmp[2])
                            .FirstOrDefault()
                            .Key;
        }
    }

    public class Employee
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
    }
}
