using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Cashier;
using Implements.Workers;
using System.Collections.ObjectModel;

namespace Implements.Cashier.Modules
{
    public class TableImplement
    {
        public TableImplement()
        {

        }

        public FloorModel GetListTables(string tablePosition)
        {
            string query = $"SELECT * FROM ires.table_info where table_position='{tablePosition}' AND active=true";
            FloorModel result = new FloorModel();
            result.Name = tablePosition;
            WorkerToDB tableToDB = new WorkerToDB();

            DataTable dtFloor = tableToDB.getRecordsCommand(query);

            for (int i = 0; i < dtFloor.Rows.Count; i++)
            {
                var table = new TableModel()
                {
                    Code = dtFloor.Rows[i]["table_code"].ToString(),
                    Id = Convert.ToInt32(dtFloor.Rows[i]["table_id"]),
                    StatusShow = dtFloor.Rows[i]["table_status"].ToString() == "CÒN TRỐNG" ? false : true,
                    TableName = "Bàn " + dtFloor.Rows[i]["table_number"].ToString()
                };

                if (table.StatusShow == true)
                {
                    ++result.CountBusyTables;
                }
                else
                {
                    ++result.CountEmptyTables;
                }

                result.ListTables.Add(table);
            }

            result.ListTables = result.ListTables.OrderBy(x => x.Code).ToList();
            return result;
        }

    }
}
