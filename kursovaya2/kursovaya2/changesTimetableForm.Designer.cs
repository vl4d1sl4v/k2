namespace kursovaya2
{
    partial class changesTimetableForm
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
            this.рАСПИСАНИЕBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.audCodecb = new System.Windows.Forms.ComboBox();
            this.аУДИТОРИЯBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weekcb = new System.Windows.Forms.ComboBox();
            this.PNmtb = new System.Windows.Forms.MaskedTextBox();
            this.VTmtb = new System.Windows.Forms.MaskedTextBox();
            this.SRmtb = new System.Windows.Forms.MaskedTextBox();
            this.CHTmtb = new System.Windows.Forms.MaskedTextBox();
            this.PTmtb = new System.Windows.Forms.MaskedTextBox();
            this.SBmtb = new System.Windows.Forms.MaskedTextBox();
            this.ttBtnIns = new System.Windows.Forms.Button();
            this.ttBtnUpd = new System.Windows.Forms.Button();
            this.ttBtnDel = new System.Windows.Forms.Button();
            this.ttBtnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рАСПИСАНИЕBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аУДИТОРИЯBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(871, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код аудитории";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Неделя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Занятия в ПН";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Занятия в ВТ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Занятия в СР";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Занятия в ЧТ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(664, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Занятия в ПТ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(764, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Занятия в СБ";
            // 
            // audCodecb
            // 
            this.audCodecb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.аУДИТОРИЯBindingSource, "Код аудитории", true));
            this.audCodecb.DataSource = this.аУДИТОРИЯBindingSource;
            this.audCodecb.DisplayMember = "Код аудитории";
            this.audCodecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audCodecb.FormattingEnabled = true;
            this.audCodecb.Location = new System.Drawing.Point(15, 242);
            this.audCodecb.Name = "audCodecb";
            this.audCodecb.Size = new System.Drawing.Size(78, 21);
            this.audCodecb.TabIndex = 9;
            this.audCodecb.ValueMember = "Код аудитории";
            this.audCodecb.TextChanged += new System.EventHandler(this.audCodecb_TextChanged);
            // 
            // аУДИТОРИЯBindingSource
            // 
            this.аУДИТОРИЯBindingSource.DataMember = "АУДИТОРИЯ";
            // 
            // weekcb
            // 
            this.weekcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weekcb.FormattingEnabled = true;
            this.weekcb.Items.AddRange(new object[] {
            "Над чертой",
            "Под чертой"});
            this.weekcb.Location = new System.Drawing.Point(142, 243);
            this.weekcb.Name = "weekcb";
            this.weekcb.Size = new System.Drawing.Size(89, 21);
            this.weekcb.TabIndex = 10;
            this.weekcb.TextChanged += new System.EventHandler(this.audCodecb_TextChanged);
            // 
            // PNmtb
            // 
            this.PNmtb.Location = new System.Drawing.Point(264, 243);
            this.PNmtb.Mask = "0000000";
            this.PNmtb.Name = "PNmtb";
            this.PNmtb.Size = new System.Drawing.Size(74, 20);
            this.PNmtb.TabIndex = 11;
            this.PNmtb.TextChanged += new System.EventHandler(this.audCodecb_TextChanged);
            // 
            // VTmtb
            // 
            this.VTmtb.Location = new System.Drawing.Point(362, 243);
            this.VTmtb.Mask = "0000000";
            this.VTmtb.Name = "VTmtb";
            this.VTmtb.Size = new System.Drawing.Size(72, 20);
            this.VTmtb.TabIndex = 12;
            this.VTmtb.TextChanged += new System.EventHandler(this.audCodecb_TextChanged);
            // 
            // SRmtb
            // 
            this.SRmtb.Location = new System.Drawing.Point(464, 242);
            this.SRmtb.Mask = "0000000";
            this.SRmtb.Name = "SRmtb";
            this.SRmtb.Size = new System.Drawing.Size(72, 20);
            this.SRmtb.TabIndex = 13;
            this.SRmtb.TextChanged += new System.EventHandler(this.audCodecb_TextChanged);
            // 
            // CHTmtb
            // 
            this.CHTmtb.Location = new System.Drawing.Point(569, 242);
            this.CHTmtb.Mask = "0000000";
            this.CHTmtb.Name = "CHTmtb";
            this.CHTmtb.Size = new System.Drawing.Size(73, 20);
            this.CHTmtb.TabIndex = 14;
            this.CHTmtb.TextChanged += new System.EventHandler(this.audCodecb_TextChanged);
            // 
            // PTmtb
            // 
            this.PTmtb.Location = new System.Drawing.Point(667, 242);
            this.PTmtb.Mask = "0000000";
            this.PTmtb.Name = "PTmtb";
            this.PTmtb.Size = new System.Drawing.Size(73, 20);
            this.PTmtb.TabIndex = 15;
            this.PTmtb.TextChanged += new System.EventHandler(this.audCodecb_TextChanged);
            // 
            // SBmtb
            // 
            this.SBmtb.Location = new System.Drawing.Point(767, 242);
            this.SBmtb.Mask = "0000000";
            this.SBmtb.Name = "SBmtb";
            this.SBmtb.Size = new System.Drawing.Size(72, 20);
            this.SBmtb.TabIndex = 16;
            this.SBmtb.TextChanged += new System.EventHandler(this.audCodecb_TextChanged);
            // 
            // ttBtnIns
            // 
            this.ttBtnIns.Location = new System.Drawing.Point(264, 280);
            this.ttBtnIns.Name = "ttBtnIns";
            this.ttBtnIns.Size = new System.Drawing.Size(75, 23);
            this.ttBtnIns.TabIndex = 17;
            this.ttBtnIns.Text = "Вставить";
            this.ttBtnIns.UseVisualStyleBackColor = true;
            this.ttBtnIns.Click += new System.EventHandler(this.ttBtnIns_Click);
            // 
            // ttBtnUpd
            // 
            this.ttBtnUpd.Location = new System.Drawing.Point(362, 280);
            this.ttBtnUpd.Name = "ttBtnUpd";
            this.ttBtnUpd.Size = new System.Drawing.Size(75, 23);
            this.ttBtnUpd.TabIndex = 18;
            this.ttBtnUpd.Text = "Изменить";
            this.ttBtnUpd.UseVisualStyleBackColor = true;
            this.ttBtnUpd.Click += new System.EventHandler(this.ttBtnUpd_Click);
            // 
            // ttBtnDel
            // 
            this.ttBtnDel.Location = new System.Drawing.Point(464, 280);
            this.ttBtnDel.Name = "ttBtnDel";
            this.ttBtnDel.Size = new System.Drawing.Size(75, 23);
            this.ttBtnDel.TabIndex = 19;
            this.ttBtnDel.Text = "Удалить";
            this.ttBtnDel.UseVisualStyleBackColor = true;
            this.ttBtnDel.Click += new System.EventHandler(this.ttBtnDel_Click);
            // 
            // ttBtnRefresh
            // 
            this.ttBtnRefresh.Location = new System.Drawing.Point(569, 280);
            this.ttBtnRefresh.Name = "ttBtnRefresh";
            this.ttBtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.ttBtnRefresh.TabIndex = 20;
            this.ttBtnRefresh.Text = "Сохранить";
            this.ttBtnRefresh.UseVisualStyleBackColor = true;
            this.ttBtnRefresh.Click += new System.EventHandler(this.ttBtnRefresh_Click);
            // 
            // changesTimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 315);
            this.Controls.Add(this.ttBtnRefresh);
            this.Controls.Add(this.ttBtnDel);
            this.Controls.Add(this.ttBtnUpd);
            this.Controls.Add(this.ttBtnIns);
            this.Controls.Add(this.SBmtb);
            this.Controls.Add(this.PTmtb);
            this.Controls.Add(this.CHTmtb);
            this.Controls.Add(this.SRmtb);
            this.Controls.Add(this.VTmtb);
            this.Controls.Add(this.PNmtb);
            this.Controls.Add(this.weekcb);
            this.Controls.Add(this.audCodecb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(891, 353);
            this.MinimumSize = new System.Drawing.Size(891, 353);
            this.Name = "changesTimetableForm";
            this.Text = "Изменение расписания занятости аудиторий";
            this.Load += new System.EventHandler(this.changesTimetableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рАСПИСАНИЕBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аУДИТОРИЯBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource рАСПИСАНИЕBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАудиторииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn неделяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn занятияВПНDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn занятияВВТDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn занятияВСРDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn занятияВЧТDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn занятияВПТDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn занятияВСБDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox audCodecb;
        private System.Windows.Forms.BindingSource аУДИТОРИЯBindingSource;
        private System.Windows.Forms.ComboBox weekcb;
        private System.Windows.Forms.MaskedTextBox PNmtb;
        private System.Windows.Forms.MaskedTextBox VTmtb;
        private System.Windows.Forms.MaskedTextBox SRmtb;
        private System.Windows.Forms.MaskedTextBox CHTmtb;
        private System.Windows.Forms.MaskedTextBox PTmtb;
        private System.Windows.Forms.MaskedTextBox SBmtb;
        private System.Windows.Forms.Button ttBtnIns;
        private System.Windows.Forms.Button ttBtnUpd;
        private System.Windows.Forms.Button ttBtnDel;
        private System.Windows.Forms.Button ttBtnRefresh;
    }
}