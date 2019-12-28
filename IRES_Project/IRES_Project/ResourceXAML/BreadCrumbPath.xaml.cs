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
using IRES_Project.Cashier.MainPage;
using ViewModel.Cashier.Common;

namespace IRES_Project.ResourceXAML
{
    /// <summary>
    /// Interaction logic for SwitcherMenu.xaml
    /// </summary>
    public partial class BreadCrumbPath : UserControl
    {
        public BreadCrumbPath()
        {
            InitializeComponent();

            this.DataContext = BreadCrumbViewModel.Instance;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string current = (e.Source as Button).Content.ToString();
            switch (current)
            {
                case "Table":
                    Switcher.Switch(new TablePage());
                    break;
                case "Bill":
                    Switcher.Switch(new BillPage(IRES_Globals.Cashier.MemoryAction.Instance.CurrentSelectedTable));
                    break;
                case "Payment":
                    Switcher.Switch(new PaymentPage());
                    break;
                default: break;
            }
            BreadCrumbViewModel.Instance.RemovePos(current);
        }
    }
}
