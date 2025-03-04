using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float CalculateTotalPrice()
        {
            float totalPrice = 0;

            //size
            if (rdBtnSmall.Checked)
            {
                totalPrice += Convert.ToSingle(rdBtnSmall.Tag);
            }
            else if (rdBtnMedium.Checked)
            {
                totalPrice += Convert.ToSingle(rdBtnMedium.Tag);
            }
            else if (rdBtnLarge.Checked)
            {
                totalPrice += Convert.ToSingle(rdBtnLarge.Tag);
            }

            //crust type
            if (rdBtnThinCrust.Checked)
            {
                totalPrice += Convert.ToSingle(rdBtnThinCrust.Tag);
            }
            else if (rdBtnThinkCrust.Checked)
            {
                totalPrice += Convert.ToSingle(rdBtnThinkCrust.Tag);
            }

            //toppings
            if (chkBoxExtraCheese.Checked)
            {
                totalPrice += Convert.ToSingle(chkBoxExtraCheese.Tag);
            }
            if (chkBoxOnion.Checked)
            {
                totalPrice += Convert.ToSingle(chkBoxOnion.Tag);
            }
            if (chkBoxMushrooms.Checked)
            {
                totalPrice += Convert.ToSingle(chkBoxMushrooms.Tag);
            }
            if (chkBoxOlives.Checked)
            {
                totalPrice += Convert.ToSingle(chkBoxOlives.Tag);
            }
            if (chkBoxTomatoes.Checked)
            {
                totalPrice += Convert.ToSingle(chkBoxTomatoes.Tag);
            }
            if (chkBoxGreenPeppers.Checked)
            {
                totalPrice += Convert.ToSingle(chkBoxGreenPeppers.Tag);
            }

            return totalPrice;
        }
        void UpdateTotalPrice()
        {
            LabelTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rdBtnSmall.Checked)
            {
                LabelSize.Text = "Small";
            }
            else if (rdBtnMedium.Checked)
            {
                LabelSize.Text = "Medium";
            }
            else if (rdBtnLarge.Checked)
            {
                LabelSize.Text = "Large";
            }
        }

        void UpdateCrustType()
        {
            UpdateTotalPrice();
            if (rdBtnThinCrust.Checked)
            {
                LabelCrustType.Text = "Thin Crust";
            }
            else if (rdBtnThinkCrust.Checked)
            {
                LabelCrustType.Text = "Thick Crust";
            }
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();
            if (rdBtnEatIn.Checked)
            {
                LabelWhereToEat.Text = "Eat In";
            }
            else if (rdBtnTakeOut.Checked)
            {
                LabelWhereToEat.Text = "Take Out";
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            LabelToppings.Text = "";

            if(chkBoxExtraCheese.Checked)
            {
                LabelToppings.Text += "Extra Cheese, ";
            }

            if (chkBoxOnion.Checked)
            {
                LabelToppings.Text += "Onion, ";
            }

            if (chkBoxMushrooms.Checked)
            {
                LabelToppings.Text += "Mushrooms, ";
            }

            if (chkBoxOlives.Checked)
            {
                LabelToppings.Text += "Olives, ";
            }

            if (chkBoxTomatoes.Checked)
            {
                LabelToppings.Text += "Tomatoes, ";
            }

            if (chkBoxGreenPeppers.Checked)
            {
                LabelToppings.Text += "Green Peppers, ";
            }

            if (LabelToppings.Text.Length > 0)
            {
                LabelToppings.Text = LabelToppings.Text.Substring(0, LabelToppings.Text.Length - 2);
            }  

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateCrustType();
            UpdateSize();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        private void rdBtnSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void BtnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                BtnOrderPizza.Enabled = false;
                GBoxCrustType.Enabled = false;
                GBoxToppings.Enabled = false;
                GBoxSize.Enabled = false;
                GBoxWhereToEat.Enabled = false;
            }
        }

        private void BtnResetForm_Click(object sender, EventArgs e)
        {
            BtnOrderPizza.Enabled = true;
            GBoxCrustType.Enabled = true;
            GBoxToppings.Enabled = true;
            GBoxSize.Enabled = true;
            GBoxWhereToEat.Enabled = true;
        }

        private void rdBtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdBtnLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdBtnThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rdBtnThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rdBtnEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rdBtnTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chkBoxExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void LabelToppings_Click(object sender, EventArgs e)
        {

        }
    }
}
