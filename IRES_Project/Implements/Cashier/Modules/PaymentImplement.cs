﻿using System;
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

        public bool FinishPayment(Order orderInfo, int user_id, int table_id, MoneyPayModel moneyPay, CustomerModel cus)
        {
            if (WriteToBill(orderInfo, user_id, moneyPay, cus) && UpdateOrder(orderInfo.Id, user_id) && UpdateBookingTable(orderInfo.Id) && UpdateTableList(table_id))
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

        public bool WriteToBill(Order orderInfo, int user_id, MoneyPayModel moneyPay, CustomerModel cus)
        {

            string query = $"INSERT INTO ires.BILL (BILL_CODE, ORDER_ID, ORDER_TOTAL_PRICE, CUSTOMER_ID, EMPLOYEE_ID, PAYMENT, TIP, PROMOTION_ID, PROMOTION_COST, CREATED_DATETIME, UPDATED_BY, CUSTOMER_NAME, PERSON_QUANTITY)" +
                $" values('BILL_{DateTime.Now.ToString("yyyyMMddHHmmssffff")}' , {orderInfo.Id}, {moneyPay.TotalPay}, {cus.ID}, {user_id}, {moneyPay.MoneyCustomer}, {moneyPay.MoneyCustomerTip + moneyPay.MoneyCustomerGive}, null, 0, '{DateTime.Now}', {user_id}, '{cus.Name}', {orderInfo.PersonQuantity})";
            WorkerToDB billToDB = new WorkerToDB();

            return billToDB.insertCommand(query);
        }
    }
}
