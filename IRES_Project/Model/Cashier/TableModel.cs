using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cashier
{
    public class TableModel
    {
        public TableModel()
        {

        }
        public int Id { get ; set; }

        public string Code { get ; set; }

        public string Number { get; set; }

        public string Status { get; set; }

        public string Position { get; set; }

        public string NumOfPosition { get; set; }

        public string Description { get; set; }

        public string Active { get; set; }

        public string Version { get; set; }

        public bool StatusShow { get; set; }

        public string TableName { get; set; }

        public float TipMoney { get; set; }

        public string Promotion { get; set; }
    }
}
