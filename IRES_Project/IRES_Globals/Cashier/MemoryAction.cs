using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Cashier;

namespace IRES_Globals.Cashier
{
    public class MemoryAction
    {
        public MemoryAction()
        {

        }
        
        private static MemoryAction _Instance;
        public static MemoryAction Instance 
        { 
            get
            {
                if (_Instance == null)
                {
                    _Instance = new MemoryAction();
                }
                return _Instance;
            }
            set
            {
                
                _Instance = value;
            }
        }
        
        public TableModel CurrentSelectedTable { get; set; }

        public string CurrentPage { get; set; }
    }
}
