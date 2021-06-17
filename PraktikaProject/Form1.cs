using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using PraktikaProject.CRUD.Create;
using PraktikaProject.CRUD;

namespace PraktikaProject
{
    public partial class Form1 : Form
    {
        static CRUDManager crudm = new CRUDManager();
        static DataWorker DW = new DataWorker();
        static string ConnectionString = ConfigurationManager.AppSettings.Get("ConnectionString");


        public Form1()
        {
            InitializeComponent();
            // Никакая таблица при старте не выбрана
            crudm.LastClickedButton = 0;
            // Пользователь не может выбрать более одной строки за раз
            dataGridView1.MultiSelect = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // добавление новых данных в таблицу
        private void AddData_Click(object sender, EventArgs e)
        {
            switch (crudm.LastClickedButton)
            {
                case (int)Tables.None:
                    MessageBox.Show("Вы ещё не выбрали ни одной таблицы!");
                    break;

                case (int)Tables.Employee:
                    NewEmployee ne = new NewEmployee();
                    ne.ShowDialog();
                    break;
                case (int)Tables.Brigade:
                    newBrigade1 nb = new newBrigade1();
                    nb.ShowDialog();
                    break;
                case (int)Tables.Road:
                    newRoad nr = new newRoad();
                    nr.ShowDialog();
                    break;
                case (int)Tables.Noda:
                    newNoda nn = new newNoda();
                    nn.ShowDialog();
                    break;
                case (int)Tables.Station:
                    newStation ns = new newStation();
                    ns.ShowDialog();
                    break;
                case (int)Tables.Depo:
                    newDepo nd = new newDepo();
                    nd.ShowDialog();
                    break;
                case (int)Tables.Lokomitiv_serial:
                    newLokomotiv_serial nls = new newLokomotiv_serial();
                    nls.ShowDialog();
                    break;
                case (int)Tables.Lokomotiv:
                    newLokomotiv nl = new newLokomotiv();
                    nl.ShowDialog();
                    break;
                case (int)Tables.Route:
                    newRoute nroute = new newRoute();
                    nroute.ShowDialog();
                    break;
                case (int)Tables.Follow_up:
                    newFollow_up nfu = new newFollow_up();
                    nfu.ShowDialog();
                    break;
                case (int)Tables.Lokomotiv_changed_state:
                    newLokomotiv_changed_state nlcs = new newLokomotiv_changed_state();
                    nlcs.ShowDialog();
                    break;
                case (int)Tables.Route_timing:
                    newRouteTiming nrt = new newRouteTiming();
                    nrt.ShowDialog();
                    break;
                case (int)Tables.Lokomotive_crew_passengers:
                    newLokomotive_crew_passengers nlcp = new newLokomotive_crew_passengers();
                    nlcp.ShowDialog();
                    break;
                case (int)Tables.Drain_energy:
                    newDrain_energy nde = new newDrain_energy();
                    nde.ShowDialog();
                    break;
                case (int)Tables.ALCN_and_traffic_lights:
                    newALCN_and_traffic_lights naatl = new newALCN_and_traffic_lights();
                    naatl.ShowDialog();
                    break;
            }
        }

        #region showTables
        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "employee";
            DataTable DT = DW.RefreshDataInGridView("employee");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Employee;
        }

        private void бригадаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "brigade";
            var DT = DW.RefreshDataInGridView("brigade");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Brigade;
        }

        private void дорогаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "road";
            var DT = DW.RefreshDataInGridView("road");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Road;
        }

        private void нодаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "noda";
            var DT = DW.RefreshDataInGridView("noda");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Noda;
        }

        private void станцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "station";
            var DT = DW.RefreshDataInGridView("station");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Station;
        }

        private void депоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "depo";
            var DT = DW.RefreshDataInGridView("depo");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Depo;
        }

        private void серийникиЛокомотивовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "Lokomotive_serial";
            var DT = DW.RefreshDataInGridView("Lokomotive_serial");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Lokomitiv_serial;
        }

        private void локомотивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "lokomotive";
            var DT = DW.RefreshDataInGridView("lokomotive");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Lokomotiv;
        }

        private void маршрутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "route";
            var DT = DW.RefreshDataInGridView("route");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Route;
        }

        private void кодыСледованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "follow_up";
            var DT = DW.RefreshDataInGridView("follow_up");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Follow_up;
        }

        private void локомотивыВРазныхСоединенияхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "Lokomotive_changed_state";
            var DT = DW.RefreshDataInGridView("Lokomotive_changed_state");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Lokomotiv_changed_state;
        }

        private void рабочееВремяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "route_timing";
            var DT = DW.RefreshDataInGridView("route_timing");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Route_timing;
        }

        private void следованиеЛокБригадыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "lokomotive_crew_passengers";
            var DT = DW.RefreshDataInGridView("lokomotive_crew_passengers");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Lokomotive_crew_passengers;
        }

        private void расходЭлектроэнергииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "drain_energy";
            var DT = DW.RefreshDataInGridView("drain_energy");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.Drain_energy;
        }

        private void аСЛНИСветофорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableNameLabel.Text = "ALCN_and_traffic_lights";
            var DT = DW.RefreshDataInGridView("ALCN_and_traffic_lights");
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
            crudm.LastClickedButton = (int)Tables.ALCN_and_traffic_lights;
        }
        #endregion

        // удаление строки из таблицы
        private void removeButton_Click(object sender, EventArgs e)
        {
            if(TableNameLabel.Text == String.Empty)
            {
                MessageBox.Show("Вы не выбрали таблицу!");
                goto endMethod;
            }
            if (dataGridView1.SelectedCells.Count == 0 && dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали строку!");
                goto endMethod;
            }

            var tableName = TableNameLabel.Text;
            var rowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dataGridView1[0, rowIndex].Value);


            DW.RemoveRowFromTableById(tableName, id); // удалить строку из таблицы

        endMethod:
            Console.WriteLine();
        }



        //Пользовательский sql запрос
        private void sqlButton_Click(object sender, EventArgs e)
        {
            UserSqlRequest usr = new UserSqlRequest();
            usr.Show();
        }

        private void RefreshDataGridViewButton_Click(object sender, EventArgs e)
        {
            var DT = DW.RefreshDataInGridView(TableNameLabel.Text);
            dataGridView1.DataSource = DT;
            dataGridView1.Update();
        }

        private void RouteReportButton_Click(object sender, EventArgs e)
        {
        }
    }
}
