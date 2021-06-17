using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace PraktikaProject.CRUD.Create
{
    public partial class newDepo : Form
    {
        DataWorker DW = new DataWorker();
        string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
        public newDepo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string depoName = textBox1.Text;
            if (textBox1.Text == String.Empty)
                MessageBox.Show("Вы не ввели название депо!");
            else
            {
                var connection = new OracleConnection(ConnectionString);
                connection.Open();
                // проверка на то, есть ли уже нода в таблице
                OracleCommand OC = new OracleCommand($"select count(*) from depo where name = '{depoName}'", connection);
                int cntOfRowsInDb = Convert.ToInt32(OC.ExecuteScalar().ToString());
                if (cntOfRowsInDb > 0)
                    MessageBox.Show("Такое депо уже существует в базе данных!");
                else
                {
                    // получаем id станции
                    OracleCommand OCStationId = new OracleCommand($"select id from station where name = '{comboBox1.SelectedItem.ToString()}'", connection);
                    int stationId = Convert.ToInt32(OCStationId.ExecuteScalar().ToString());
                    MessageBox.Show($"id = {stationId}");
                    DW.InsertDataIntoTable("depo", new string[] { depoName, stationId.ToString() });
                }
                connection.Close();

            }
        }

        private void newDepo_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 40;
            var connection = new OracleConnection(ConnectionString);
            connection.Open();
            OracleCommand OC = new OracleCommand($"select name from station", connection);
            OracleDataReader odr = OC.ExecuteReader();
            while (odr.Read())
                comboBox1.Items.Add(odr.GetString(0));
            comboBox1.SelectedIndex = 0;
        }
    }
}
