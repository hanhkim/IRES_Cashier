using IRES_Globals.Cashier;
using Model.Cashier;
using System.Windows;
using System.Windows.Controls;
using ViewModel.Cashier.Common;
using ViewModel.Cashier.Modules;

namespace IRES_Project.Cashier.MainPage
{
    /// <summary>
    /// Interaction logic for BillPage.xaml
    /// </summary>
    public partial class BillPage : UserControl
    {
        TableModel tableSelected = new TableModel();
        BillViewModel billVM;
        float promotionMoney = 0;
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
            tableSelected = selectedTableInput;
            if (selectedTableInput.Promotion != null)
            {
                PromotionHard(selectedTableInput.Promotion);
            }
            if (selectedTableInput != null) {
                //tableSelected = selectedTableInput;

                billVM = new BillViewModel(tableSelected.Id, tableSelected.TipMoney, promotionMoney);
                txtTableCode.Content = tableSelected.TableName;
                DataContext = billVM;
            }
            MemoryAction.Instance.CurrentPage = "Hóa đơn";
            //tipMoney.Text = selectedTableInput.TipMoney.ToString();

            promotionText.Text = selectedTableInput.Promotion;
        }

        public BillPage(int i)
        {
            InitializeComponent();

            BillViewModel billVM = new BillViewModel(i, tableSelected.TipMoney, 35000);

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

        private void Button_Click_Add_Promotion(object sender, RoutedEventArgs e)
        {
            string promotion = promotionText.Text;
            PromotionHard(promotion);
        }

        private void PromotionHard(string promotion)
        {
            if (promotion == "KM001")
            {
                promotionMoney = 35000;

                if(billVM == null)
                {
                    billVM = new BillViewModel(tableSelected.Id, tableSelected.TipMoney, promotionMoney);
                }

                billVM.MoneyDetail.PromotionMoney = 35000;
            }
            else if (promotion == "KM002")
            {
                promotionMoney = 50000;
                billVM.MoneyDetail.PromotionMoney = 50000;
            }
            else
            {
                MessageBox.Show("Mã khuyến mãi không hợp lệ");
            }

         //   discountPromotionText.Text = promotionMoney.ToString();
        }
    }
}
