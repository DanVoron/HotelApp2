using HotelApp2.Classes;
using HotelApp2.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp2.Formsi
{
    public partial class FromDashboard : Form
    {
        Connect conn = new Connect();
        public string username;
        public FromDashboard()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top= btn.Top;
            panelSlide.Height=btn.Height;   
        }

        private void linkLabel1LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?","Выйти", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void FromDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = username;
        }

        private void buttonDashBoard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashBoard);
            userControlSetting1.Hide();
            userControlClients1.Hide();
            userControlRoom1.Hide();
            bron1.Hide();
            userControlDashBoard1.Show();
            userControlDashBoard1.UserCount();
            userControlDashBoard1.ClientsCount();
            userControlDashBoard1.RoomsCount();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            bron1.Hide();
            userControlSetting1.Hide();
            userControlRoom1.Hide();
            userControlDashBoard1.Hide();
            userControlClients1.Show();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            string proverk = conn.ProverkaRoli(username);
            if (proverk == "Админ"|| proverk == "Менеджер")
            {
                MovePanel(buttonRoom);
                userControlSetting1.Hide();
                userControlClients1.Hide();
                bron1.Hide();
                userControlDashBoard1.Hide();
                userControlRoom1.Show();
            }
            else
            {
                MessageBox.Show("Недостаточно прав");
            }

        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            userControlSetting1.Hide();
            userControlClients1.Hide();
            userControlRoom1.Hide();
            userControlDashBoard1.Hide();
            bron1.Show();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            string proverk = conn.ProverkaRoli(username);
            if (proverk == "Админ")
            {
                MovePanel(buttonSetting);
                userControlClients1.Hide();
                userControlRoom1.Hide();
                bron1.Hide();
                userControlDashBoard1.Hide();
                userControlSetting1.Clear();
                userControlSetting1.Show();
            }
            else
            {
                MessageBox.Show("Недостаточно прав");
            }
            
        }
    }
}
