using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRES_Globals.GlobalClass;
using Npgsql;
using System.Data;

namespace Service
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
                if (_Instance.Connection.State == ConnectionState.Closed)
                {
                    _Instance.OpenfConnection();
                }
            }
        }

        public SQLConnection()
        {
        }
        public void ConnectDB()
        {
            try {
                Connection = new NpgsqlConnection(
                    "Server=" + ConnectionInfo.SERVER + ";" +
                    "Port=" + ConnectionInfo.PORT + ";" +
                    "User Id=" + ConnectionInfo.USER + ";" +
                    "Password=" + ConnectionInfo.PASSWORD + ";" +
                    "Database=" + ConnectionInfo.DATABASE + ";"
                );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Tao ket noi voi connection loi");
            } 
            
        }

        public void OpenfConnection()
        {
            try
            {
                Connection.Open();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "Tao ket noi db loi");
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
                MessageBox.Show(ex.Message, "Đóng kết nối lỗi");
            }
        }
    }
}
