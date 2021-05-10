using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManagmentFINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string SellerName = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            UsernameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UsernameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter a Username and password");
            }
            else
            {
                if (RoleComboBox.SelectedIndex > -1)
                {
                    if (RoleComboBox.SelectedItem.ToString() == "ADMIN")
                    {
                        if (UsernameTb.Text == "Admin" && PasswordTb.Text == "Admin")
                        {
                            ProductForm productForm = new ProductForm();
                            productForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Inccorect Admin Passoword");
                        }

                    }
                    else if (RoleComboBox.SelectedItem.ToString() == "SELLER")
                    {
                        if (UsernameTb.Text == "Seller" && PasswordTb.Text == "Seller")
                        {
                            Selling sellingForm = new Selling();
                            sellingForm.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select A Role");
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
