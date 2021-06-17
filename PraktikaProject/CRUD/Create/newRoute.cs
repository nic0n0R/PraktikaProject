using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using System.Configuration;

namespace PraktikaProject.CRUD.Create
{
    public partial class newRoute : Form
    {
        DataWorker DW = new DataWorker();
        string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
        public newRoute()
        {
            InitializeComponent();
        }

        private void newRoute_Load(object sender, EventArgs e)
        {
            numWayTextBox.MaxLength = 3;

            var connection = new OracleConnection(ConnectionString);
            connection.Open();
            OracleCommand OC = new OracleCommand($"select LNumber from lokomotive", connection);
            OracleDataReader odr = OC.ExecuteReader();
            while (odr.Read())
                LokomotiveComboBox.Items.Add(odr.GetString(0));
            LokomotiveComboBox.SelectedIndex = 0;

            OracleCommand OC2 = new OracleCommand($"select id from Brigade", connection);
            OracleDataReader odr2 = OC2.ExecuteReader();
            while (odr2.Read())
                BrigadeComboBox.Items.Add(odr2.GetString(0));
            BrigadeComboBox.SelectedIndex = 0;

            connection.Close();
        }

        private void numWayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
