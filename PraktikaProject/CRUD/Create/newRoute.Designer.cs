
namespace PraktikaProject.CRUD.Create
{
    partial class newRoute
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateWayPicker = new System.Windows.Forms.DateTimePicker();
            this.numWayTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LokomotiveComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BrigadeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата маршнута";
            // 
            // dateWayPicker
            // 
            this.dateWayPicker.CustomFormat = "yyyy/MM/dd";
            this.dateWayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateWayPicker.Location = new System.Drawing.Point(15, 46);
            this.dateWayPicker.Name = "dateWayPicker";
            this.dateWayPicker.Size = new System.Drawing.Size(235, 20);
            this.dateWayPicker.TabIndex = 1;
            // 
            // numWayTextBox
            // 
            this.numWayTextBox.Location = new System.Drawing.Point(15, 116);
            this.numWayTextBox.Name = "numWayTextBox";
            this.numWayTextBox.Size = new System.Drawing.Size(235, 20);
            this.numWayTextBox.TabIndex = 2;
            this.numWayTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numWayTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер маршрута";
            // 
            // LokomotiveComboBox
            // 
            this.LokomotiveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LokomotiveComboBox.FormattingEnabled = true;
            this.LokomotiveComboBox.Location = new System.Drawing.Point(15, 180);
            this.LokomotiveComboBox.Name = "LokomotiveComboBox";
            this.LokomotiveComboBox.Size = new System.Drawing.Size(238, 21);
            this.LokomotiveComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Локомотив";
            // 
            // BrigadeComboBox
            // 
            this.BrigadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrigadeComboBox.FormattingEnabled = true;
            this.BrigadeComboBox.Location = new System.Drawing.Point(15, 242);
            this.BrigadeComboBox.Name = "BrigadeComboBox";
            this.BrigadeComboBox.Size = new System.Drawing.Size(238, 21);
            this.BrigadeComboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Бригада";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить маршрут";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BrigadeComboBox);
            this.Controls.Add(this.LokomotiveComboBox);
            this.Controls.Add(this.numWayTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateWayPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "newRoute";
            this.Text = "Добавление нового маршрута";
            this.Load += new System.EventHandler(this.newRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateWayPicker;
        private System.Windows.Forms.TextBox numWayTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LokomotiveComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BrigadeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}