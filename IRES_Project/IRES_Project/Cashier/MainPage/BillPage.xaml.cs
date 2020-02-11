using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel.Cashier.Modules;
using ViewModel.Cashier.Common;
using IRES_Project.Cashier.MainPage;
using IRES_Globals.Cashier;
using Model.Cashier;

namespace IRES_Project.Cashier.MainPage
{
    /// <summary>
    /// Interaction logic for BillPage.xaml
    /// </summary>
    public partial class BillPage : UserControl
    {
        TableModel tableSelected = new TableModel();
        BillViewModel billVM;
        public BillPage()
        {
            InitializeComponent();
            MemoryAction.Instance.CurrentPage = "Hóa đơn";
        }

        public BillPage(TableModel selectedTable)
        {
            InitializeComponent();
            LoadData(selectedTable);
        }

        public void LoadData(TableModel selectedTableInput)
        {
            if (selectedTableInput != null) {
                tableSelected = selectedTableInput;
                billVM = new BillViewModel(tableSelected.Id);
                txtTableCode.Content = tableSelected.TableName;
                DataContext = billVM;
            }
            MemoryAction.Instance.CurrentPage = "Hóa đơn";
        }

        public BillPage(int i)
        {
            InitializeComponent();

            BillViewModel billVM = new BillViewModel(i);

            DataContext = billVM;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float totalPay = (DataContext as BillViewModel).MoneyDetail.TotalPay;
            Switcher.Switch(new PaymentPage(totalPay, billVM.OrderInfo, tableSelected, billVM.CustomerInfo));
            BreadCrumbViewModel.Instance.BreadCrumb.Add("Thanh toán");
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new TablePage());
        }
    }
}
