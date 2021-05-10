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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        //Connection to the database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AJ Goranson\FINAL PROJECT\SuperMarketManagmentFINAL\SuperMarketManagmentFINAL\HorizonsClothesDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void fillcombobox()
        {
            //This method will fill the combo box with the database from the cateogorys.
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            CatComboBox.ValueMember = "CatName";
            CatComboBox.DataSource = dt;
            Con.Close();
        }
        private void populate()
        {
            //Create a method to load up the database items into the dataset grid when the application loads
            Con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombobox();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pressing the seller button will open the seller form 
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selling selling = new Selling();
            selling.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pressing the categories button on the side of the app will open the form
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Putting the information in the text boxes into the database with message  boxes and error handling
            try
            {
                Con.Open();
                string query = "insert into ProductTbl values(" + ProdIdTb.Text + ",'" + ProdNameTb.Text + "','" + ProdQtyTb.Text + "', '" + ProdPriceTb.Text + "', '" + CatComboBox.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                Con.Close();
                populate();
                ProdIdTb.Text = "";
                ProdNameTb.Text = "";
                ProdPriceTb.Text = "";
                ProdQtyTb.Text = "";
                ProdIdTb.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                // Setting up the edit button
                try
                {
                    if (ProdIdTb.Text == "" || ProdNameTb.Text == "" || ProdQtyTb.Text == "" || ProdPriceTb.Text == "")
                    {
                        MessageBox.Show("Please select an item in the DataGrid");

                    }
                    else
                    {
                        Con.Open();
                        string query = "update ProductTbl set ProdName='" + ProdNameTb.Text + "',ProdQty='" + ProdQtyTb.Text + "', ProdPrice='" + ProdPriceTb + "', ProdCat='" + CatComboBox.SelectedValue.ToString() + "'  where ProdId=" + ProdIdTb.Text + ";";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product updated Successfully");
                        Con.Close();
                        populate();
                        ProdIdTb.Text = "";
                        ProdNameTb.Text = "";
                        ProdPriceTb.Text = "";
                        ProdQtyTb.Text = "";
                        ProdIdTb.Focus();

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
                if (ProdIdTb.Text == "")
                {
                    MessageBox.Show("Select the Category to delete");

                }
                else
                {
                    Con.Open();
                    string query = "delete from ProductTbl where ProdId=" + ProdIdTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    populate();
                    ProdIdTb.Text = "";
                    ProdNameTb.Text = "";
                    ProdPriceTb.Text = "";
                    ProdQtyTb.Text = "";
                    ProdIdTb.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Make it so when you select something in the DGV that it shows up in the Text Boxes for easy editing 
            ProdIdTb.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTb.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ProdQtyTb.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString(); 
            ProdPriceTb.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            CatComboBox.SelectedValue = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void LogOutLbl_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
    }
    

