using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace PraktikaProject.CRUD.Create
{
    public partial class newRoad : Form
    {
        DataWorker DW = new DataWorker();
        public newRoad()
        {
            InitializeComponent();
            textBox1.MaxLength = 30;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
                MessageBox.Show("Вы не ввели название дороги!");
            else
            {
                string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
                var connection = new OracleConnection(ConnectionString);
                connection.Open();
                OracleCommand OC = new OracleCommand($"select count(*) from road where name = '{textBox1.Text}'", connection);
                OracleDataReader odr = OC.ExecuteReader();
                int cntOfRowsInDb = 0;
                while (odr.Read())
                    cntOfRowsInDb = odr.GetInt32(0);
                if (cntOfRowsInDb > 0)
                    MessageBox.Show("Такая дорога уже существует в базе данных!");
                else
                    DW.InsertDataIntoTable("road", new string[] { textBox1.Text });
                connection.Close();
            }
        }
    }
}
