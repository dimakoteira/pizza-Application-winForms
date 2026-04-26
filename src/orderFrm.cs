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
    public partial class orderFrm : Form
    {
        public orderFrm()
        {
            InitializeComponent();
        }
        double basePrice = 0;
        double toppings = 0;
        double crust = 0;
        double size = 0;
        string sizeName, crustName, place;
        List<string> selectedToppings = new List<string>();
        bool isReset = false;

        public void writePrice()
        {
          basePrice= size + crust + toppings;
            priceTb.Text = basePrice.ToString("C");
        }
        private void size_changed(object sender, EventArgs e)
        {
            if (isReset) return; // prevent price update during reset
            RadioButton rb= sender as RadioButton;
            if (rb.Checked)
            {
                size= Convert.ToDouble(rb.Tag);
                sizeName = rb.Text;
            }
          writePrice();
        }

        private void place_changed(object sender, EventArgs e)
        {
            if (isReset) return; // prevent price update during reset

            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                place = rb.Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            summery frm = new summery(sizeName, crustName, place, selectedToppings,basePrice);
            frm.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isReset = true;
            //reset all selections and price
            size = 0;
            crust = 0;
            toppings = 0;
            sizeName = "";
            crustName = "";
            place = "";
            selectedToppings.Clear();
            //reset UI controls
            rbSmall.Checked = false;
            rbMedium.Checked = false;
            rbLarge.Checked = false;
            rbThin.Checked = false;
            rbThick.Checked = false;
            rbIn.Checked = false;
            radioButton6.Checked = false;
            ckbCheese.Checked = false;
            ckbPepper.Checked = false;
            ckbOlives.Checked = false;
            ckbOnion.Checked = false;
            ckbMush.Checked = false;
            ckbTomato.Checked = false;  
            priceTb.Text = "$0.00";
            isReset = false; // allow price updates again

        }

        private void crust_changed(object sender, EventArgs e)
        {
            if (isReset) return; // prevent price update during reset
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                crust = Convert.ToDouble(rb.Tag);
                crustName = rb.Text;
            }
            writePrice();
        }

        private void topping_changed(object sender, EventArgs e)
        {
            if (isReset) return; // prevent price update during reset
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                toppings += Convert.ToDouble(cb.Tag);
                selectedToppings.Add(cb.Text);
            }
            else
            {
                toppings -= Convert.ToDouble(cb.Tag);
                selectedToppings.Remove(cb.Text);
            }
            writePrice();
        }
    }
}
