using HotelApp2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp2.User_Control
{
    public partial class Bron : UserControl
    {
        Connect conn = new Connect();
        private string RID = "",NO;
        public Bron()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            textBoxRoomNo.Clear();
            comboBoxType.SelectedIndex = -1;
            textBoxClientID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlReservation.SelectedTab = tabPageAddReservation;
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (comboBoxType.SelectedIndex != -1) // проверяем введён ли логин     
            {
                if (textBoxRoomNo.Text.Length>0) // проверяем введён ли пароль         
                {             // ищем в базе данных пользователя с такими данными         
                    if (textBoxClientID.Text.Length > 0)
                    {
                            try
                            {
                                if (conn.insertBron(comboBoxType.SelectedItem.ToString(), textBoxRoomNo.Text, textBoxClientID.Text,dateTimePickerIn.Text,dateTimePickerOut.Text))
                                    MessageBox.Show("Бронь добавлена успешно");
                                Clear();
                            }
                            catch
                            {
                                MessageBox.Show("Ошбика");
                            }      
                    }
                    else MessageBox.Show("Введите айди клиента");
                }
                else MessageBox.Show("Введите номер комнаты"); // выводим ошибку    
            }
            else MessageBox.Show("Выберите тип"); // выводим ошибку 
        }

        private void tabPageSearchReservation_Enter(object sender, EventArgs e)
        {
            dataGridViewReservation.DataSource = conn.getBron();
            dataGridViewReservation.Sort(dataGridViewReservation.Columns[6], ListSortDirection.Ascending);
        }

        private void textBoxSearchClientId_TextChanged(object sender, EventArgs e)
        {
            dataGridViewReservation.DataSource = conn.SearchBron(textBoxSearchClientId.Text);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType1.SelectedIndex != -1) // проверяем введён ли логин     
            {
                if (textBoxRoomNo1.Text.Length>0) // проверяем введён ли пароль         
                {             // ищем в базе данных пользователя с такими данными         
                    if (textBoxClientID1.Text.Length > 0)
                    {
                        try
                        {
                            if (conn.EditBron(comboBoxType1.SelectedItem.ToString(), textBoxRoomNo1.Text, textBoxClientID1.Text, dateTimePickerIn1.Text, dateTimePickerOut1.Text))
                                MessageBox.Show("Бронь изменена успешно");
                            Clear();
                        }
                        catch
                        {
                            MessageBox.Show("Ошбика");
                        }
                    }
                    else MessageBox.Show("Введите айди клиента");
                }
                else MessageBox.Show("Введите номер комнаты"); // выводим ошибку    
            }
            else MessageBox.Show("Выберите тип"); // выводим ошибку 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.DellBron(textBoxRoomNo1.Text))
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

        private void tabPageSearchReservation_Leave(object sender, EventArgs e)
        {
            textBoxSearchClientId.Clear();
        }

        private void tabPageUpdateReservation_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
                comboBoxType1.Text = row.Cells[1].Value.ToString();
                textBoxRoomNo1.Text = row.Cells[2].Value.ToString();
                textBoxClientID1.Text = row.Cells[3].Value.ToString();
                dateTimePickerIn1.Text = row.Cells[4].Value.ToString();
                dateTimePickerOut1.Text = row.Cells[5].Value.ToString();

            }
        }

        private void dataGridViewReservation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewReservation.Rows)
            {
                if (row.Cells[6].Value.ToString() == "Нет       ")
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.DarkGray;

                    }
            }
            
        }
        public void Clear1()
        {
            textBoxRoomNo1.Clear();
            comboBoxType1.SelectedIndex = -1;
            textBoxClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = "";
        }
    }
}
