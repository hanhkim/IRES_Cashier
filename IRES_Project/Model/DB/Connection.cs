using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows;
using System.Windows.Forms;
using System.Data;

namespace Model.DB
{
    public class Connection
    {
        private const String SERVER = "localhost";
        private const String PORT = "5432";
        private const String USER = "postgres";
        private const String PASSWORD = "123456";
        private const String DATABASE = "ires";

        private NpgsqlConnection connection = null;

        private static Connection _Instance;

        public static Connection Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Connection();
                    _Instance.connectDB();
                    _Instance.openfConnection();
                }
                return _Instance;
            }
            set
            {
                _Instance = value;
            }
        }

        public Connection()
        {
        }
        public void connectDB()
        {
            connection = new NpgsqlConnection(
                "Server=" + SERVER + ";" +
                "Port=" + PORT + ";" +
                "User Id=" + USER + ";" +
                "Password=" + PASSWORD + ";" +
                "Database=" + DATABASE + ";"
            );
        }

        public void openfConnection()
        {
            try
            {
                connection.Open();
            }
            catch (NpgsqlException ex)
            {
                showError(ex);
            }
        }

        private void closeConnection()
        {
            try
            {
                connection.Close();
            }
            catch (NpgsqlException ex)
            {
                showError(ex);
            }
        }

        private void showError(NpgsqlException ex)
        {
           // MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
        }

        public Boolean runCommand(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

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

        public DataTable getRecordsCommand(string query)
        {
            // Read command
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Columns.Add("table_id", typeof(Int32));
            dt.Columns.Add("table_code", typeof(string));
            dt.Columns.Add("table_position", typeof(string));
            dt.Columns.Add("table_status", typeof(string));

            while (dr.Read())
            {
                DataRow row = dt.NewRow();
                row["table_id"] = dr["table_id"];
                row["table_code"] = dr["table_code"];
                row["table_position"] = dr["table_position"];
                row["table_status"] = dr["table_status"];
                dt.Rows.Add(row);
            }

            dr.Close();

            return dt;
        }

        public DataTable getRecordCommand(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Columns.Add("customer_id", typeof(Int32));
            dt.Columns.Add("customer_code", typeof(string));
            dt.Columns.Add("user_name", typeof(string));
            dt.Columns.Add("customer_level", typeof(string));

            while (dr.Read())
            {
                DataRow row = dt.NewRow();
                row["customer_id"] = dr["customer_id"];
                row["customer_code"] = dr["customer_code"];
                row["user_name"] = dr["user_name"];
                row["customer_level"] = dr["customer_level"];
                dt.Rows.Add(row);
            }

            dr.Close();
            return dt;
        }

        public DataTable getIdCommand(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("order_id", typeof(Int32));

            while(dr.Read())
            {
                DataRow row = dt.NewRow();
                row["order_id"] = dr["order_id"];
                dt.Rows.Add(row);
            }

            dr.Close();
            return dt;
        }
        public DataTable getOrderDetails(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("order_detail_id", typeof(Int32));
            dt.Columns.Add("dish_id", typeof(Int32));
            dt.Columns.Add("dish_quantity", typeof(Int32));

            while (dr.Read())
            {
                DataRow row = dt.NewRow();  
                row["order_detail_id"] = dr["order_detail_id"];
                row["dish_id"] = dr["dish_id"];
                row["dish_quantity"] = dr["dish_quantity"];
                dt.Rows.Add(row);
            }

            dr.Close();
            return dt;
        }

        public DataTable getDishInfo(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("dish_code", typeof(string));
            dt.Columns.Add("dish_name", typeof(string));
            dt.Columns.Add("dish_cost", typeof(Int32));

            while (dr.Read())
            {
                DataRow row = dt.NewRow();
                row["dish_code"] = dr["dish_code"];
                row["dish_name"] = dr["dish_name"];
                row["dish_cost"] = dr["dish_cost"];
                dt.Rows.Add(row);
            }

            dr.Close();
            return dt;
        }

        public DataTable getOrder(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("order_total_price", typeof(Int32));
            dt.Columns.Add("order_code", typeof(string));

            while (dr.Read())
            {
                DataRow row = dt.NewRow();
                row["order_total_price"] = dr["order_total_price"];
                row["order_code"] = dr["order_code"];
                dt.Rows.Add(row);
            }

            dr.Close();
            return dt;
        }
    }


}
