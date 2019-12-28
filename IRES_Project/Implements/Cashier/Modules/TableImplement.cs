using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DB;
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

        public List<FloorModel> GetFloors()
        {
            string query = $"SELECT * FROM ires.table_info where active=true";
            List<FloorModel> result = new List<FloorModel>();
            WorkerToDB tableToDB = new WorkerToDB();

            DataTable dtFloor = tableToDB.getRecordsCommand(query);

            for (int i = 0; i < dtFloor.Rows.Count; i++)
            {
                var FloorName = dtFloor.Rows[i]["table_position"].ToString();
                var checkFloor = result.FirstOrDefault(x => x.Name == FloorName);

                var table = new TableModel()
                {
                    Code = dtFloor.Rows[i]["table_code"].ToString(),
                    Id = Convert.ToInt32(dtFloor.Rows[i]["table_id"]),
                    StatusShow = dtFloor.Rows[i]["table_status"].ToString() == "CÒN TRỐNG" ? false : true
                };

                if (checkFloor == null) // if floor not exist => create new floor
                {
                    result.Add(new FloorModel()
                    {
                        Name = FloorName,
                        ListTables = new List<TableModel>() { table }
                    });

                }
                else // else add table to old floor
                {
                    checkFloor.ListTables.Add(table);
                }
            }

            // sort table in floor
            for (int i = 0; i< result.Count; i++)
            {
                result[i].ListTables = result[i].ListTables.OrderBy(x => x.Code).ToList();
            }

            // return sort floor
            return result.OrderBy(x => x.Name).ToList();
        }

    }
}
