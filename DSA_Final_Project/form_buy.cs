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
    public partial class form_buy : Form
    {
        public int Page = 0;
        
        public form_buy(string text,bool truth = true)
        {
            InitializeComponent();
            label21.Text = text;
            button1.Visible = truth;
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Page++;
            Page = Page % 2;
            switch(Page)
            {
            case 0:
                    label14.Text="CHEESE";
                    label13.Text = "600 PKR";
                    pictureBox6.BackgroundImage = global::DSA_Final_Project.Properties.Resources.grocery5;
                    numericUpDown5.Value = 0;
                    label16.Text = "EGGS";
                    label15.Text = "15 PKR";
                    pictureBox7.BackgroundImage = global::DSA_Final_Project.Properties.Resources.grocery3;
                    numericUpDown6.Value = 0;
                    label18.Text = "BUTTER";
                    label17.Text = "120 PKR";
                    pictureBox8.BackgroundImage = global::DSA_Final_Project.Properties.Resources.grocery2;
                    numericUpDown7.Value = 0;
                    label20.Text = "BREAD";
                    label19.Text = "60 PKR";
                    pictureBox9.BackgroundImage = global::DSA_Final_Project.Properties.Resources.grocery1;
                    numericUpDown8.Value = 0;
                    button1.Text = "GO TO PAGE -> 2";
            break;
            case 1:
                    label14.Text="WHEAT";
                    label13.Text = "80 PKR";
                    pictureBox6.BackgroundImage = global::DSA_Final_Project.Properties.Resources.grocery8;
                    numericUpDown5.Value = 0;
                    label16.Text = "MEAT";
                    label15.Text = "400 PKR";
                    pictureBox7.BackgroundImage = global::DSA_Final_Project.Properties.Resources.grocery4;
                    numericUpDown6.Value = 0;
                    label18.Text = "RICE";
                    label17.Text = "180 PKR";
                    pictureBox8.BackgroundImage = global::DSA_Final_Project.Properties.Resources.grocery7;
                    numericUpDown7.Value = 0;
                    label20.Text = "MILK";
                    label19.Text = "80 PKR";
                    pictureBox9.BackgroundImage = global::DSA_Final_Project.Properties.Resources.grocery6;
                    numericUpDown8.Value = 0;
                    button1.Text = "GO TO PAGE -> 1";
            break;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int size = 0;
            string name = label20.Text;
            int price = Convert.ToInt32(label19.Text.Replace(" PKR",""));
            int quantity = Convert.ToInt32(numericUpDown8.Value);
            if (Page == 0)
            {
                size = 5 * quantity;
            }
            else
                size = 4 * quantity;
            form_cart.AddToCart(name, price, quantity, size);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int size = 0;
            string name = label18.Text;
            int price = Convert.ToInt32(label17.Text.Replace(" PKR", ""));
            int quantity = Convert.ToInt32(numericUpDown7.Value);
            if (Page == 0)
            {
                size = 2 * quantity;
            }
            else
                size = 7 * quantity;
            form_cart.AddToCart(name, price, quantity, size);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int size = 0;
            string name = label16.Text;
            int price = Convert.ToInt32(label15.Text.Replace(" PKR", ""));
            int quantity = Convert.ToInt32(numericUpDown6.Value);
            if (Page == 0)
            {
                size = 1 * quantity;
            }
            else
                size = 6 * quantity;
            form_cart.AddToCart(name, price, quantity, size);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int size = 0;
            string name = label14.Text;
            int price = Convert.ToInt32(label13.Text.Replace(" PKR", ""));
            int quantity = Convert.ToInt32(numericUpDown5.Value);
            if (Page == 0)
            {
                size = 3 * quantity;
            }
            else
                size = 8 * quantity;
            form_cart.AddToCart(name, price, quantity, size);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        
    }
}
