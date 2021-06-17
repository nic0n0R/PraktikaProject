using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace PraktikaProject.CRUD.Create
{
    public partial class newStation : Form
    {
        DataWorker DW = new DataWorker();
        string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
        public newStation()
        {
            InitializeComponent();
        }

        private void newStation_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 40;
            textBox2.MaxLength = 5;
            var connection = new OracleConnection(ConnectionString);
            connection.Open();
            OracleCommand OC = new OracleCommand($"select name from noda", connection);
            OracleDataReader odr = OC.ExecuteReader();
            while (odr.Read())
                comboBox1.Items.Add(odr.GetString(0));
            comboBox1.SelectedIndex = 0;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stationName = textBox1.Text;
            string ESR = textBox2.Text;

            if (textBox1.Text == String.Empty)
                MessageBox.Show("Вы не ввели название станции!");
            else if (textBox2.Text == String.Empty)
                MessageBox.Show("Вы не ввели ЕСР станции!");
            else
            {
                var connection = new OracleConnection(ConnectionString);
                connection.Open();
                // проверка на то, есть ли уже нода в таблице
                OracleCommand OC = new OracleCommand($"select count(*) from station where name = '{stationName}'", connection);
                int cntOfRowsInDb = Convert.ToInt32(OC.ExecuteScalar().ToString());
                if (cntOfRowsInDb > 0)
                    MessageBox.Show("Такая Нода уже существует в базе данных!");
                else
                {
                    // получаем id ноды
                    OracleCommand OCroadId = new OracleCommand($"select id from noda where name = '{comboBox1.SelectedItem.ToString()}'", connection);
                    int NodaId = Convert.ToInt32(OCroadId.ExecuteScalar().ToString());
                    DW.InsertDataIntoTable("station", new string[] { ESR, stationName, NodaId.ToString() });
                }
                connection.Close();

            }
        }
    }
}
