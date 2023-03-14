using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Al_Basit_Corporation.Models;

namespace Al_Basit_Corporation.Screens.Purchase_Account
{
    public partial class TotalpurchaseForm1 : Form4
    {
       productDataClasses1DataContext b = new productDataClasses1DataContext();
        public TotalpurchaseForm1()
        {
            InitializeComponent();
        }

        private void TotalpurchaseForm1_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = b.tblproducts.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Products  Name OR bqaya Amount OR Jumma Amount ....!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection((DecHelper.ConnectionString)))
                {

                    string str = "Select * FROM [Albbasitcorporation].[dbo].[tblproduct] WHERE [Date] LIKE '%" + textBox1.Text + "%' OR [Product Name] LIKE '%" + textBox1.Text + "%' OR [Products Details] LIKE '%" + textBox1.Text + "%' OR [Name Amount] LIKE '%" + textBox1.Text + "%' OR [Jumma Amount] LIKE '%" + textBox1.Text + "%' OR [Bqaya Amount] LIKE '%" + textBox1.Text + "%'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView2.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = string.Empty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection((DecHelper.ConnectionString)))
            {

                string str = "Select * FROM [Albbasitcorporation].[dbo].[tblproduct] WHERE [Date] LIKE '%" + textBox1.Text + "%' OR [Product Name] LIKE '%" + textBox1.Text + "%' OR [Products Details] LIKE '%" + textBox1.Text + "%' OR [Name Amount] LIKE '%" + textBox1.Text + "%' OR [Jumma Amount] LIKE '%" + textBox1.Text + "%' OR [Bqaya Amount] LIKE '%" + textBox1.Text + "%'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
