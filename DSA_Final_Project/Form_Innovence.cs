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
    public partial class Form_Innovence : Form
    {
        public Form_Innovence()
        {
            InitializeComponent();
        }

        public void LOAD_INVOICE()
        {
            richTextBox1.Clear();
            int subtotal = 0;
            string banner = new string('-', 100) + "\n";
            item[] cart_items = form_cart.list1.get_items();
            richTextBox1.AppendText(banner);
            richTextBox1.AppendText("\t\t\tCART SYSTEM INVOINCE\n");
            richTextBox1.AppendText(banner);
            richTextBox1.AppendText("Name \t Price \t Quantity \t Total\n");
            foreach (item item_object in cart_items)
            {
                string print = item_object.name_Object + "\t" + item_object.price_item + "\t" + item_object.quantity + "\t" + item_object.maxPrice+"\n";
                subtotal += item_object.maxPrice;
                richTextBox1.AppendText(print);
            }
            richTextBox1.AppendText(banner);
            richTextBox1.AppendText(banner);
            richTextBox1.AppendText("\t\t\tTotal Price :- " + subtotal);
        }

        private void Form_Innovence_Load(object sender, EventArgs e)
        {
            LOAD_INVOICE();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOAD_INVOICE();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
