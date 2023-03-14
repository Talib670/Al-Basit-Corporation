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
namespace Al_Basit_Corporation.Screens.Petrol_Pump_Accounts
{
    public partial class pumpreportForm1 : Form4
    {
        petrolDataClasses1DataContext pd = new petrolDataClasses1DataContext();
        public pumpreportForm1()
        {
            InitializeComponent();
        }

        private void pumpreportForm1_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = pd.tblpetrols.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Petrolium Station Name OR bqaya Amount OR Jumma Amount ....!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection((DecHelper.ConnectionString)))
                {

                    string str = "Select * FROM [Albbasitcorporation].[dbo].[tblpetrol] WHERE [Station Name] LIKE '%" + textBox1.Text + "%' OR  [Date] LIKE '%" + textBox1.Text + "%' OR [Name Amount] LIKE '%" + textBox1.Text + "%' OR [Jumma Amount] LIKE '%" + textBox1.Text + "%' OR [Bqaya Amount] LIKE '%" + textBox1.Text + "%'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView2.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = string.Empty;
            }
        }
    }
}
