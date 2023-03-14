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

namespace Al_Basit_Corporation.Screens.Genral_Purchase
{
    public partial class reportsForm : Form4
    {
        genralpurchaseDataClasses1DataContext gd = new genralpurchaseDataClasses1DataContext();
        public reportsForm()
        {
            InitializeComponent();
        }

        private void reportsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = gd.GenralPurchases.ToList();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Products  Name OR bqaya Amount OR Jumma Amount ....!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection((DecHelper.ConnectionString)))
                {

                    string str = "Select * FROM [Albbasitcorporation].[dbo].[GenralPurchase] WHERE [Date] LIKE '%" + textBox1.Text + "%' OR [Details] LIKE '%" + textBox1.Text + "%' OR [Name Amount] LIKE '%" + textBox1.Text + "%' OR [Jumma Amount] LIKE '%" + textBox1.Text + "%' OR [Baqaya Amount] LIKE '%" + textBox1.Text + "%'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = string.Empty;
            }
        }
    }
}
