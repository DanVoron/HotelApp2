using HotelApp2.Classes;
using HotelApp2.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using HotelApp2.Formsi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelApp2.User_Control
{
    public partial class UserControlClients : UserControl
    {
        Connect conn = new Connect();
        private string ID = "";
        string username;

        public UserControlClients()
        {
            InitializeComponent();

        }
        private void Clear()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNumb.Clear();
            textBoxAdress.Clear();


        }
        private void Clear1()
        {
            textBoxFirstName1.Clear();
            textBoxLastName1.Clear();
            textBoxPhone1.Clear();
            textBoxAdress1.Clear();
            ID = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            string[] wordsToCheck = { "/", "--", "'", "~", "!", "#", "$", "%", "^", "&", "*", "(", ")", "+", "`", ";", ":", "<", ">", "\\", "|" }; // Массив запрещённых слов/символов от sql иньекций
            if (wordsToCheck.Any(word => textBoxFirstName.Text.Contains(word)) || wordsToCheck.Any(word => textBoxFirstName.Text.Contains(word)))
            {
                MessageBox.Show("Введенны недопустимые символы");
                return;
            }
            if (textBoxFirstName.Text.Length > 0) // проверяем введён ли логин     
            {
                if (textBoxLastName.Text.Length > 0)
                {
                    if (textBoxPhoneNumb.Text.Length > 0)
                    {
                        if (textBoxAdress.Text.Length > 0)
                        {
                            if (checkBox1.Checked)
                            {
                                try
                                {
                                    if (conn.insertClients1(textBoxFirstName.Text, textBoxLastName.Text, textBoxPhoneNumb.Text, textBoxAdress.Text))
                                        MessageBox.Show("Клиент добавлен успешно");
                                    Clear();
                                }
                                catch
                                {
                                    MessageBox.Show("Ошбика");
                                }
                            }
                            else MessageBox.Show("Потдвердите согласие на обработку личных данных");
                        }
                        else MessageBox.Show("Введите паспорт");
                    }
                    else MessageBox.Show("Введите телефон");
                }
                else MessageBox.Show("Введите фамилию"); // выводим ошибку    
            }
            else MessageBox.Show("Введите имя"); // выводим ошибку 
        }

        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            dataGridViewClient.DataSource = conn.getClients();
            dataGridViewClient.Sort(dataGridViewClient.Columns[5], ListSortDirection.Ascending);
            
        }

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            textBoxSearchPhone.Clear();
        }

        private void textBoxSearchPhone_TextChanged(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            dataGridViewClient.DataSource = conn.SearchClients(textBoxSearchPhone.Text);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Connect conn = new Connect();
                if (conn.EditClient(textBoxFirstName1.Text, textBoxLastName1.Text, textBoxPhone1.Text, textBoxAdress1.Text))
                {
                    MessageBox.Show("Успешно изменён");
                    Clear1();
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.DellClient(textBoxPhone1.Text))
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

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxFirstName1.Text = row.Cells[1].Value.ToString();
                textBoxLastName1.Text = row.Cells[2].Value.ToString();
                textBoxPhone1.Text = row.Cells[3].Value.ToString();
                textBoxAdress1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dataGridViewClient_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            
            string proverk = conn.ProverkaRoli(username);

            if (proverk == "Админ")
            {
                dataGridViewClient.Columns["Паспорт"].Visible = true;

            }
            
            foreach (DataGridViewRow row in dataGridViewClient.Rows)
            {
                if (row.Cells[5].Value.ToString() == "Нет       ")
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.DarkGray;

                    }
                //if (row.Cells[5].Value.ToString() == "Да        ")
                //    foreach (DataGridViewCell cell in row.Cells)
                //    {
                //        dataGridViewClient.Rows[row.Index].Cells[5].Style.BackColor = Color.Green;
                //        //cell.Style.BackColor = Color.White;
                //    }
            }
        }

    }
}
