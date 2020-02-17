using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace kursovaya2
{
   public partial class searchForm : Form
    {
        string connectionString = Properties.Settings.Default.Database1ConnectionString;

        string sqlText;


        int odf = 0; // флаг на то, что выбран день
        int wrb = 0;// флаг для записи в него номера занятия

        public searchForm()
        {
            InitializeComponent();
        }

        //кнопка найти
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (daycb.Text.Length > 0) //если выбран день недели
            {
                sqlText = String.Format("SELECT [Расписание].[Код аудитории], [Неделя], [Занятия в {0}], " +
                    "[Аудитория].[Вместимость], [Аудитория].[Тип] FROM [РАСПИСАНИЕ] INNER JOIN [АУДИТОРИЯ] " +
                    "ON [РАСПИСАНИЕ].[Код аудитории] = [АУДИТОРИЯ].[Код аудитории] " +
                    "WHERE [АУДИТОРИЯ].[Состояние] = 'Используется' ", daycb.Text);

                odf = 1;
            }
            else //если день недели не выбран
            {
                sqlText = String.Format("SELECT [РАСПИСАНИЕ].*, [Аудитория].[Вместимость], [Аудитория].[Тип] FROM [РАСПИСАНИЕ]" +
                    " INNER JOIN [АУДИТОРИЯ] ON [РАСПИСАНИЕ].[Код аудитории] = [АУДИТОРИЯ].[Код аудитории]" +
                    " WHERE [АУДИТОРИЯ].[Состояние] = 'Используется' ");
            }
            
            // проверка на то, что нажата радиокнопка
            if (rb1.Checked | rb2.Checked | rb3.Checked | rb4.Checked | rb5.Checked | rb6.Checked | rb7.Checked)
            {
                if (rb1.Checked) { wrb = 1; }
                if (rb2.Checked) { wrb = 2; }
                if (rb3.Checked) { wrb = 3; }
                if (rb4.Checked) { wrb = 4; }
                if (rb5.Checked) { wrb = 5; }
                if (rb6.Checked) { wrb = 6; }
                if (rb7.Checked) { wrb = 7; }

                if (odf == 1)//и выбран день недели
                {
                    sqlText = sqlText + String.Format(" AND [Занятия в {0}] NOT LIKE '%{1}%' ", daycb.Text, wrb);
                }
                else//если день недели не выбран
                {
                    sqlText = sqlText + String.Format(" AND ( [Занятия в ПН] NOT LIKE '%{0}%' OR [Занятия в ВТ] NOT LIKE '%{1}%' " +
                        "OR [Занятия в СР] NOT LIKE '%{2}%' OR [Занятия в ЧТ] NOT LIKE '%{3}%' OR [Занятия в ПТ] NOT LIKE '%{4}%' " +
                        "OR [Занятия в ПН] NOT LIKE '%{5}%')", wrb, wrb, wrb, wrb, wrb, wrb);
                }
            }

            try//подключение к бд и отправка запроса
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlText, connection);
                    BindingSource bs = new BindingSource();
                    DataTable dt = new DataTable();

                    connection.Open();

                    oleDbDataAdapter.Fill(dt);
                    bs.DataSource = dt;
                    dataGridView1.DataSource = dt;

                    connection.Close();
                }

            }
            catch (OleDbException ex) { MessageBox.Show("Ошибка SQL [].\r\n" + ex.Message); }
        }

    }
}
