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
    public partial class Form1 : Form
    {
        private Form currentForm;

        private void ShowChildForm(Form ChildForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            Main_form.Controls.Add(ChildForm);
            ChildForm.Show();
            ChildForm.BringToFront();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowChildForm(new form_buy("Most Popular",false));
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ShowChildForm(new form_buy("Groceries"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowChildForm(new form_cart());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowChildForm(new Form_Innovence());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowChildForm(new About());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_form_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
