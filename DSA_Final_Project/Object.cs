using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DSA_Final_Project
{
    public class item
    {
        /*string name;
        int price;*/
        public int size = 0;
        public int price_item = 0;
        public int quantity = 0;
        public int maxPrice = 0;
        public string name_Object = "";
        public item(string name_Object,int price_item,int quantity,int size)
        {
            this.size = size;
            this.price_item = price_item;
            this.quantity = quantity;
            this.name_Object = name_Object;
            this.maxPrice = price_item * quantity;
        }
    }
}
