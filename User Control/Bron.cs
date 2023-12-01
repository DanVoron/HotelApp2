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
            comboBoxRoomNu.SelectedIndex = -1;
            comboBoxType.SelectedIndex = -1;
            comboBoxClientID.SelectedIndex = -1;
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
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
                if (comboBoxRoomNu.SelectedIndex != -1) // проверяем введён ли пароль         
                {             // ищем в базе данных пользователя с такими данными        //comboBoxClientID  
                    if (comboBoxClientID.SelectedIndex != -1)
                    {

                        if (conn.insertBron(comboBoxType.SelectedItem.ToString(), comboBoxRoomNu.SelectedValue.ToString(), comboBoxClientID.SelectedValue.ToString(), dateTimePickerIn.Text, dateTimePickerOut.Text))
                            conn.UpdateNomer(comboBoxRoomNu.SelectedValue.ToString());
                                MessageBox.Show("Бронь добавлена успешно");
                                Clear();
                            //}
                            //catch
                            //{
                            
                            //MessageBox.Show(e.ToString());
                            //}      
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
                if (comboBoxClientID1.SelectedIndex != -1) // проверяем введён ли пароль         
                {             // ищем в базе данных пользователя с такими данными         
                    if (comboBoxRoomNu1.SelectedIndex != -1)
                    {
                        try
                        {
                            if (conn.EditBron(comboBoxType1.SelectedItem.ToString(), comboBoxRoomNu1.SelectedIndex.ToString(), comboBoxClientID1.SelectedIndex.ToString(), dateTimePickerIn1.Text, dateTimePickerOut1.Text))
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
                if (conn.DellBron(comboBoxClientID1.SelectedItem.ToString()))
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
                comboBoxRoomNu1.Text = row.Cells[2].Value.ToString();
                comboBoxClientID1.Text = row.Cells[3].Value.ToString();
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

        private void tabPageAddReservation_Enter(object sender, EventArgs e)
        {
            comboBoxRoomNu.DisplayMember = "nomer";
            comboBoxRoomNu.ValueMember = "nomer";
            comboBoxRoomNu.DataSource = conn.SearchRoomsInBron();

            comboBoxClientID.DisplayMember = "ID";
            comboBoxClientID.ValueMember = "ID";
            comboBoxClientID.DataSource = conn.SearchClientsIDInBron();

        }

        private void tabPageUpdateReservation_Enter(object sender, EventArgs e)
        {
            comboBoxRoomNu1.DisplayMember = "nomer";
            comboBoxRoomNu1.ValueMember = "nomer";
            comboBoxRoomNu1.DataSource = conn.SearchRoomsInBron1();

            comboBoxClientID1.DisplayMember = "ID";
            comboBoxClientID1.ValueMember = "ID";
            comboBoxClientID1.DataSource = conn.SearchClientsIDInBron1();
        }

        public void Clear1()
        {
            comboBoxRoomNu1.SelectedIndex = -1;
            comboBoxType1.SelectedIndex = -1;
            comboBoxClientID1.SelectedIndex = -1;
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = "";
        }
    }
}
