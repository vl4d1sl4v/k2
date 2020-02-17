using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace kursovaya2
{
    public partial class changesAuditoriumsForm : Form
    {
       
        public changesAuditoriumsForm()
        {
            InitializeComponent();
        }

        private void changesAuditoriumsForm_Load(object sender, EventArgs e)
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
        private void buildingNumcb_TextChanged(object sender, EventArgs e)
        {
           
        }

        //Кнопка Обновить
        private void audBtnRefresh_Click(object sender, EventArgs e)
        {
          
        }

        //Кнопка Вставить
        private void audBtnInsert_Click(object sender, EventArgs e)
        {
            
        }

        //Кнопка Изменить
        private void audBtnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        //Кнопка Удалить
        private void audBtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
