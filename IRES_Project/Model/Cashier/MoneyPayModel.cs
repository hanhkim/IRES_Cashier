using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cashier
{ 
    public class MoneyPayModel: BaseModel
    {
        
        private float moneyCustomer;
        private float totalPay;
        private float moneyCustomerGive;
        private float moneyReturnCustomer;
        private float moneyCustomerTip;
        private bool isSelectedTipAll;
        private bool isSelectedTip;

        public float MoneyCustomer { get => moneyCustomer; set { moneyCustomer = value; OnPropertyChanged(); } }
        public float TotalPay { get => totalPay; set { totalPay = value; OnPropertyChanged(); } }
        public float MoneyCustomerGive { get => moneyCustomerGive; set { moneyCustomerGive = value; OnPropertyChanged(); } }
        public float MoneyReturnCustomer { get => moneyReturnCustomer; set { moneyReturnCustomer = value; OnPropertyChanged(); } }
        // set { moneyReturnCustomer = value; OnPropertyChanged(); }
        public float MoneyCustomerTip { get => moneyCustomerTip; set { moneyCustomerTip = value; OnPropertyChanged(); } }

        public bool IsSelectedTipAll { get => isSelectedTipAll; set { isSelectedTipAll = value;  OnPropertyChanged(); } }
        //public bool IsSelectedTip { get => isSelectedTip; }
        public bool IsSelectedTip { get => isSelectedTip; set => isSelectedTip = value; }

        public float setMoneyReturnCustomer()
        {
            isSelectedTip = true;
            moneyReturnCustomer = moneyCustomer - totalPay - moneyCustomerGive - MoneyCustomerTip;
            return moneyReturnCustomer;
        }
    }
}
