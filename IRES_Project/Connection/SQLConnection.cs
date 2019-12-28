using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using IRES_Globals.GlobalClass;
using System.Data;

namespace Connection
{
    public class SQLConnection
    {
        public NpgsqlConnection Connection = null;

        private static SQLConnection _Instance;

        public static SQLConnection Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SQLConnection();
                    _Instance.ConnectDB();
                    _Instance.OpenfConnection();
                }
                return _Instance;
            }
            set
            {
                _Instance = value;
            }
        }

        public SQLConnection()
        {
        }
        public void ConnectDB()
        {
            Connection = new NpgsqlConnection(
                "Server=" + ConnectionInfo.SERVER + ";" +
                "Port=" + ConnectionInfo.PORT + ";" +
                "User Id=" + ConnectionInfo.USER + ";" +
                "Password=" + ConnectionInfo.PASSWORD + ";" +
                "Database=" + ConnectionInfo.DATABASE + ";"
            );
        }

        public void OpenfConnection()
        {
            try
            {
                Connection.Open();
            }
            catch (NpgsqlException ex)
            {
                ShowError(ex);
            }
        }

        private void CloseConnection()
        {
            try
            {
                Connection.Close();
            }
            catch (NpgsqlException ex)
            {
                ShowError(ex);
            }
        }

        private void ShowError(NpgsqlException ex)
        {
            // MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
        }

        public Boolean RunCommand(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);

            // Execute the query and obtain the value of the first column of the first row
            if (cmd.ExecuteScalar() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
