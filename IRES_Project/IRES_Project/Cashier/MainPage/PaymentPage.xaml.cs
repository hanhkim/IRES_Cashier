using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel.Cashier.Modules;
using Model.Cashier;
using System.Net;
using Newtonsoft.Json.Linq;
using IRES_Project.MoMo;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using Service.API;

namespace IRES_Project.Cashier.MainPage
{
    /// <summary>
    /// Interaction logic for PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : System.Windows.Controls.UserControl
    {
        PaymentViewModel paymentVM;
        TableModel tableSelected = new TableModel();
        CustomerModel cus = new CustomerModel();
        Order orderinfo;

        int orderId, tableId, customerId;

        public PaymentPage()
        {
            InitializeComponent();
        }

        public PaymentPage(float totalPay, Order orderInfo, TableModel tableSelected, CustomerModel customer)                             
        {
            InitializeComponent();
            // this.customerId = customer_id;
            orderinfo = orderInfo;
            cus = customer;
            LoadData(totalPay, orderInfo.Id, tableSelected);
        }

        public void LoadData(float totalPay, int orderId, TableModel tableSelected)
        {
            this.tableSelected = tableSelected;
            this.orderId = orderId;
            this.tableId = tableSelected.Id;
            paymentVM = new PaymentViewModel(totalPay);
            DataContext = paymentVM;
        }

        private void Button_Click_Money_Customer(object sender, RoutedEventArgs e)
        {
            paymentVM.MoneyModel.MoneyReturnCustomer = paymentVM.MoneyModel.setMoneyReturnCustomer();
        }

        private void CheckBox_Checked_Not_Get_Redundant_Money(object sender, RoutedEventArgs e)
        {  
            paymentVM.MoneyModel.MoneyCustomerGive = paymentVM.MoneyModel.MoneyCustomer - paymentVM.MoneyModel.TotalPay;
            paymentVM.MoneyModel.MoneyReturnCustomer = paymentVM.MoneyModel.setMoneyReturnCustomer();
        }

        private void CheckBox_Unchecked_Not_Get_Redundant_Money(object sender, RoutedEventArgs e)
        {
            paymentVM.MoneyModel.MoneyCustomerGive = 0;
            paymentVM.MoneyModel.MoneyReturnCustomer = paymentVM.MoneyModel.setMoneyReturnCustomer();
        }

        private void CheckBox_Checked_Customer_Tip(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            paymentVM.MoneyModel.MoneyReturnCustomer = paymentVM.MoneyModel.setMoneyReturnCustomer();
        }

        private void CheckBox_Unchecked_Customer_Tip(object sender, RoutedEventArgs e)
        {
            paymentVM.MoneyModel.MoneyCustomerTip = 0;
            paymentVM.MoneyModel.MoneyReturnCustomer = paymentVM.MoneyModel.setMoneyReturnCustomer();
        }

        private void Button_Payement_Click(object sender, RoutedEventArgs e)
        {

            if (paymentVM.MoneyModel.MoneyCustomer <= 0 || paymentVM.MoneyModel.MoneyReturnCustomer < 0)
            {
                System.Windows.Forms.MessageBox.Show("Có sự cố xảy ra!!! Vui lòng kiểm tra lại");
                return;
            }
            string billId = "BILL_" + DateTime.Now.ToString("yyyyMMddHHmmssffff");

            GoToPayment("cash", billId);
        }

        public async void GoToPayment(string type, string billId)
        {
            //MoneyPayModel money = paymentVM.MoneyModel;

            if (paymentVM.FinishPayment(orderinfo, tableId, cus, paymentVM.MoneyModel, type, billId))
            {
                System.Windows.Forms.MessageBox.Show("Thanh toan thành công");
                // send api to backend
                ApiBackendService apiBackend = new ApiBackendService();
                await apiBackend.SendApiToBackend(orderinfo.Id);

                // return table page
                IRES_Globals.Cashier.MemoryAction.Instance = null;
                ViewModel.Cashier.Common.BreadCrumbViewModel.Instance.RemovePos("Bàn");
                Switcher.Switch(new TablePage());
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Có sự cố xảy ra!!! Vui lòng kiểm tra lại");
            }
        }


        string endpointApp = "";
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private void Button_Click_MoMoPayment(object sender, RoutedEventArgs e)
        {
            MoMoPayment momopayment = new MoMoPayment();
            string billId = "BILL_" + DateTime.Now.ToString("yyyyMMddHHmmssffff");
            int result = momopayment.GoToMomoPayment(paymentVM.MoneyModel.TotalPay, billId);
            if (result == 1) // thanh toan thanh cong
            {
                GoToPayment("momo", billId);
            } 
            else if (result == -1) // thanh toan that bai
            {
                System.Windows.MessageBox.Show("Thanh toan momo that bai, vui long kiem tra lai");
            }
            else if (result == 0) // khong bat browser
            {

            }
        }
    }
}
