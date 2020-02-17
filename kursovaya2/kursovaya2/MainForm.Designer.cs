namespace kursovaya2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpButton = new System.Windows.Forms.Button();
            this.makeChangesButton = new System.Windows.Forms.Button();
            this.auditoriumsButton = new System.Windows.Forms.Button();
            this.timetableButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(58, 31);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(167, 23);
            this.helpButton.TabIndex = 14;
            this.helpButton.Text = "Справка";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // makeChangesButton
            // 
            this.makeChangesButton.Location = new System.Drawing.Point(58, 60);
            this.makeChangesButton.Name = "makeChangesButton";
            this.makeChangesButton.Size = new System.Drawing.Size(167, 23);
            this.makeChangesButton.TabIndex = 15;
            this.makeChangesButton.Text = "Внести изменения";
            this.makeChangesButton.UseVisualStyleBackColor = true;
            this.makeChangesButton.Click += new System.EventHandler(this.makeChangesButton_Click);
            // 
            // auditoriumsButton
            // 
            this.auditoriumsButton.Location = new System.Drawing.Point(58, 89);
            this.auditoriumsButton.Name = "auditoriumsButton";
            this.auditoriumsButton.Size = new System.Drawing.Size(167, 23);
            this.auditoriumsButton.TabIndex = 16;
            this.auditoriumsButton.Text = "Аудитории";
            this.auditoriumsButton.UseVisualStyleBackColor = true;
            this.auditoriumsButton.Click += new System.EventHandler(this.auditoriumsButton_Click);
            // 
            // timetableButton
            // 
            this.timetableButton.Location = new System.Drawing.Point(58, 118);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(167, 23);
            this.timetableButton.TabIndex = 17;
            this.timetableButton.Text = "Расписание";
            this.timetableButton.UseVisualStyleBackColor = true;
            this.timetableButton.Click += new System.EventHandler(this.timetableButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(58, 147);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(167, 23);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Поиск свободной аудитории";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(276, 206);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.timetableButton);
            this.Controls.Add(this.auditoriumsButton);
            this.Controls.Add(this.makeChangesButton);
            this.Controls.Add(this.helpButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(292, 244);
            this.MinimumSize = new System.Drawing.Size(292, 244);
            this.Name = "MainForm";
            this.Text = "Учёт занятости аудиторий";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button makeChangesButton;
        private System.Windows.Forms.Button auditoriumsButton;
        private System.Windows.Forms.Button timetableButton;
        private System.Windows.Forms.Button searchButton;
    }
}

