﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Drawing;
using HotelApp2.DB;

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
        
     
        public bool insertClients(string name, string lastname, string roles)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            string insertQuery = $"insert into Users (Login,Password,Roles) values  ('{name}','{lastname}','{roles}')";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

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
                command.CommandText = $"delete from users where login = '{a}'";
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
        public bool EditUser(string Login, string Password, string roles)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE Users SET Password = '{Password}' , Roles = '{roles}' WHERE Login = '{Login}'";
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
        public bool insertClients1(string name, string lastname, string phone, string Passport)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            string insertQuery = "insert into Clients(Name,Surname,Phone,Passport,Active) values  (@n,@s,@p,@a,'Да')";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@n", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@s", SqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("@p", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@a", SqlDbType.VarChar).Value = Passport;

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
        public bool EditClient(string Name, string Lastname, string phone, string Passport)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE Clients SET Name = '{Name}',Surname='{Lastname}',Phone='{phone}',Passport='{Passport}' WHERE Phone = '{phone}'";
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
            command.CommandText = $"UPDATE Clients SET Active = 'Нет' WHERE Phone = '{a}'";
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
        //СТАРЫЙ МЕТОД
        //public bool DellClient(string a)
        //{
        //    Connect conn = new Connect();
        //    SqlCommand command = new SqlCommand();
        //    command.CommandText = $"delete from clients where Phone = '{a}'";
        //    command.Connection = conn.GetConnection();

        //    conn.openConnection();

        //    if (command.ExecuteNonQuery() == 1)
        //    {
        //        conn.closeConnection();
        //        return true;
        //    }
        //    else
        //    {
        //        conn.openConnection();
        //        return false;
        //    }

        //}

        //ROOMS
        public bool insertRooms(string nomer, string type, string phone, string free)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            string insertQuery = "insert into Nomera (Nomer,Type,Phone,free,active) values  (@n,@t,@p,@f,'Да')";
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
            command.CommandText = $"UPDATE Nomera SET Active = 'Нет' WHERE Nomer  = '{a}'";
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
        public bool insertBron( string RoomNo, string ClientID, string datetimein, string datetimeout)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            string insertQuery = $"insert into bron (Room_Number,Client_ID, Bron_IN,Bron_Out,active) Values ('{RoomNo}','{ClientID}','{datetimein}','{datetimeout}','Да')";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();
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
        public DataTable UpdateNomer(string RoomNo)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand($"update nomera set free ='нет' where Nomer = '{RoomNo}'", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

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
        public bool EditBron(string RoomNo, string ClientID, string datetimein, string datetimeout)
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            string gg = $"UPDATE Bron SET  Room_Number = '{RoomNo}',Client_ID='{ClientID}',Bron_IN='{datetimein}',Bron_Out='{datetimeout}' WHERE Room_Number = '{RoomNo}'";
            command.CommandText = gg;
               
            command.Connection = conn.GetConnection();
            
            conn.openConnection();
        

            if (command.ExecuteNonQuery() > 0)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.openConnection();
                MessageBox.Show($"{RoomNo},{ClientID},{datetimein},{datetimeout}");
                return false;
            }
        }
        public bool DellBron(string RoomNo)
        {
           
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            SqlCommand command2 = new SqlCommand();
            command.CommandText = $"UPDATE Bron SET Active = 'Нет' WHERE Room_Number = '{RoomNo}'";
            command2.CommandText = $"UPDATE Nomera SET Free = 'Да' WHERE Nomer = '{RoomNo}'";
            command.Connection = conn.GetConnection();
            command2.Connection = conn.GetConnection();

            conn.openConnection();

            if (command.ExecuteNonQuery() > 0 && command2.ExecuteNonQuery() > 0)
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
        public DataTable SearchRoomsInBron()
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand($"Select * from Nomera nomer where free = 'Да'", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

        }
        public DataTable SearchClientsIDInBron()
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand($"Select ID from Clients  where Active = 'Да'", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

        }
        public DataTable SearchRoomsInBron1()
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand($"Select * from Nomera nomer where free = 'Нет' AND active = 'Да'", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

        }
        public DataTable SearchClientsIDInBron1()
        {
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand($"Select * from Clients  where Active = 'Да'", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            return dataTable;

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


        public string ProverkaRoli(string a)
        {
            string name;
            SqlDataReader _reader;
            Connect conn = new Connect();
            SqlCommand command = new SqlCommand();
            command.CommandText = $"SELECT Roles FROM[dbo].[Users] WHERE[Login] = '{a}'";
            command.Connection = conn.GetConnection();

            conn.openConnection();
            _reader = command.ExecuteReader();
            if (_reader != null)
            {
                while (_reader.Read())
                {
                    name = _reader[0] as string;
                    //break for single row or you can continue if you have multiple rows...
                    return name;

                }
            }
            return "ошибка роли";
        }
      

        
    }

}
