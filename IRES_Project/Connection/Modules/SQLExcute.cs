using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Connection.Modules
{
    public class SQLExcute
    {
        private static SQLExcute _Instance;
        public static SQLExcute Instance
        {
            get
            {
                if (_Instance == null) _Instance = new SQLExcute();
                return _Instance;
            }
        }
        public DataTable GetExcuteQuery(string query)
        {
            // Read command
            NpgsqlCommand cmd = new NpgsqlCommand(query, SQLConnection.Instance.Connection);
            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(dr);
            dr.Close();
            return dt;
        }
        public Boolean UpdateExcuteQuery(string query)
        {
            try { 
                // Read command
                NpgsqlCommand cmd = new NpgsqlCommand(query, SQLConnection.Instance.Connection);
                // Execute a query
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Close();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

    }
}
