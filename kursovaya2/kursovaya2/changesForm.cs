using System;
using System.Windows.Forms;

namespace kursovaya2
{
    public partial class changesForm : Form
    {
        public changesForm()
        {
            InitializeComponent();
        }

        private void changeAuditoriumsButton_Click(object sender, EventArgs e)
        {
            changesAuditoriumsForm caf = new changesAuditoriumsForm();
            caf.ShowDialog();
        }

        private void changeTimetableButton_Click(object sender, EventArgs e)
        {
            changesTimetableForm ctf = new changesTimetableForm();
            ctf.ShowDialog();
        }

    }
}
