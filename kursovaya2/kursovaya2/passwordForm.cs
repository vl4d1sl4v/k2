using System;
using System.Windows.Forms;

namespace kursovaya2
{
    public partial class passwordForm : Form
    {

        string password = "1234";

        public passwordForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == password)
            {
                this.Hide();
                changesForm cf = new changesForm();
                cf.ShowDialog();
      
            }
            else
            {
                DialogResult result = MessageBox.Show("Введён неверный пароль.", "Неверный пароль", MessageBoxButtons.OK);
            }
        }
    }
}
