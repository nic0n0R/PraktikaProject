using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using System.Configuration;

namespace PraktikaProject.CRUD.Create
{
    public partial class newLokomotiv : Form
    {
        DataWorker DW = new DataWorker();
        string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
        public newLokomotiv()
        {
            InitializeComponent();
        }

        private void newLokomotiv_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4;

            var connection = new OracleConnection(ConnectionString);
            connection.Open();
            OracleCommand OC = new OracleCommand($"select name from depo", connection);
            OracleDataReader odr = OC.ExecuteReader();
            while (odr.Read())
                depoComboBox.Items.Add(odr.GetString(0));
            depoComboBox.SelectedIndex = 0;

            OracleCommand OC2 = new OracleCommand($"select serial from lokomotive_serial", connection);
            OracleDataReader odr2 = OC2.ExecuteReader();
            while (odr2.Read())
                serialComboBox.Items.Add(odr2.GetString(0));
            serialComboBox.SelectedIndex = 0;

            connection.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lokomotiveNumber = textBox1.Text;
            if (lokomotiveNumber == String.Empty)
                MessageBox.Show("Вы не ввели название ноды!");
            else
            {
                var connection = new OracleConnection(ConnectionString);
                connection.Open();
                // проверка на то, есть ли уже локомотив в таблице
                OracleCommand OC = new OracleCommand($"select count(*) from lokomotive where LNumber = '{lokomotiveNumber}'", connection);
                int cntOfRowsInDb = Convert.ToInt32(OC.ExecuteScalar().ToString());
                if (cntOfRowsInDb > 0)
                    MessageBox.Show("Такой локомотив уже существует в базе данных!");
                else
                {
                    // получаем id депо и сериала
                    OracleCommand OCDepoIdCmd = new OracleCommand($"select id from depo where name = '{depoComboBox.SelectedItem.ToString()}'", connection);
                    OracleCommand OCSerialIdCmd = new OracleCommand($"select id from lokomotive_serial where serial = '{serialComboBox.SelectedItem.ToString()}'", connection);
                    int depoId   = Convert.ToInt32(OCDepoIdCmd.ExecuteScalar().ToString());
                    int SerialId = Convert.ToInt32(OCSerialIdCmd.ExecuteScalar().ToString());
                    DW.InsertDataIntoTable("lokomotive", new string[] { lokomotiveNumber, depoId.ToString(), SerialId.ToString() });
                }
                connection.Close();
            }
        }
    }
}
