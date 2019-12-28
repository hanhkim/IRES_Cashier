using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using System.Windows;
using System.Collections.ObjectModel;
using Model.DB;
using ViewModel.GlobalViewModels;

namespace ViewModel.Cashier.Modules
{
    public class LoginViewModel: BaseViewModel
    {
        Connection DataContext = null;
        public LoginViewModel()
        {
            DataContext = Connection.Instance;
        }
        private string _UserName;

        public string UserName
        {
            get => _UserName; 
            set { _UserName = value; OnPropertyChanged(); }
        }

        private string _PassWord;

        public string PassWord
        {
            get => _PassWord; 
            set { _PassWord = value; OnPropertyChanged(); }
        }

        //public ObservableCollection<User> User
        //{
        //    get;
        //    set;
        //}

        public Boolean checkUser()
        {
            string query = $"SELECT 1 FROM ires.employee WHERE user_name='{this.UserName}' and password='{this.PassWord}'";

            return DataContext.runCommand(query);
        }
    }
}
