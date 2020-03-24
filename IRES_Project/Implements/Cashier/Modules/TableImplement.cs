using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Cashier;
using Implements.Workers;
using System.Collections.ObjectModel;
using System.Windows.Forms;

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

            try
            {
                for (int i = 0; i < dtFloor.Rows.Count; i++)
                {
                    var table = new TableModel()
                    {
                        Code = dtFloor.Rows[i]["table_code"].ToString(),
                        Id = Convert.ToInt32(dtFloor.Rows[i]["table_id"]),
                        StatusShow = dtFloor.Rows[i]["table_status"].ToString() == "CÒN TRỐNG" ? false : true,
                        TableName = "Bàn " + dtFloor.Rows[i]["table_number"].ToString(),
                        TipMoney = Convert.ToInt32(dtFloor.Rows[i]["tip"].ToString() != "" ? dtFloor.Rows[i]["tip"] : 0 ),
                        Promotion = dtFloor.Rows[i]["promotion"].ToString() != "" ? dtFloor.Rows[i]["promotion"].ToString() : null
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        public List<InfoRequestPaymentModel> GetListInfoNotify()
        {
            string query = "select * from ires.table_info where request_payment=true and table_status='ĐANG DÙNG'";

            List<InfoRequestPaymentModel> result = new List<InfoRequestPaymentModel>();
            
            WorkerToDB tableToDB = new WorkerToDB();

            DataTable listTablesNotifies = tableToDB.getRecordsCommand(query);

            try
            {
                for (int i = 0; i < listTablesNotifies.Rows.Count; i++)
                {
                    var info = new InfoRequestPaymentModel()
                    {
                        Id = Convert.ToInt32(listTablesNotifies.Rows[i]["table_id"]),
                        Type = listTablesNotifies.Rows[i]["payment_type"].ToString(),
                        Description = listTablesNotifies.Rows[i]["table_mes"].ToString()
                    };

                    if(info.Type == "thẻ")
                    {
                        info.Description = "Momo -" + info.Description;
                    }
                    else if(info.Type == "tiền mặt")
                    {
                        info.Description = "Tiền mặt -" + info.Description;
                    }
                   
                    result.Add(info);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lay danh sach notify loi");
            }

            return result;
        }

    }
}
