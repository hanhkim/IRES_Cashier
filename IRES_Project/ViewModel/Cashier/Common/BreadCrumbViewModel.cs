using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRES_Globals.Cashier;
using ViewModel.GlobalViewModels;

namespace ViewModel.Cashier.Common
{
    public class BreadCrumbViewModel: BaseViewModel
    {
        private static BreadCrumbViewModel _Instance;
        public static BreadCrumbViewModel Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BreadCrumbViewModel();
                }
                return _Instance;
            }
            set
            {
                _Instance = value;
            }
        }
        public BreadCrumbViewModel()
        {
            BreadCrumb = new List<string>();
            BreadCrumb.Add("Table");
        }

        private List<string> _BreadCrumb;
        public List<string> BreadCrumb
        {
            get
            {
                return _BreadCrumb;
            }
            set
            {
                _BreadCrumb = value;
                OnPropertyChanged();
            }
        }

        public bool RemovePos(string pos) 
        {
            switch(pos)
            {
                case "Table":
                    if (Instance.BreadCrumb != null)
                    {
                        Instance.BreadCrumb.Clear();
                        Instance.BreadCrumb.Add("Table");
                    }
                    break;
                case "Bill":
                    Instance.BreadCrumb.Clear();
                    Instance.BreadCrumb.Add("Table");
                    Instance.BreadCrumb.Add("Bill");
                    break;
                case "Payment":
                    Instance.BreadCrumb.Clear();
                    Instance.BreadCrumb.Add("Table");
                    Instance.BreadCrumb.Add("Bill");
                    Instance.BreadCrumb.Add("Payment");
                    break;
                default: break;
            }
            return true;
        }

    }
}
