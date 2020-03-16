using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Modules;

namespace Implements.Workers
{
    public class WorkerToDB
    {
        
        public WorkerToDB()
        {

        }    
        public DataTable getRecordsCommand(string query)
        {
            try
            {
                SQLExcute sqlExecute = new SQLExcute();

                DataTable dt = sqlExecute.GetExcuteQuery(query);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get records loi");
                return null;
            }
           
        }

        public Boolean updateCommand(string query)
        {

            SQLExcute sqlExecute = new SQLExcute();

            return sqlExecute.UpdateExcuteQuery(query);
        }

        public bool insertCommand(string query)
        {
            SQLExcute sqlExecute = new SQLExcute();

            return sqlExecute.InsertExecuteQuery(query);
        }

    }
}
