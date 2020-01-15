using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            SQLExcute sqlExecute= new SQLExcute();

            DataTable dt = sqlExecute.GetExcuteQuery(query);

            return dt;
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
