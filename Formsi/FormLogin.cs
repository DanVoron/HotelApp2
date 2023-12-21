using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelApp2.Classes;
using HotelApp2.Formsi;
using HotelApp2.User_Control;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelApp2
{
    public partial class FormLogin : Form
    {
        Connect db = new Connect();
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Свернуть");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Закрыть");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Скрыть пароль");
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Показать пароль");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }
        public DataTable Select(string selectSQL) //метод для подключения БД
        {
            DataTable dataTable = new DataTable("dataBase"); //новую таблу создаём
            SqlConnection sqlConnection = new SqlConnection("Data Source=HOME-PC\\GGEZ;Initial Catalog=ConceptHotel;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sqlCommand); //обработчик комманды
            SqlDataAdapter.Fill(dataTable); //получаем таблицу с результатами
            return dataTable;
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string[] wordsToCheck = { "/", "--", "'", "~", "!", "#", "$", "%", "^", "&", "*", "(", ")", "+", "`", ";", ":", "<", ">", "\\", "|" }; // Массив запрещённых слов/символов от sql иньекций
            if (wordsToCheck.Any(word => textBoxUsername.Text.Contains(word)) || wordsToCheck.Any(word => textBoxPassword.Text.Contains(word)))
            {
                MessageBox.Show("Введенны недопустимые символы");
                return;
            }
            if (textBoxUsername.Text.Length > 0) // проверяем введён ли логин     
            {
                if (textBoxPassword.Text.Length > 0) // проверяем введён ли пароль         
                {             // ищем в базе данных пользователя с такими данными         
                    DataTable dt_user = Select($"SELECT * FROM [dbo].[Users] WHERE [Login] = '{textBoxUsername.Text}' AND [Password] = '{textBoxUsername.Text}'");
                    if (dt_user.Rows.Count > 0) // если такая запись существует       
                    {
                        FromDashboard fd = new FromDashboard();
                        fd.username = textBoxUsername.Text;
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                        fd.Show();

                    }
                    else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
                }
                else MessageBox.Show("Введите пароль"); // выводим ошибку    
            }
            else MessageBox.Show("Введите логин"); // выводим ошибку 

        }
    }
}
