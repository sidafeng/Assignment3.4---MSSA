using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Assignment3._4
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            btnBack.Visible = false;
            ckListBox.Visible = false;
            lblSize.Visible = false;
            rbtnLarge.Visible = false;
            rbtnSmall.Visible = false;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            listBox.DataSource = null;

        }

        private void rbtnCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCoffee.Checked)
            {
                listBox.DataSource = Enum.GetValues(typeof(CoffeeType));
                ckListBox.Items.Clear();
                ckListBox.Items.Add("Milk");
                ckListBox.Items.Add("Sugar");
            }
            else if (rbtnTea.Checked)
            {
                btnNext.Text = "Next";
                listBox.Visible = true;
                btnBack.Visible = false;
                ckListBox.Visible = false;
                lblSize.Visible = false;
                rbtnLarge.Visible = false;
                rbtnSmall.Visible = false;
                listBox.DataSource = Enum.GetValues(typeof(CoffeeType));
                ckListBox.Items.Clear();
                ckListBox.Items.Add("Lemon");
                ckListBox.Items.Add("Honey");
                

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTea.Checked)
            {
                listBox.DataSource = Enum.GetValues(typeof(TeaType));
                ckListBox.Items.Clear();
                ckListBox.Items.Add("Lemon");
                ckListBox.Items.Add("Honey");
            }
            else if (rbtnCoffee.Checked)
            {
                btnNext.Text = "Next";
                listBox.Visible = true;
                btnBack.Visible = false;
                ckListBox.Visible = false;
                lblSize.Visible = false;
                rbtnLarge.Visible = false;
                rbtnSmall.Visible = false;
                listBox.DataSource = Enum.GetValues(typeof(TeaType));
                ckListBox.Items.Clear();
                ckListBox.Items.Add("Milk");
                ckListBox.Items.Add("Sugar");
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {



            if (btnNext.Text == "Next" && (rbtnCoffee.Checked || rbtnTea.Checked))
            {
                listBox.Visible = false;
                btnBack.Visible = true;
                ckListBox.Visible = true;
                lblSize.Visible = true;
                rbtnLarge.Visible = true;
                rbtnSmall.Visible = true;

                btnNext.Text = "Submit";
            }
            else if (btnNext.Text == "Submit" && (rbtnCoffee.Checked || rbtnTea.Checked) && (rbtnSmall.Checked || rbtnLarge.Checked))
            {


                if (rbtnCoffee.Checked)
                {
                    CoffeeOrder coffee = new CoffeeOrder();
                    coffee.coffeeType = (CoffeeType)listBox.SelectedItem;
                    coffee.beverage = Beverage.Coffee;
                    coffee.beverageType = listBox.SelectedItem.ToString();

                    coffee.size = rbtnSmall.Checked ? Assignment3._4.Size.Small : Assignment3._4.Size.Large;



                    //I don't like this part of the code, down below, it bypasses coffee.milk and sugar

                    if (ckListBox.GetItemChecked(0))
                    {
                        coffee.addOn1 = ckListBox.Items[0].ToString();
                    }
                    else
                    {
                        coffee.addOn1 = "";
                    }
                    if (ckListBox.GetItemChecked(1))
                    {
                        coffee.addOn2 = ckListBox.Items[1].ToString();
                    }
                    else
                    {
                        coffee.addOn2 = "";
                    }

                    PersonalInfoForm pForm = new PersonalInfoForm(coffee);
                    this.Hide();
                    pForm.ShowDialog();
                    this.Close();
                }
                else if (rbtnTea.Checked)
                {
                    TeaOrder tea = new TeaOrder();
                    tea.beverage = Beverage.Tea;
                    tea.teaType = (TeaType)listBox.SelectedItem;
                    tea.beverageType = listBox.SelectedItem.ToString();
                    tea.lemon = ckListBox.GetItemChecked(0);
                    tea.honey = ckListBox.GetItemChecked(1);
                    tea.size = rbtnSmall.Checked ? Assignment3._4.Size.Small : Assignment3._4.Size.Large;

                    if (tea.lemon)
                    {
                        tea.addOn1 = ckListBox.Items[0].ToString();
                    }
                    else
                    {
                        tea.addOn1 = "";
                    }
                    if (tea.honey)
                    {
                        tea.addOn2 = ckListBox.Items[1].ToString();
                    }
                    else
                    {
                        tea.addOn2 = "";
                    }


                    PersonalInfoForm pForm = new PersonalInfoForm(tea);
                        this.Hide();
                        pForm.ShowDialog();
                        this.Close();
                    
                }

            }
            else
            {
                MessageBox.Show("Please complete the order");
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnNext.Text = "Next";
            listBox.Visible = true;
            btnBack.Visible = false;
            ckListBox.Visible = false;
            lblSize.Visible = false;
            rbtnLarge.Visible = false;
            rbtnSmall.Visible = false;
        }

    }
}
