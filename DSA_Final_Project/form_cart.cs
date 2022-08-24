using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DSA_Final_Project
{
    public partial class form_cart : Form
    {
        public static linklist list1 = new linklist();
        public void insert_items(bool Sorting,bool insertion_getItem)
        {
            remove_items();
            item[] cart_items = insertion_getItem ? list1.get_items() : list1.sortBy(Sorting);

            foreach (item item_object in cart_items)
            {
                ListViewItem.ListViewSubItemCollection parent = listView1.Items.Add(item_object.name_Object).SubItems;
                parent.Add(Convert.ToString(item_object.price_item));
                parent.Add(Convert.ToString(item_object.quantity));
                parent.Add(Convert.ToString(item_object.size));
                parent.Add(Convert.ToString(item_object.maxPrice));
            }
            group_items();
        }
        public void remove_items()
        {
            foreach (ListViewItem Item in listView1.Items)
            {
                listView1.Items.Remove(Item);
            }
        }
        public void group_items()
        {
            foreach (ListViewItem Item in listView1.Items)
            {
                Item.Group = listView1.Groups[0];
            }
        }
        public static void AddToCart(string name, int price, int quantity, int size)
        {
            item items = new item(name, price, quantity, size);
            list1.insert(items);
        }
        public form_cart()
        {
            InitializeComponent();
        }

        private void form_cart_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            remove_items();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insert_items(true,false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insert_items(false,true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            insert_items(false, false);
        }

    }
}
