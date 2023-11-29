using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelApp2.Classes;
using System.Data.SqlClient;

namespace HotelApp2.User_Control
{
    public partial class UserControlSetting : UserControl
    {
        Connect conn = new Connect();
        private string ID = "";
        public UserControlSetting()
        {
            InitializeComponent();
            
        }
        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }
        private void Clear1()
        {
            textBoxUsername1.Clear();
            textBoxPassword1.Clear();
            ID = "";
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            dataGridViewUser.DataSource= conn.getUsers();
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
        }

        private void tabPageUpdateAndDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect();
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
                    try
                    {
                       if(conn.insertClients(textBoxUsername.Text, textBoxPassword.Text, comboBoxRoles.SelectedItem.ToString()))
                        MessageBox.Show("Пользлватель добавлен успешно");
                        Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Ошбика");
                    }
                }
                else MessageBox.Show("Введите пароль"); // выводим ошибку    
            }
            else MessageBox.Show("Введите логин"); // выводим ошибку 
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.EditUser(textBoxUsername1.Text,textBoxPassword1.Text, comboBoxRoles1.SelectedItem.ToString()))
                {
                    MessageBox.Show("Успешно изменён");
                }
                else
                {
                    MessageBox.Show("Ошбика");
                }
            }
            catch
            {
                MessageBox.Show("Ошбика");
            }
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxUsername1.Text = row.Cells[1].Value.ToString();
                textBoxPassword1.Text = row.Cells[2].Value.ToString();
                comboBoxRoles1.Text = row.Cells[3].Value.ToString();
            }
        }

        private void textBoxSearchUsername_TextChanged(object sender, EventArgs e)
        {
            
            dataGridViewUser.DataSource = conn.SearchUsers(textBoxSearchUsername.Text);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.DellUsers(textBoxUsername1.Text))
                {
                    MessageBox.Show("Успешно удалено");
                }
                else
                {
                    MessageBox.Show("Ошбика");
                }
            }
            catch 
            {
                MessageBox.Show("Ошбика2");
            }
        }
    }
}
