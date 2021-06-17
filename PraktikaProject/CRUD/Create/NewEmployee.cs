using System;
using System.Windows.Forms;
using PraktikaProject.CRUD;

namespace PraktikaProject.CRUD.Create
{
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
            ClassTextBox.MaxLength = 1;
        }

        private void ClassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataWorker DW = new DataWorker();
            try {
                DW.InsertDataIntoTable("employee", new string[] {
                FirstNameTextBox.Text,
                LastNameTextBox.Text,
                PatronymicTextBox.Text,
                ClassTextBox.Text });

                DW.RefreshDataInGridView("employee");
                
            } catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении нового сотрудника: {ex.Message}");
            }
        }
    }
}
