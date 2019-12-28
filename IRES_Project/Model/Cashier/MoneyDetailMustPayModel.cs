using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cashier
{
    public class MoneyDetailMustPayModel: BaseModel
    {
        public MoneyDetailMustPayModel()
        {

        }

        private float moneyVAT;
        public float MoneyVAT
        {
            get { return moneyVAT; }
            set { moneyVAT = value; OnPropertyChanged(); }
        }

        private float totalPay = 0;

        public float TotalPay
        {
            get { return totalPay; }
            set { totalPay = value; OnPropertyChanged(); }
        }

        public void CaculateMoneyDetail(int vat, int totalPrice)
        {
            MoneyVAT = totalPrice * vat / 100;
            TotalPay = totalPrice + MoneyVAT;
        }
    }
}
