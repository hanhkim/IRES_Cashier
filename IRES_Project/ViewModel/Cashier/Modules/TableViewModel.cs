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
        private List<InfoRequestPaymentModel> _ListInfoNotify;

        public TableViewModel(string tablePosition)
        {
            ListFloors = loadTable(tablePosition);
            ListInfoNotify = loadListInfoNotify();
        }

       
        public FloorModel ListFloors { get => _ListFloors; set => _ListFloors = value; }
        public List<InfoRequestPaymentModel> ListInfoNotify { get => _ListInfoNotify; set => _ListInfoNotify = value; }

        public FloorModel loadTable(string idFloor)
        {
            TableImplement tableImp = new TableImplement();

            var result = tableImp.GetListTables(idFloor);

            return result;
        }

        public List<InfoRequestPaymentModel> loadListInfoNotify()
        {
            List<InfoRequestPaymentModel> result = new List<InfoRequestPaymentModel>();
            TableImplement tableImp = new TableImplement();
            result = tableImp.GetListInfoNotify();

            return result;
        }
    }
}
