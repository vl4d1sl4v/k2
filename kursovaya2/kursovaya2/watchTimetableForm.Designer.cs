namespace kursovaya2
{
    partial class watchTimetableForm
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рАСПИСАНИЕBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // watchTimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 238);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(866, 276);
            this.MinimumSize = new System.Drawing.Size(866, 276);
            this.Name = "watchTimetableForm";
            this.Text = "Расписание занятости аудиторий";
            this.Load += new System.EventHandler(this.watchTimetableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рАСПИСАНИЕBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}