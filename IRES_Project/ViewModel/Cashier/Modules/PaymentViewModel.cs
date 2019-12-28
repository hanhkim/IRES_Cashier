using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.GlobalViewModels;
using Model.DB;
using Model.Cashier;
using System.Windows;
using Implements.Cashier;
using Implements.Cashier.Modules;

namespace ViewModel.Cashier.Modules
{
    public class PaymentViewModel: BaseViewModel
    {
        public PaymentViewModel(float totalPay)
        {
            _MoneyModel = new MoneyPayModel()
            {
                TotalPay = totalPay,
                MoneyCustomerGive = 0,
                MoneyReturnCustomer = 0
            };
        }

        MoneyPayModel _MoneyModel;
        
        public MoneyPayModel MoneyModel
        {
            get { return _MoneyModel;  }
            set
            {
                _MoneyModel = value; OnPropertyChanged();
            }
        }

        public MoneyPayModel CaculatePaymentStepCustomerGive(float moneyCustomerGive)
        {
            MoneyPayModel moneyDetailPayment = new MoneyPayModel()
            {
                MoneyCustomer = moneyCustomerGive
            };

            return moneyDetailPayment;
        }

        public Boolean FinishPayment(int order_id, int table_id)
        {
            int user_id = 1;
            PaymentImplement paymentImp = new PaymentImplement();
            if (paymentImp.FinishPayment(order_id, user_id, table_id))
            {
                return true;
            } else
            {
                return false;
            }
        }

        private bool _IsSelected;

        public bool IsSelected
        {
            get { return _IsSelected; }
            set { _IsSelected = value; OnPropertyChanged(); }
        }

    }
}
