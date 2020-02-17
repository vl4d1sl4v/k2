using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace kursovaya2
{
    public partial class changesTimetableForm : Form
    {

        public changesTimetableForm()
        {
            InitializeComponent();
        }


        private void changesTimetableForm_Load(object sender, EventArgs e)
        {
            ttBtnRefresh_Click(sender, e);
        }

        //Обновить
        private void ttBtnRefresh_Click(object sender, EventArgs e)
        {
    
        }

        //Передвижение по гриду и заполнение полей
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception /*ex*/) { /*MessageBox.Show("Ошибка.\r\n" + ex.Message);*/ }
        }

        //Изменение состояния кнопок в зависимости от изменения информации в полях
        private void audCodecb_TextChanged(object sender, EventArgs e)
        {

        }

        //Кнопка Вставить
        private void ttBtnIns_Click(object sender, EventArgs e)
        {
            
        }

        //Кнопка Изменить
        private void ttBtnUpd_Click(object sender, EventArgs e)
        {
            
        }

        //Кнопка Удалить
        private void ttBtnDel_Click(object sender, EventArgs e)
        {
           
        }
    }
}
