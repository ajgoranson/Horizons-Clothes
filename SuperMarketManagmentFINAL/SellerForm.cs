using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarketManagmentFINAL
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AJ Goranson\FINAL PROJECT\SuperMarketManagmentFINAL\SuperMarketManagmentFINAL\HorizonsClothesDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            //Create a method to load up the database items into the dataset grid when the application loads
            Con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellDVG.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pressing the categories button on the side of the app will open the form
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pressing the product button will open the product page
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Setting up the edit button
            try
            {
                if (SellIdTb.Text == "" || SellNameTb.Text == "" || SellAgeTb.Text == "" || SellPhoneTb.Text == "" || SellPassTb.Text == "")
                {
                    MessageBox.Show("Please select an item in the DataGrid");

                }
                else
                {
                    Con.Open();
                    string query = "update SellerTbl set SellerName='" + SellNameTb.Text + "',SellerAge='" + SellAgeTb.Text + "',SellerPhone='" + SellPhoneTb.Text + "',SellerPass='" + SellPassTb.Text  + "' where SellerId=" + SellIdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller updated Successfully");
                    Con.Close();
                    populate();
                    SellIdTb.Text = "";
                    SellNameTb.Text = "";
                    SellAgeTb.Text = "";
                    SellPhoneTb.Text = "";
                    SellPassTb.Text = "";
                    SellIdTb.Focus();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // delete from the database and update the DVG
            try
            {
                if (SellIdTb.Text == "")
                {
                    MessageBox.Show("Select the Seller to delete");

                }
                else
                {
                    Con.Open();
                    string query = "delete from SelllerTbl where SellerId=" + SellIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    Con.Close();
                    populate();
                    SellIdTb.Text = "";
                    SellNameTb.Text = "";
                    SellAgeTb.Text = "";
                    SellPhoneTb.Text = "";
                    SellPassTb.Text = "";
                    SellIdTb.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Putting the information in the text boxes into the database with message  boxes and error handling
            try
            {
                Con.Open();
                string query = "insert into SellerTbl values(" + SellIdTb.Text + ",'" + SellNameTb.Text + "','" + SellAgeTb.Text + "', '" + SellPhoneTb.Text + "', '" + SellPassTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                Con.Close();
                populate();
                SellIdTb.Text = "";
                SellNameTb.Text = "";
                SellAgeTb.Text = "";
                SellPhoneTb.Text = "";
                SellPassTb.Text = "";
                SellIdTb.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selling selling = new Selling();
            selling.Show();
            this.Hide();
        }

        private void LogOutLbl_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
