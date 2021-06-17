using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using System.Configuration;

namespace PraktikaProject.CRUD.Create
{
    public partial class newNoda : Form
    {
        DataWorker DW = new DataWorker();
        string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
        public newNoda()
        {
            InitializeComponent();
        }

        private void newNoda_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 20;
            
            var connection = new OracleConnection(ConnectionString);
            connection.Open();
            OracleCommand OC = new OracleCommand($"select name from road", connection);
            OracleDataReader odr = OC.ExecuteReader();
            while (odr.Read())
                comboBox1.Items.Add(odr.GetString(0));
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nodaName = textBox1.Text;
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Вы не выбрали дорогу!");
            else if (nodaName == String.Empty)
                MessageBox.Show("Вы не ввели название ноды!");
            else
            {
                var connection = new OracleConnection(ConnectionString);
                connection.Open();
                // проверка на то, есть ли уже нода в таблице
                OracleCommand OC = new OracleCommand($"select count(*) from noda where name = '{nodaName}'", connection);
                OracleDataReader odr = OC.ExecuteReader();
                int cntOfRowsInDb = 0;
                while (odr.Read())
                    cntOfRowsInDb = odr.GetInt32(0);
                if (cntOfRowsInDb > 0)
                    MessageBox.Show("Такая Нода уже существует в базе данных!");
                else
                {
                    // получаем id дороги
                    OracleCommand OCroadId = new OracleCommand($"select id from road where name = '{comboBox1.SelectedItem.ToString()}'", connection);
                    OracleDataReader odrRoadId = OCroadId.ExecuteReader();
                    int RoadId = 0;
                    while (odrRoadId.Read())
                        RoadId = odrRoadId.GetInt32(0);
                    DW.InsertDataIntoTable("noda", new string[] { nodaName, RoadId.ToString() });
                }
                connection.Close();
            }
        }
    }
}
