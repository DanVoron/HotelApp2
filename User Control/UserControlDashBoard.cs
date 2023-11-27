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
    public partial class UserControlDashBoard : UserControl
    {
        Connect conn = new Connect();
        public UserControlDashBoard()
        {
            InitializeComponent();
        }

        public void UserCount()
        {
            string UsersCount = conn.Count("select count(*) from Users");
            LabelUSers.Text = UsersCount;
        }

        public void ClientsCount()
        {
            string clients = conn.Count("select count(*) from Clients");
            labelClients.Text = clients;
        }

        public void RoomsCount()
        {
            string rooms = conn.Count("select count(*) from nomera");
            labelRooms.Text = rooms;
        }

        private void UserControlDashBoard_Load(object sender, EventArgs e)
        {
            UserCount();
            ClientsCount();
            RoomsCount();
        }

        private void UserControlDashBoard_Enter(object sender, EventArgs e)
        {

        }
    }
}
