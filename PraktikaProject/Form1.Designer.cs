
namespace PraktikaProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выберитеТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бригадаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дорогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.станцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.депоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серийникиЛокомотивовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.локомотивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кодыСледованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.локомотивыВРазныхСоединенияхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рабочееВремяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.следованиеЛокБригадыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходЭлектроэнергииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аСЛНИСветофорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.sqlButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TableNameLabel = new System.Windows.Forms.Label();
            this.RouteReportButton = new System.Windows.Forms.Button();
            this.RefreshDataGridViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 427);
            this.dataGridView1.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 280);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 54);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddData_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выберитеТаблицуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выберитеТаблицуToolStripMenuItem
            // 
            this.выберитеТаблицуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.бригадаToolStripMenuItem,
            this.дорогаToolStripMenuItem,
            this.нодаToolStripMenuItem,
            this.станцииToolStripMenuItem,
            this.депоToolStripMenuItem,
            this.серийникиЛокомотивовToolStripMenuItem,
            this.локомотивToolStripMenuItem,
            this.маршрутToolStripMenuItem,
            this.кодыСледованияToolStripMenuItem,
            this.локомотивыВРазныхСоединенияхToolStripMenuItem,
            this.рабочееВремяToolStripMenuItem,
            this.следованиеЛокБригадыToolStripMenuItem,
            this.расходЭлектроэнергииToolStripMenuItem,
            this.аСЛНИСветофорыToolStripMenuItem});
            this.выберитеТаблицуToolStripMenuItem.Name = "выберитеТаблицуToolStripMenuItem";
            this.выберитеТаблицуToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.выберитеТаблицуToolStripMenuItem.Text = "Таблицы";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // бригадаToolStripMenuItem
            // 
            this.бригадаToolStripMenuItem.Name = "бригадаToolStripMenuItem";
            this.бригадаToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.бригадаToolStripMenuItem.Text = "Бригада";
            this.бригадаToolStripMenuItem.Click += new System.EventHandler(this.бригадаToolStripMenuItem_Click);
            // 
            // дорогаToolStripMenuItem
            // 
            this.дорогаToolStripMenuItem.Name = "дорогаToolStripMenuItem";
            this.дорогаToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.дорогаToolStripMenuItem.Text = "Дорога";
            this.дорогаToolStripMenuItem.Click += new System.EventHandler(this.дорогаToolStripMenuItem_Click);
            // 
            // нодаToolStripMenuItem
            // 
            this.нодаToolStripMenuItem.Name = "нодаToolStripMenuItem";
            this.нодаToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.нодаToolStripMenuItem.Text = "Нода";
            this.нодаToolStripMenuItem.Click += new System.EventHandler(this.нодаToolStripMenuItem_Click);
            // 
            // станцииToolStripMenuItem
            // 
            this.станцииToolStripMenuItem.Name = "станцииToolStripMenuItem";
            this.станцииToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.станцииToolStripMenuItem.Text = "Станции";
            this.станцииToolStripMenuItem.Click += new System.EventHandler(this.станцииToolStripMenuItem_Click);
            // 
            // депоToolStripMenuItem
            // 
            this.депоToolStripMenuItem.Name = "депоToolStripMenuItem";
            this.депоToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.депоToolStripMenuItem.Text = "Депо";
            this.депоToolStripMenuItem.Click += new System.EventHandler(this.депоToolStripMenuItem_Click);
            // 
            // серийникиЛокомотивовToolStripMenuItem
            // 
            this.серийникиЛокомотивовToolStripMenuItem.Name = "серийникиЛокомотивовToolStripMenuItem";
            this.серийникиЛокомотивовToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.серийникиЛокомотивовToolStripMenuItem.Text = "Серийники локомотивов";
            this.серийникиЛокомотивовToolStripMenuItem.Click += new System.EventHandler(this.серийникиЛокомотивовToolStripMenuItem_Click);
            // 
            // локомотивToolStripMenuItem
            // 
            this.локомотивToolStripMenuItem.Name = "локомотивToolStripMenuItem";
            this.локомотивToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.локомотивToolStripMenuItem.Text = "Локомотив";
            this.локомотивToolStripMenuItem.Click += new System.EventHandler(this.локомотивToolStripMenuItem_Click);
            // 
            // маршрутToolStripMenuItem
            // 
            this.маршрутToolStripMenuItem.Name = "маршрутToolStripMenuItem";
            this.маршрутToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.маршрутToolStripMenuItem.Text = "Маршрут";
            this.маршрутToolStripMenuItem.Click += new System.EventHandler(this.маршрутToolStripMenuItem_Click);
            // 
            // кодыСледованияToolStripMenuItem
            // 
            this.кодыСледованияToolStripMenuItem.Name = "кодыСледованияToolStripMenuItem";
            this.кодыСледованияToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.кодыСледованияToolStripMenuItem.Text = "Коды следования";
            this.кодыСледованияToolStripMenuItem.Click += new System.EventHandler(this.кодыСледованияToolStripMenuItem_Click);
            // 
            // локомотивыВРазныхСоединенияхToolStripMenuItem
            // 
            this.локомотивыВРазныхСоединенияхToolStripMenuItem.Name = "локомотивыВРазныхСоединенияхToolStripMenuItem";
            this.локомотивыВРазныхСоединенияхToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.локомотивыВРазныхСоединенияхToolStripMenuItem.Text = "Локомотивы в соединениях";
            this.локомотивыВРазныхСоединенияхToolStripMenuItem.Click += new System.EventHandler(this.локомотивыВРазныхСоединенияхToolStripMenuItem_Click);
            // 
            // рабочееВремяToolStripMenuItem
            // 
            this.рабочееВремяToolStripMenuItem.Name = "рабочееВремяToolStripMenuItem";
            this.рабочееВремяToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.рабочееВремяToolStripMenuItem.Text = "Рабочее время";
            this.рабочееВремяToolStripMenuItem.Click += new System.EventHandler(this.рабочееВремяToolStripMenuItem_Click);
            // 
            // следованиеЛокБригадыToolStripMenuItem
            // 
            this.следованиеЛокБригадыToolStripMenuItem.Name = "следованиеЛокБригадыToolStripMenuItem";
            this.следованиеЛокБригадыToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.следованиеЛокБригадыToolStripMenuItem.Text = "Следование лок. бригады";
            this.следованиеЛокБригадыToolStripMenuItem.Click += new System.EventHandler(this.следованиеЛокБригадыToolStripMenuItem_Click);
            // 
            // расходЭлектроэнергииToolStripMenuItem
            // 
            this.расходЭлектроэнергииToolStripMenuItem.Name = "расходЭлектроэнергииToolStripMenuItem";
            this.расходЭлектроэнергииToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.расходЭлектроэнергииToolStripMenuItem.Text = "Расход электроэнергии";
            this.расходЭлектроэнергииToolStripMenuItem.Click += new System.EventHandler(this.расходЭлектроэнергииToolStripMenuItem_Click);
            // 
            // аСЛНИСветофорыToolStripMenuItem
            // 
            this.аСЛНИСветофорыToolStripMenuItem.Name = "аСЛНИСветофорыToolStripMenuItem";
            this.аСЛНИСветофорыToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.аСЛНИСветофорыToolStripMenuItem.Text = "АСЛН и светофоры";
            this.аСЛНИСветофорыToolStripMenuItem.Click += new System.EventHandler(this.аСЛНИСветофорыToolStripMenuItem_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(12, 400);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(123, 54);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(12, 340);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(123, 54);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.AddData_Click);
            // 
            // sqlButton
            // 
            this.sqlButton.Location = new System.Drawing.Point(12, 223);
            this.sqlButton.Name = "sqlButton";
            this.sqlButton.Size = new System.Drawing.Size(123, 51);
            this.sqlButton.TabIndex = 5;
            this.sqlButton.Text = "SQL - запрос";
            this.sqlButton.UseVisualStyleBackColor = true;
            this.sqlButton.Click += new System.EventHandler(this.sqlButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Таблица: ";
            // 
            // TableNameLabel
            // 
            this.TableNameLabel.AutoSize = true;
            this.TableNameLabel.Location = new System.Drawing.Point(191, 9);
            this.TableNameLabel.Name = "TableNameLabel";
            this.TableNameLabel.Size = new System.Drawing.Size(0, 13);
            this.TableNameLabel.TabIndex = 6;
            // 
            // RouteReportButton
            // 
            this.RouteReportButton.Location = new System.Drawing.Point(12, 166);
            this.RouteReportButton.Name = "RouteReportButton";
            this.RouteReportButton.Size = new System.Drawing.Size(123, 51);
            this.RouteReportButton.TabIndex = 5;
            this.RouteReportButton.Text = "Отчёт по маршруту";
            this.RouteReportButton.UseVisualStyleBackColor = true;
            this.RouteReportButton.Click += new System.EventHandler(this.RouteReportButton_Click);
            // 
            // RefreshDataGridViewButton
            // 
            this.RefreshDataGridViewButton.Location = new System.Drawing.Point(12, 28);
            this.RefreshDataGridViewButton.Name = "RefreshDataGridViewButton";
            this.RefreshDataGridViewButton.Size = new System.Drawing.Size(123, 45);
            this.RefreshDataGridViewButton.TabIndex = 7;
            this.RefreshDataGridViewButton.Text = "Обновить данные";
            this.RefreshDataGridViewButton.UseVisualStyleBackColor = true;
            this.RefreshDataGridViewButton.Click += new System.EventHandler(this.RefreshDataGridViewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 466);
            this.Controls.Add(this.RefreshDataGridViewButton);
            this.Controls.Add(this.TableNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RouteReportButton);
            this.Controls.Add(this.sqlButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Работа с базой данных \"ГП Железная дорога\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выберитеТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бригадаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дорогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нодаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem станцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem депоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серийникиЛокомотивовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem локомотивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кодыСледованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem локомотивыВРазныхСоединенияхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рабочееВремяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem следованиеЛокБригадыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расходЭлектроэнергииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аСЛНИСветофорыToolStripMenuItem;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button sqlButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RouteReportButton;
        private System.Windows.Forms.Button RefreshDataGridViewButton;
        public System.Windows.Forms.Label TableNameLabel;
    }
}

