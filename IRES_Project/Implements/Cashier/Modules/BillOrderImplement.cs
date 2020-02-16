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
    public class BillOrderImplement
    {
        public BillOrderImplement()
        {

        }
        public int getOrderId(int idTable)
        {
            string query = $"SELECT bt.order_id FROM ires.booking_table bt" +
                $" WHERE bt.table_id={idTable} AND bt.status = 'CHƯA THANH TOÁN'";

            WorkerToDB billToDB = new WorkerToDB();
            DataTable dt = billToDB.getRecordsCommand(query);

            int id = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = Convert.ToInt32(dt.Rows[i]["order_id"]);
            }

            return id;
        }

        public Order getOrderInfo(int order_id)
        {
            string query = $"select * from ires.orders where order_id={order_id}";

            WorkerToDB billToDB = new WorkerToDB();
            DataTable dt = billToDB.getRecordsCommand(query);

            var orderInfo = new Order();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var orderTotalPrice = (Convert.ToInt32(dt.Rows[i]["order_total_price"].ToString() != "" ? dt.Rows[i]["order_total_price"] : 280000)) ;
                var code = dt.Rows[i]["order_code"].ToString() != "" ? dt.Rows[i]["order_code"].ToString() : "o_111111";
                var persons = dt.Rows[i]["person_quantity"].ToString() != "" ? Convert.ToInt32(dt.Rows[i]["person_quantity"]) : 4;
                orderInfo = new Order()
                {
                    OrderTotalPrice = orderTotalPrice,
                    Code = code,
                    Id = order_id,
                    PersonQuantity = persons
                };
            }

            return orderInfo;
        }

        public CustomerModel getCustomerInfo(int order_id)
        {
            string query = $"SELECT * from ires.customer" +
                $" where customer_id IN (" +
                $" select customer_id from ires.orders where order_id={order_id})";

            WorkerToDB billToDB = new WorkerToDB();
            DataTable dt = billToDB.getRecordsCommand(query);

            var result = new CustomerModel();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var cusIdTemp = dt.Rows[i]["customer_id"].ToString() != "" ? Convert.ToInt32(dt.Rows[i]["customer_id"]) : 1;
                var cusNameTemp = dt.Rows[i]["user_name"].ToString() != "" ? dt.Rows[i]["user_name"].ToString() : "Kim Hạnh";
                var cusCodeTemp = dt.Rows[i]["customer_code"].ToString() != "" ? dt.Rows[i]["customer_code"].ToString() : "C_01";
                var cusLevelTemp = dt.Rows[i]["customer_level"].ToString() != "" ? dt.Rows[i]["customer_level"].ToString() : "Vàng";

                result = new CustomerModel()
                {
                    ID = cusIdTemp,
                    Name = cusNameTemp,
                    Code = cusCodeTemp,
                    Level = cusLevelTemp
                };
            }

            if (dt.Rows.Count == 0)
            {
                result = new CustomerModel
                {
                    ID = 1,
                    Name = "Kim Hạnh",
                    Code = "C_01",
                    Level = "Vàng"
                };
            }

            return result;
        }

        public List<OrderDetail> getDishesInfo(int order_id)
        {
            string query = $"Select * from ires.order_detail where order_id={order_id}";
            WorkerToDB billToDB = new WorkerToDB();
            DataTable dtOrderDetailInfo = billToDB.getRecordsCommand(query);

            var result = new List<OrderDetail>();

            for (int i = 0; i < dtOrderDetailInfo.Rows.Count; i++)
            {
                int dishId = Convert.ToInt32(dtOrderDetailInfo.Rows[i]["dish_id"]);
                var checkDishId = result.FirstOrDefault(x => x.DishId == dishId);

                var queryGetDish = $"Select * from ires.dish where dish_id={dishId}";
                var resultDish = new Dish();
                // get cost of dish
                DataTable dtDishInfo = billToDB.getRecordsCommand(queryGetDish); // get cost

                if (checkDishId == null)
                {
                    result.Add(new OrderDetail()
                    {
                        DishQuantity = Convert.ToInt32(dtOrderDetailInfo.Rows[i]["dish_quantity"]),
                        Id = Convert.ToInt32(dtOrderDetailInfo.Rows[i]["order_detail_id"]),
                        DishId = dishId,
                        DishCost = Convert.ToInt32(dtDishInfo.Rows[0]["dish_cost"]),
                        DishName = dtDishInfo.Rows[0]["dish_name"].ToString(),
                        DishTotalCost = Convert.ToInt32(dtOrderDetailInfo.Rows[i]["dish_quantity"]) * Convert.ToInt32(dtDishInfo.Rows[0]["dish_cost"])
                    });
                }
            }

            return result;
        }
    }
}
