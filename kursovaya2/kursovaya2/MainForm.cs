using System;
using System.Windows.Forms;

namespace kursovaya2
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Справка
        private void helpButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Справка", "Справка", MessageBoxButtons.OK);
        }

        //Внести изменения
        private void makeChangesButton_Click(object sender, EventArgs e)
        {
            passwordForm pf = new passwordForm();
            pf.ShowDialog();
        }

        //Аудитории
        private void auditoriumsButton_Click(object sender, EventArgs e)
        {
            watchAuditoriumsForm af = new watchAuditoriumsForm();
            af.ShowDialog();
        }

        //Расписание
        private void timetableButton_Click(object sender, EventArgs e)
        {
            watchTimetableForm tf = new watchTimetableForm();
            tf.ShowDialog();
        }

        //Поиск аудитории
        private void searchButton_Click(object sender, EventArgs e)
        {            
            searchForm sf = new searchForm();
            sf.ShowDialog();           
        }
    }
}
