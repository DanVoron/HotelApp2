using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace HotelApp2.Classes
{
    internal class Connect
    {
        
        private SqlConnection connection = new SqlConnection("Data Source=HOME-PC\\GGEZ;Initial Catalog=ConceptHotel;Integrated Security=True");
        public SqlConnection GetConnection()
        {
            return connection;

        }
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
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
        
     
        public bool insertClients(string name, string lastname)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            string insertQuery = "insert into Users (Login,Password) values  (@n,@s)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@n", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@s", SqlDbType.VarChar).Value = lastname;

            //command.Parameters.Add("", SqlDbType.VarChar).Value=name;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }
        }
        public DataTable getUsers()
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand("Select * from Users", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;
           
        }
        public DataTable SearchUsers(string a)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand($"Select * from Users where login = '{a}'", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

        }
        //$"delete from users where Login = '{a}'";
        public bool DellUsers (string a)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"delete from users where Login = '{a}'";
            command.Connection = conn.GetConnection();

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }

        }
        public bool EditUser(string Login, string Password)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE Users SET Password = '{Password}'WHERE Login = '{Login}'";
            command.Connection = conn.GetConnection();

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }
        }
        public bool insertClients1(string name, string lastname, string phone, string adress)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            string insertQuery = "insert into Clients(Name,Surname,Phone,Adress) values  (@n,@s,@p,@a)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@n", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@s", SqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@p", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@a", SqlDbType.VarChar).Value = adress;

            //command.Parameters.Add("", SqlDbType.VarChar).Value=name;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }
        }
        public DataTable getClients()
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand("Select * from Clients", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

        }
        public DataTable SearchClients(string a)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand($"Select * from Clients where Phone = '{a}'", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

        }
        public bool EditClient(string Name, string Lastname, string phone, string adress)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE Clients SET Name = '{Name}',Surname='{Lastname}',Phone='{phone}',Adress='{adress}' WHERE Phone = '{phone}'";
            command.Connection = conn.GetConnection();

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }
        }
        public bool DellClient(string a)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"delete from clients where Phone = '{a}'";
            command.Connection = conn.GetConnection();

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }

        }

        //ROOMS
        public bool insertRooms(string nomer, string type, string phone, string free)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            string insertQuery = "insert into Nomera (Nomer,Type,Phone,free) values  (@n,@t,@p,@f)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@n", SqlDbType.VarChar).Value = nomer;
            command.Parameters.Add("@t", SqlDbType.VarChar).Value = type;
            command.Parameters.Add("@p", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@f", SqlDbType.VarChar).Value = free;

            //command.Parameters.Add("", SqlDbType.VarChar).Value=name;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }
        }
        public DataTable getRooms()
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand("Select * from Nomera", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

        }
        public DataTable SearchRooms(string a)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand($"Select * from Nomera where Nomer = '{a}'", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

        }
        public bool EditRoom(string nomer, string type, string phone, string free)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE Nomera SET Nomer = '{nomer}',type='{type}',Phone='{phone}',free='{free}' WHERE nomer = '{nomer}'";
            command.Connection = conn.GetConnection();

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }
        }
        public bool DellRoom(string a)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"delete from Nomera where nomer = '{a}'";
            command.Connection = conn.GetConnection();

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }

        }
        //BRON
        public bool insertBron(string type, string RoomNo, string ClientID, string datetimein, string datetimeout)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            string insertQuery = "insert into bron ([Type], Room_Number, Client_ID, Bron_IN,Bron_Out) Values (@t,@r,@c,@i,@o)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();
            
            command.Parameters.Add("@t", SqlDbType.VarChar).Value = type;
            command.Parameters.Add("@r", SqlDbType.VarChar).Value = RoomNo;
            command.Parameters.Add("@c", SqlDbType.VarChar).Value = ClientID;
            command.Parameters.Add("@i", SqlDbType.VarChar).Value = datetimein;
            command.Parameters.Add("@o", SqlDbType.VarChar).Value = datetimeout;

            //command.Parameters.Add("", SqlDbType.VarChar).Value=name;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }
        }
        public DataTable getBron()
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand("Select * from Bron", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

        }
        public DataTable SearchBron(string a)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand($"Select * from Bron where Client_ID = '{a}'", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

        }
        public bool EditBron(string type, string RoomNo, string ClientID, string datetimein, string datetimeout)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE Bron SET type='{type}', Room_Number = '{RoomNo}',Client_ID='{ClientID}',Bron_IN='{datetimein}',Bron_Out='{datetimeout}' WHERE Room_Number = '{RoomNo}'";
            command.Connection = conn.GetConnection();

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }
        }
        public bool DellBron(string a)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"delete from Bron where Room_Number = '{a}'";
            command.Connection = conn.GetConnection();

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                return false;
            }

        }
        //dashboard
        public string Count(string a)
        {
            string gg = "";
            SqlDataReader _reader = null;
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = a;
            command.Connection = conn.GetConnection();

            conn.openConnection();
            _reader = command.ExecuteReader();
            if (_reader.Read())
            {
                gg = _reader.GetInt32(0).ToString(); 
                return gg;
            }
            else
            {
                conn.openConnection();
                return null;
            }
        }
    }

}
