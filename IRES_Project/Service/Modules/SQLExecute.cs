using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Service.Modules
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
            try
            {
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

        public bool InsertExecuteQuery(string query) 
        { 
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, SQLConnection.Instance.Connection);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(NpgsqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        
        }

    }
}
