using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.GlobalViewModels;
using System.Collections.ObjectModel;
using Model.Cashier;
using Implements.Cashier.Modules;

namespace ViewModel.Cashier.Modules
{
    public class TableViewModel: BaseViewModel
    {
        private List<FloorModel>  _ListFloors;
        public List<FloorModel> ListFloors
        {
            get { return _ListFloors; }
            set { _ListFloors = value; OnPropertyChanged(); }
        }

        public TableViewModel()
        {
            ListFloors = loadTable();
        }

        public List<FloorModel> loadTable()
        {
            TableImplement tableImp = new TableImplement();

            var result = tableImp.GetFloors();

            return result;
        }
    }
}
