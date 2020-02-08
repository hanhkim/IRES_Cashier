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
            BreadCrumb.Add("Bàn");
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
                case "Bàn":
                    if (Instance.BreadCrumb != null)
                    {
                        Instance.BreadCrumb.Clear();
                        Instance.BreadCrumb.Add("Bàn");
                    }
                    break;
                case "Hóa đơn":
                    Instance.BreadCrumb.Clear();
                    Instance.BreadCrumb.Add("Bàn");
                    Instance.BreadCrumb.Add("Hóa đơn");
                    break;
                case "Thanh toán":
                    Instance.BreadCrumb.Clear();
                    Instance.BreadCrumb.Add("Bàn");
                    Instance.BreadCrumb.Add("Hóa đơn");
                    Instance.BreadCrumb.Add("Thanh toán");
                    break;
                default: break;
            }
            return true;
        }

    }
}
