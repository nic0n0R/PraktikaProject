using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using PraktikaProject.CRUD.Create;
using PraktikaProject.CRUD;

namespace PraktikaProject
{
    public partial class UserSqlRequest : Form
    {
        static DataWorker DW = new DataWorker();
        static string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");
        public UserSqlRequest()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            string command = richTextBox1.Text.Trim().Replace('\n', ' ').ToLower();
            if (!command.StartsWith("select"))
                MessageBox.Show("Вы написали не select-запрос, исправьтесь!");
            else
            {
                try
                {
                    DataTable DT = DW.ExecuteUserCommand(command);
                    dataGridView1.DataSource = DT;
                } 
                catch( Exception ex)
                {
                    MessageBox.Show($"У вас ошибка в запросе: {ex.Message}");
                }
            } 
                
            
        }
    }
}
