using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_Application
{
    public partial class summery : Form
    {
        public summery(string size, string crust, string place, List<string> toppings, double price)
        {
           
            InitializeComponent();
            sLabel.Text += size;
            cLabel.Text += crust;
            wLabel.Text += place;
            pLabel.Text = price.ToString("C");
            foreach (string topping in toppings)
            {
                tLabel.Text += topping + ", \n";
            }
        }

        private void summery_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your order!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.None);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderFrm frm = new orderFrm();
            frm.Show();
            this.Hide();
        }
    }
}
