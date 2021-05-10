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
    public partial class Selling : Form
    {
        public Selling()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AJ Goranson\FINAL PROJECT\SuperMarketManagmentFINAL\SuperMarketManagmentFINAL\HorizonsClothesDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            //Create a method to load up the database items into the dataset grid when the application loads
            Con.Open();
            string query = "select ProdName,ProdQty,ProdPrice from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDVG.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void populateSales()
        {
            //Create a method to load up the database items into the dataset grid when the application loads
            Con.Open();
            string query = "select * from TotalSales";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TotalSalesDVG.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Selling_Load(object sender, EventArgs e)
        {
            populate();
            populateSales();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Hitting the X button in the top right
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pressing the product button will open the product page
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pressing the categories button on the side of the app will open the form
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //pressing the seller button will open the seller form 
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }

        private void ProdDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //clicking on something in the DVG will allow it to fill the Textboxes
            ProdNameTb1.Text = ProdDVG.SelectedRows[0].Cells[0].Value.ToString();
            ProdQtyTb1.Text = ProdDVG.SelectedRows[0].Cells[1].Value.ToString();
            ProdPriceTb1.Text = ProdDVG.SelectedRows[0].Cells[2].Value.ToString();
        }
        double FinalTotal = 0;
        private void button4_Click(object sender, EventArgs e)
        {

            //Take the information from the Textboxes and put them into the DVG, (THIS WAS HARD SINCE IT HAS NO DATABASE)
            int n = 0;
            double total = Convert.ToDouble(ProdPriceTb1.Text) * Convert.ToInt32(ProdQtyTb1.Text);
            if (ProdNameTb1.Text == "" || ProdQtyTb1.Text == "" || ProdPriceTb1.Text == "")
            {
                MessageBox.Show("Need to put in more data");
            }
            else
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(OrderDVG);

                dataGridViewRow.Cells[0].Value = ProdNameTb1.Text.ToString();
                dataGridViewRow.Cells[1].Value = ProdPriceTb1.Text.ToString();
                dataGridViewRow.Cells[2].Value = ProdQtyTb1.Text.ToString();
                dataGridViewRow.Cells[3].Value = Convert.ToDouble(ProdPriceTb1.Text) * Convert.ToInt32(ProdQtyTb1.Text);
                OrderDVG.Rows.Add(dataGridViewRow);
                FinalTotal += total;
                FinalTotallbl.Text = "" + FinalTotal;
                BillIdTb.Text = "";
                ProdNameTb1.Text = "";
                ProdPriceTb1.Text = "";
                ProdQtyTb1.Text = "";
                BillIdTb.Focus();
            }
        }

        private void OrderDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Accident and cant delete cause it will crash 

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Adding into the total sales
            
            Con.Open();
            string query = "insert into TotalSales values(" + BillIdTb.Text + ", '" + SellerNamelbl.Text + "', '" + FinalTotallbl.Text + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Category Added Successfully");
            Con.Close();
            populate();
            BillIdTb.Text = "";
            ProdNameTb1.Text = "";
            ProdPriceTb1.Text = "";
            ProdQtyTb1.Text = "";
            BillIdTb.Focus();

        }

        private void LogOutLbl_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
