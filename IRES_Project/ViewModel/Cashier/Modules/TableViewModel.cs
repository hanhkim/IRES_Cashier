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
        //private List<FloorModel>  _ListFloors;
        private FloorModel _ListFloors;

        public TableViewModel(string tablePosition)
        {
            ListFloors = loadTable(tablePosition);
        }

       
        public FloorModel ListFloors { get => _ListFloors; set => _ListFloors = value; }

        public FloorModel loadTable(string idFloor)
        {
            TableImplement tableImp = new TableImplement();

            var result = tableImp.GetListTables(idFloor);

            return result;
        }
    }
}
