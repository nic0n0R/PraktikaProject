using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace PraktikaProject.CRUD.Create
{
    public partial class newLokomotiv_serial : Form
    {
        DataWorker DW = new DataWorker();
        string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
        public newLokomotiv_serial()
        {
            InitializeComponent();
        }

        private void newLokomotiv_serial_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serial = textBox1.Text;
            if (serial == String.Empty)
                MessageBox.Show("Вы не ввели серийник!");
            else
            {
                var connection = new OracleConnection(ConnectionString);
                connection.Open();
                // проверка на то, есть ли уже нода в таблице
                OracleCommand OC = new OracleCommand($"select count(*) from Lokomotive_serial where Serial = '{serial}'", connection);
                int cntOfRowsInDb = Convert.ToInt32(OC.ExecuteScalar().ToString());
                if (cntOfRowsInDb > 0)
                    MessageBox.Show("Такой серийник уже существует в базе данных!");
                else
                    DW.InsertDataIntoTable("lokomotive_serial", new string[] { serial });
                
                connection.Close();
            }
        }
    }
}
