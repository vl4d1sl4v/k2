namespace kursovaya2
{
    partial class changesForm
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
            this.changeAuditoriumsButton = new System.Windows.Forms.Button();
            this.changeTimetableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeAuditoriumsButton
            // 
            this.changeAuditoriumsButton.Location = new System.Drawing.Point(83, 23);
            this.changeAuditoriumsButton.Name = "changeAuditoriumsButton";
            this.changeAuditoriumsButton.Size = new System.Drawing.Size(84, 23);
            this.changeAuditoriumsButton.TabIndex = 0;
            this.changeAuditoriumsButton.Text = "Аудитории";
            this.changeAuditoriumsButton.UseVisualStyleBackColor = true;
            this.changeAuditoriumsButton.Click += new System.EventHandler(this.changeAuditoriumsButton_Click);
            // 
            // changeTimetableButton
            // 
            this.changeTimetableButton.Location = new System.Drawing.Point(83, 52);
            this.changeTimetableButton.Name = "changeTimetableButton";
            this.changeTimetableButton.Size = new System.Drawing.Size(84, 23);
            this.changeTimetableButton.TabIndex = 2;
            this.changeTimetableButton.Text = "Расписание";
            this.changeTimetableButton.UseVisualStyleBackColor = true;
            this.changeTimetableButton.Click += new System.EventHandler(this.changeTimetableButton_Click);
            // 
            // changesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 104);
            this.Controls.Add(this.changeTimetableButton);
            this.Controls.Add(this.changeAuditoriumsButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(262, 142);
            this.MinimumSize = new System.Drawing.Size(262, 142);
            this.Name = "changesForm";
            this.Text = "Внесение изменений";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeAuditoriumsButton;
        private System.Windows.Forms.Button changeTimetableButton;
    }
}