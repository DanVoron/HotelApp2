using HotelApp2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp2.User_Control
{
    public partial class UserControlRoom : UserControl
    {
        Connect conn = new Connect();
        private string No = "", Free = "";
        public UserControlRoom()
        {
            InitializeComponent();

        }
        public void Clear()
        {
            comboBoxType.SelectedIndex = -1;
            textBoxPhone.Clear();
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
            tabControlRoom.SelectedTab = tabPageAddRoom;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if(radioButtonNo.Checked) { Free = "Нет"; }
            if(radioButtonYes.Checked) { Free = "Да"; }


            if (comboBoxType.SelectedIndex !=-1) // проверяем введён ли логин     
            {
                if (textBoxPhone.Text.Length > 0) // проверяем введён ли пароль         
                {             // ищем в базе данных пользователя с такими данными         
                    if (textBoxRoomNumber.Text.Length > 0)
                    {
                        if (Free != "")
                        {
                            try
                            {
                                if (conn.insertRooms(textBoxRoomNumber.Text, comboBoxType.SelectedItem.ToString(), textBoxPhone.Text, Free))
                                    MessageBox.Show("Комната добавлена успешно");
                                Clear();
                            }
                            catch
                            {
                                MessageBox.Show("Ошбика");
                            }
                        }
                        else  MessageBox.Show("Введите свободна ли комната");
                    }
                    else MessageBox.Show("Введите номер комнаты");
                }
                else MessageBox.Show("Введите телефон"); // выводим ошибку    
            }
            else MessageBox.Show("Выберите тип"); // выводим ошибку 
        }

        private void tabPageSearchRooms_Enter(object sender, EventArgs e)
        {
            
            dataGridViewRoom.DataSource = conn.getRooms();
            dataGridViewRoom.Sort(dataGridViewRoom.Columns[5], ListSortDirection.Ascending);
        }

        private void textBoxSearchRoom_TextChanged(object sender, EventArgs e)
        {
            
            dataGridViewRoom.DataSource = conn.SearchRooms(textBoxSearchRoom.Text);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            

            if (radioButtonNo1.Checked) { Free = "Нет"; }
            if (radioButtonYes1.Checked) { Free = "Да"; }


            if (comboBoxType1.SelectedIndex != -1) // проверяем введён ли логин     
            {
                if (textBoxPhone1.Text.Length > 0) // проверяем введён ли пароль         
                {             // ищем в базе данных пользователя с такими данными         
                    if (textBoxRoomNumber1.Text.Length > 0)
                    {
                        if (Free != "")
                        {
                            try
                            {
                                if (conn.EditRoom(textBoxRoomNumber1.Text, comboBoxType1.SelectedItem.ToString(), textBoxPhone1.Text, Free))
                                    MessageBox.Show("Комната изменена успешно");
                                Clear();
                            }
                            catch
                            {
                                MessageBox.Show("Ошбика");
                            }
                        }
                        else MessageBox.Show("Введите свободна ли комната");
                    }
                    else MessageBox.Show("Введите номер комнаты");
                }
                else MessageBox.Show("Введите телефон"); // выводим ошибку    
            }
            else MessageBox.Show("Выберите тип"); // выводим ошибку 
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.DellRoom(textBoxRoomNumber1.Text))
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

        private void tabPageSearchRooms_Leave(object sender, EventArgs e)
        {
            textBoxSearchRoom.Clear();
        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageUpdate_Leave(object sender, EventArgs e)
        {
            clear1();
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewRoom.Rows[e.RowIndex];
                textBoxRoomNumber1.Text = row.Cells[1].Value.ToString();
                comboBoxType1.Text = row.Cells[2].Value.ToString();
                textBoxPhone1.Text = row.Cells[3].Value.ToString();
                Free = row.Cells[4].Value.ToString();
                if (Free == "Yes") { radioButtonYes1.Checked = true; }
                if (Free == "No") { radioButtonNo1.Checked = true; }
            }
        }

        private void dataGridViewRoom_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewRoom.Rows)
            {
                if (row.Cells[5].Value.ToString() == "Нет       ")
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.DarkGray;

                    }
            }
        }

        public void clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            textBoxPhone1.Clear();
            radioButtonYes1.Checked = false;
            radioButtonNo1.Checked = false;
            No = "";
        }
    }
}
