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

        public bool FinishPayment(int order_id, int user_id, int table_id, MoneyPayModel moneyPay, int customer_id)
        {
            if (WriteToBill(order_id, user_id, moneyPay, customer_id) && UpdateOrder(order_id, user_id) && UpdateBookingTable(order_id) && UpdateTableList(table_id))
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
            // tức là thêm các column vao table orders: date-time-checkout, cashier_id. -> bo vo bill nha
            // Update order_status -> đã thanh toán, update status_table trong table table_info thành Còn trống.
            string query = $"update ires.orders set order_status='HOÀN THÀNH' where order_id={order_id}";
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
            string query = $"update ires.booking_table set status='ĐÃ THANH TOÁN' where order_id={order_id}";
            WorkerToDB paymentToBD = new WorkerToDB();
            return paymentToBD.updateCommand(query);
        }

        public bool WriteToBill(int order_id, int user_id, MoneyPayModel moneyPay, int customer_id)
        {

            string query = $"INSERT INTO ires.BILL (BILL_CODE, ORDER_ID, ORDER_TOTAL_PRICE, CUSTOMER_ID, EMPLOYEE_ID, PAYMENT, TIP, PROMOTION_ID, PROMOTION_COST, CREATED_DATETIME, UPDATED_BY )" +
                $" values('BILL_{DateTime.Now.ToString("yyyyMMddHHmmssffff")}' , {order_id}, {moneyPay.TotalPay}, {customer_id}, {user_id}, {moneyPay.MoneyCustomer}, {moneyPay.MoneyCustomerTip}, null, 0, '{DateTime.Now}', {user_id})";
            WorkerToDB billToDB = new WorkerToDB();

            return billToDB.insertCommand(query);
        }
    }
}
