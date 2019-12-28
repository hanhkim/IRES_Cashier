using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cashier
{
    public class CustomerModel: BaseModel
    {
        public CustomerModel()
        {

        }

        private string _Name;
        public string Name 
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged(); }
        }

        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; OnPropertyChanged(); } 
        }

        private string _Level;
        public string Level
        { 
            get { return _Level; }
            set { _Level = value; OnPropertyChanged(); }
        }

        private string _Code;
        public string Code
        {
            get { return _Code; }
            set { _Code = value; OnPropertyChanged(); }
        }
    }
}
