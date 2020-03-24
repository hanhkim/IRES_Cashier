using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cashier
{
    public class MoneyDetailMustPayModel: BaseModel
    {
        public MoneyDetailMustPayModel(float totalPrice, float moneyVat, float tip, float promotionMoney)
        {
            this.promotionMoney = promotionMoney;
            this.tip = tip;
            this.MoneyVAT = totalPrice * moneyVat / 100;
            this.TotalPay = totalPrice + MoneyVAT + tip - promotionMoney;
        }

        private float tip;

        private float promotionMoney;

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

        public float Tip { get => tip; set => tip = value; }
        public float PromotionMoney { get => promotionMoney; set => promotionMoney = value; }

        public void CaculateMoneyDetail(int vat, int totalPrice, float tip)
        {
            MoneyVAT = totalPrice * vat / 100;
            TotalPay = totalPrice + MoneyVAT + tip - promotionMoney;
        }
    }
}
