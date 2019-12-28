using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cashier
{
    public class Dish
    {
        public Dish()
        {

        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int restaurant_id;

        public int Restaurant_id
        {
            get { return id; }
            set { restaurant_id = value; }
        }

        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string image_url;

        public string Image_url
        {
            get { return image_url; }
            set { image_url = value; }
        }

        private string cost;

        public string Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int category_id;

        public int Category_id
        {
            get { return category_id; }
            set { category_id = value; }
        }

        private string combo_id;

        public string Combo_id
        {
            get { return combo_id; }
            set { combo_id = value; }
        }

        private int sale_off_id;

        public int Sale_off_id
        {
            get { return sale_off_id; }
            set { sale_off_id = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private int description;

        public int Description
        {
            get { return description; }
            set { description = value; }
        }

        ////// still need to add more
    }
}
