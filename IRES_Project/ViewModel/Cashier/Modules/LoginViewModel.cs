using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using System.Windows;
using System.Collections.ObjectModel;
using ViewModel.GlobalViewModels;
using Implements.Cashier.Modules;

namespace ViewModel.Cashier.Modules
{
    public class LoginViewModel: BaseViewModel
    {
        public LoginViewModel()
        {
            
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

        public Boolean checkUser()
        {
            LoginImplementation loginImp = new LoginImplementation();
            UserModel user = loginImp.getUser(new UserModel(UserName, PassWord));

            //if (user.Role != null && user.Role == "3")
            //{
            //    return true;
            //}
            if (user != null)
            {
                return true;
            }

            return false;
        }
    }
}
