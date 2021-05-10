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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void populate()
        {
            //Create a method to load up the database items into the dataset grid when the application loads
            Con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        //Connection string to the database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AJ Goranson\FINAL PROJECT\SuperMarketManagmentFINAL\SuperMarketManagmentFINAL\HorizonsClothesDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button9_Click(object sender, EventArgs e)
        {
            //Putting the information in the text boxes into the database with message  boxes and error handling
            try
            {
                Con.Open();
                string query = "insert into CategoryTbl values(" + CatIdTb.Text + ",'" + CatNameTb.Text + "','" + CatDescTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                Con.Close();
                populate();
                CatNameTb.Text = "";
                CatDescTb.Text = "";
                CatIdTb.Text = "";
                CatIdTb.Focus();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Make it so when you select something in the DGV that it shows up in the Text Boxes for easy editing 
            CatIdTb.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            CatDescTb.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
            
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // delete from the database and update the DVG
            try
            {
                if (CatIdTb.Text == "")
                {
                    MessageBox.Show("Select the Category to delete");

                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTbl where CatId=" + CatIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    populate();
                    CatNameTb.Text = "";
                    CatDescTb.Text = "";
                    CatIdTb.Text = "";
                    CatIdTb.Focus();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Setting up the edit button
            try
            {
                if (CatIdTb.Text == "" || CatNameTb.Text =="" || CatDescTb.Text =="")
                {
                    MessageBox.Show("Please select an item in the DataGrid");

                }
                else
                {
                    Con.Open();
                    string query = "update CategoryTbl set CatName='" + CatNameTb.Text + "',CatDesc='" + CatDescTb.Text + "' where CatId=" + CatIdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category updated Successfully");
                    Con.Close();
                    populate();
                    CatNameTb.Text = "";
                    CatDescTb.Text = "";
                    CatIdTb.Text = "";
                    CatIdTb.Focus();

                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pressing the seller button will open the seller form 
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pressing the product button will open the product page
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
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
