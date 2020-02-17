namespace kursovaya2
{
    partial class changesAuditoriumsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.аУДИТОРИЯBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buildingNumcb = new System.Windows.Forms.ComboBox();
            this.auditoriumNummtb = new System.Windows.Forms.MaskedTextBox();
            this.typecb = new System.Windows.Forms.ComboBox();
            this.statuscb = new System.Windows.Forms.ComboBox();
            this.capacitynud = new System.Windows.Forms.NumericUpDown();
            this.audBtnInsert = new System.Windows.Forms.Button();
            this.audBtnUpdate = new System.Windows.Forms.Button();
            this.audBtnDelete = new System.Windows.Forms.Button();
            this.audBtnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аУДИТОРИЯBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacitynud)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 321);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged); 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер корпуса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер аудитории";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Состояние";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Вместимость";
            // 
            // buildingNumcb
            // 
            this.buildingNumcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildingNumcb.FormattingEnabled = true;
            this.buildingNumcb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.buildingNumcb.Location = new System.Drawing.Point(470, 37);
            this.buildingNumcb.Name = "buildingNumcb";
            this.buildingNumcb.Size = new System.Drawing.Size(39, 21);
            this.buildingNumcb.TabIndex = 6;
            this.buildingNumcb.TextChanged += new System.EventHandler(this.buildingNumcb_TextChanged);
            // 
            // auditoriumNummtb
            // 
            this.auditoriumNummtb.Location = new System.Drawing.Point(470, 87);
            this.auditoriumNummtb.Mask = "000L";
            this.auditoriumNummtb.Name = "auditoriumNummtb";
            this.auditoriumNummtb.Size = new System.Drawing.Size(39, 20);
            this.auditoriumNummtb.TabIndex = 7;
            this.auditoriumNummtb.TextChanged += new System.EventHandler(this.buildingNumcb_TextChanged);
            // 
            // typecb
            // 
            this.typecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typecb.FormattingEnabled = true;
            this.typecb.Items.AddRange(new object[] {
            "Большая лекционная",
            "Компьютерный класс",
            "Для упражнений, семинаров",
            "Лаборатория",
            "Малая лекционная"});
            this.typecb.Location = new System.Drawing.Point(470, 187);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(146, 21);
            this.typecb.TabIndex = 8;
            this.typecb.TextChanged += new System.EventHandler(this.buildingNumcb_TextChanged);
            // 
            // statuscb
            // 
            this.statuscb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statuscb.FormattingEnabled = true;
            this.statuscb.Items.AddRange(new object[] {
            "Используется",
            "На ремонте"});
            this.statuscb.Location = new System.Drawing.Point(470, 137);
            this.statuscb.Name = "statuscb";
            this.statuscb.Size = new System.Drawing.Size(146, 21);
            this.statuscb.TabIndex = 9;
            this.statuscb.TextChanged += new System.EventHandler(this.buildingNumcb_TextChanged);
            // 
            // capacitynud
            // 
            this.capacitynud.Location = new System.Drawing.Point(470, 240);
            this.capacitynud.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.capacitynud.Name = "capacitynud";
            this.capacitynud.Size = new System.Drawing.Size(73, 20);
            this.capacitynud.TabIndex = 10;
            this.capacitynud.ValueChanged += new System.EventHandler(this.buildingNumcb_TextChanged);
            // 
            // audBtnInsert
            // 
            this.audBtnInsert.Location = new System.Drawing.Point(589, 15);
            this.audBtnInsert.Name = "audBtnInsert";
            this.audBtnInsert.Size = new System.Drawing.Size(83, 23);
            this.audBtnInsert.TabIndex = 11;
            this.audBtnInsert.Text = "Вставить";
            this.audBtnInsert.UseVisualStyleBackColor = true;
            this.audBtnInsert.Click += new System.EventHandler(this.audBtnInsert_Click);
            // 
            // audBtnUpdate
            // 
            this.audBtnUpdate.Location = new System.Drawing.Point(589, 44);
            this.audBtnUpdate.Name = "audBtnUpdate";
            this.audBtnUpdate.Size = new System.Drawing.Size(83, 23);
            this.audBtnUpdate.TabIndex = 12;
            this.audBtnUpdate.Text = "Изменить";
            this.audBtnUpdate.UseVisualStyleBackColor = true;
            this.audBtnUpdate.Click += new System.EventHandler(this.audBtnUpdate_Click);
            // 
            // audBtnDelete
            // 
            this.audBtnDelete.Location = new System.Drawing.Point(589, 73);
            this.audBtnDelete.Name = "audBtnDelete";
            this.audBtnDelete.Size = new System.Drawing.Size(83, 23);
            this.audBtnDelete.TabIndex = 13;
            this.audBtnDelete.Text = "Удалить";
            this.audBtnDelete.UseVisualStyleBackColor = true;
            this.audBtnDelete.Click += new System.EventHandler(this.audBtnDelete_Click);
            // 
            // audBtnRefresh
            // 
            this.audBtnRefresh.Location = new System.Drawing.Point(589, 102);
            this.audBtnRefresh.Name = "audBtnRefresh";
            this.audBtnRefresh.Size = new System.Drawing.Size(83, 23);
            this.audBtnRefresh.TabIndex = 14;
            this.audBtnRefresh.Text = "Сохранить";
            this.audBtnRefresh.UseVisualStyleBackColor = true;
            this.audBtnRefresh.Click += new System.EventHandler(this.audBtnRefresh_Click);
            // 
            // changesAuditoriumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 326);
            this.Controls.Add(this.audBtnRefresh);
            this.Controls.Add(this.audBtnDelete);
            this.Controls.Add(this.audBtnUpdate);
            this.Controls.Add(this.audBtnInsert);
            this.Controls.Add(this.capacitynud);
            this.Controls.Add(this.statuscb);
            this.Controls.Add(this.typecb);
            this.Controls.Add(this.auditoriumNummtb);
            this.Controls.Add(this.buildingNumcb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "changesAuditoriumsForm";
            this.Text = "Изменение информации об аудиториях";
            this.Load += new System.EventHandler(this.changesAuditoriumsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аУДИТОРИЯBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacitynud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource аУДИТОРИЯBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox buildingNumcb;
        private System.Windows.Forms.MaskedTextBox auditoriumNummtb;
        private System.Windows.Forms.ComboBox typecb;
        private System.Windows.Forms.ComboBox statuscb;
        private System.Windows.Forms.NumericUpDown capacitynud;
        private System.Windows.Forms.Button audBtnInsert;
        private System.Windows.Forms.Button audBtnUpdate;
        private System.Windows.Forms.Button audBtnDelete;
        private System.Windows.Forms.Button audBtnRefresh;
    }
}