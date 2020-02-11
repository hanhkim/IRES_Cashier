using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Cashier;
using ViewModel.GlobalViewModels;
using System.Collections.ObjectModel;
using System.Windows;
using System.Data;
using Implements.Cashier.Modules;
using IRES_Globals.GlobalClass;

namespace ViewModel.Cashier.Modules
{
    public class BillViewModel: BaseViewModel
    {
        public BillViewModel(int tableId)
        {
            // Get data to Bill Page
            var order_id = getOrderId(tableId);
            CustomerInfo = getCustomerInfo(order_id);
            OrderInfo = getOrderInfo(order_id);
            ListOrderDetail = getDishesInfo(order_id);

            OrderInfo.OrderTotalPrice = CaculatorTotalPrice();

            MoneyDetail = new MoneyDetailMustPayModel();
            MoneyDetail.CaculateMoneyDetail(InfoContant.VAT, OrderInfo.OrderTotalPrice);
        }

        private MoneyDetailMustPayModel _MoneyDetail;

        public MoneyDetailMustPayModel MoneyDetail
        {
            get { return _MoneyDetail; }
            set { _MoneyDetail = value; OnPropertyChanged(); }
        }

        private CustomerModel _CustomerInfo;

        public CustomerModel CustomerInfo
        {
            get { return _CustomerInfo;  }
            set { _CustomerInfo = value; OnPropertyChanged(); }
        }

        private Order _OrderInfo;

        public Order OrderInfo
        {
            get { return _OrderInfo; }
            set { _OrderInfo = value; OnPropertyChanged(); }
        }

        private List<OrderDetail> _ListOrderDetail;

        public List<OrderDetail> ListOrderDetail
        {
            get { return _ListOrderDetail; }
            set { _ListOrderDetail = value; OnPropertyChanged(); }
        }

        /*  Functions get info */
        public int getOrderId(int idTable)
        {
            BillOrderImplement orderInfo = new BillOrderImplement();
            return orderInfo.getOrderId(idTable);
        }

        public Order getOrderInfo(int order_id)
        {
            BillOrderImplement orderInfo = new BillOrderImplement();
            return orderInfo.getOrderInfo(order_id);
        }

        public CustomerModel getCustomerInfo(int order_id)
        {
            BillOrderImplement orderInfo = new BillOrderImplement();
            return orderInfo.getCustomerInfo(order_id);
        }

        public List<OrderDetail> getDishesInfo(int order_id)
        {
            BillOrderImplement orderInfo = new BillOrderImplement();
            return orderInfo.getDishesInfo(order_id);
        }

        public int CaculatorTotalPrice()
        {
            int total = 0;
            for (int i = 0; i< ListOrderDetail.Count; i++)
            {
                var temp = ListOrderDetail.ElementAt(i);
                total += temp.DishTotalCost;
            }

            return total;
        }
    }
}
