using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assignment3._4
{
    public partial class PersonalInfoForm : Form
    {
        private BeverageOrder order;
        public PersonalInfoForm()
        {
            InitializeComponent();
        }

        public PersonalInfoForm(BeverageOrder order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            char[] c = (txtName.Text).ToCharArray();
            foreach (char ch in c)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Please enter letters only");
                    e.Cancel = true;
                    txtName.Clear();
                    break;
                }
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtPhone.Text, @"^[\d -]+$"))
            {
                MessageBox.Show("Please enter a valid phone number");
                e.Cancel = true;
                txtPhone.Clear();
            }
        }

        private void btnPaySubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtPhone.Text != string.Empty && (rbtnCard.Checked || rbtnCash.Checked)) { 
                order.name = txtName.Text;
                order.phoneNumber = txtPhone.Text;
                order.orderID = Data.orderID++;
                Data.orders.Add(order);
                MessageBox.Show("Order and Payment Successful!");
                this.Close();
            } else
            {
                MessageBox.Show("Please fill in all the fields to check out.");
            }
        }
    }
}
