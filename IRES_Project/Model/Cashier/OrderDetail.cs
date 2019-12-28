using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cashier
{
    public class OrderDetail
    {
        public OrderDetail()
        {

        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int dishId;

        public int DishId
        {
            get { return dishId; }
            set { dishId = value; }
        }

        private int dishQuantity;

        public int DishQuantity
        {
            get { return dishQuantity; }
            set { dishQuantity = value; }
        }

        private string pic;

        public string Pic
        {
            get { return pic; }
            set { pic = value; }
        }

        private string image_url;

        public string Image_url
        {
            get { return image_url; }
            set { image_url = value; }
        }

        private int totalCost;

        public int TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public int dishCost;
        public int DishCost 
        {
            get { return dishCost; }
            set { dishCost = value; }
        }

        public string dishName;
        public string DishName
        {
            get { return dishName; }
            set { dishName = value; }
        }

        public int dishTotalCost;
        public int DishTotalCost
        {
            get { return dishTotalCost; }
            set { dishTotalCost = value; }
        }
    }
}
