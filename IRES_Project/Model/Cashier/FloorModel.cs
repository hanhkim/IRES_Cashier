using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cashier
{
   public class FloorModel: BaseModel
    {
        public FloorModel()
        {
            ListTables = new List<TableModel>();
        }

        private List<TableModel> _ListTable;

        public List<TableModel> ListTables { get => _ListTable; set { _ListTable = value; OnPropertyChanged(); }  }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _Index;

        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }

        private int countEmptyTables;
        private int countBusyTables;


        public int CountEmptyTables { get => countEmptyTables; set => countEmptyTables = value; }
        public int CountBusyTables { get => countBusyTables; set => countBusyTables = value; }
    }
}
