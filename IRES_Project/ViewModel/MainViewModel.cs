using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // To add MessageBox
using System.Windows.Input;
using ViewModel.GlobalViewModels;

namespace ViewModel
{
    public class MainViewModel: BaseViewModel
    {
        public bool IsLoaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        
        // Every thing do in this
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<object>((p) =>{ return true; }, (p) =>
            {
                IsLoaded = true;
            });
        }
    }
}
