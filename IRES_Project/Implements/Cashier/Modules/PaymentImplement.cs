using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implements.Workers;
using Model.Cashier;

namespace Implements.Cashier.Modules
{
    public class PaymentImplement
    {
        public PaymentImplement()
        {

        }

        public bool FinishPayment(int order_id, int user_id, int table_id)
        {
            if (UpdateOrder(order_id, user_id) && UpdateBookingTable(order_id) && UpdateTableList(table_id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateOrder(int order_id, int user_id)
        {
            // tức là thêm các column vao table orders: date-time-checkout, cashier_id.
            // Update order_status -> đã thanh toán, update status_table trong table table_info thành Còn trống.
            DateTime localDate = DateTime.Now;
            string query = $"update ires.orders set order_status='Hoàn thành', cashier_id={user_id}, date_time_checkout='{localDate}' where order_id={order_id}";
            WorkerToDB paymentToBD = new WorkerToDB();
            return paymentToBD.updateCommand(query);
        }

        public bool UpdateTableList(int table_id)
        {
            string query = $"update ires.table_info set table_status='CÒN TRỐNG' where table_id={table_id}";
            WorkerToDB paymentToBD = new WorkerToDB();
            return paymentToBD.updateCommand(query);
        }

        public bool UpdateBookingTable(int order_id)
        {
            string query = $"update ires.booking_table set status='Đã thanh toán' where order_id={order_id}";
            WorkerToDB paymentToBD = new WorkerToDB();
            return paymentToBD.updateCommand(query);
        }
    }
}
