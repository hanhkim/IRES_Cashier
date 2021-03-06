﻿using System;
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
using IRES_Globals.Cashier;
using Model.Cashier;
using IRES_Project.MoMo;
using Service.API;

namespace IRES_Project.Cashier.MainPage
{
    /// <summary>
    /// Interaction logic for TablePage.xaml
    /// </summary>
    public partial class TablePage : UserControl
    {
        private TableViewModel tbVM = null;
        string floorChosen = "Tầng 1";
        public TablePage()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            tbVM = new TableViewModel(floorChosen); // declare table list
            DataContext = tbVM;
            MemoryAction.Instance.CurrentPage = "Bàn";
            BreadCrumbViewModel.Instance.RemovePos("Bàn");
        }

        private void lbxTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TableModel selectedTable = e.AddedItems[0] as TableModel;
            MemoryAction.Instance.CurrentSelectedTable = selectedTable;
            Switcher.Switch(new BillPage(selectedTable));
            BreadCrumbViewModel.Instance.BreadCrumb.Add("Hóa đơn");
        }

        private void Button_Click_Refresh(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void cmbChooseFloor_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbChooseFloor.SelectedValue.ToString() == "Tầng 1")
            {
                floorChosen = "Tầng 1";
                tbVM = new TableViewModel(floorChosen);
                DataContext = tbVM;
            }
            else if (cmbChooseFloor.SelectedValue.ToString() == "Tầng 2")
            {
                floorChosen = "Tầng 2";
                tbVM = new TableViewModel(floorChosen);
                DataContext = tbVM;
            }
            else
            {
                MessageBox.Show("Mời bạn chọn lại tầng nhé!");
            }
        }

        private void Button_Click_Payment(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).CommandParameter);
            GotoMomopayment(id);
        }

        public async void GotoMomopayment(int idTable)
        {
            MoMoPayment momoRequest = new MoMoPayment();

            BillViewModel billVM = new BillViewModel(idTable, 0, 0);
            string billId = "BILL_" + DateTime.Now.ToString("yyyyMMddHHmmssffff");
            int result = momoRequest.GoToMomoPayment(billVM.MoneyDetail.TotalPay, billId);

            if (result == 1) // thanh toan thanh cong
            {
                PaymentViewModel paymentVM = new PaymentViewModel(billVM.MoneyDetail.TotalPay);
                if(paymentVM.FinishPayment(billVM.OrderInfo, idTable, billVM.CustomerInfo, paymentVM.MoneyModel, "", billId ))
                {
                  //  System.Windows.Forms.MessageBox.Show("Thanh toan thành công");
                    // send api to backend
                    ApiBackendService apiBackend = new ApiBackendService();
                    await apiBackend.SendApiToBackend(billVM.OrderInfo.Id);
                  //  MessageBox.Show("Thanh toan thanh cong");

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
            else if (result == -1) // thanh toan that bai
            {
                MessageBox.Show("Thanh toan momo that bai, vui long kiem tra lai");
            }
            else if (result == 0) // khong bat browser
            {

            }
        }

    }
}