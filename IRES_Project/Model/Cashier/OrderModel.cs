using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cashier
{
    public class Order
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int name;
        public int Name
        {
            get { return name; }
            set { name = value; }
        }

        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private int orderTotalPrice;

        public int OrderTotalPrice
        {
            get { return orderTotalPrice; }
            set { orderTotalPrice = value; }
        }
    }
}
