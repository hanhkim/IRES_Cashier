using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cashier
{
    public class InfoRequestPaymentModel
    {
        int id;
        string description;
        string type;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public string Type { get => type; set => type = value; }
    }
}
