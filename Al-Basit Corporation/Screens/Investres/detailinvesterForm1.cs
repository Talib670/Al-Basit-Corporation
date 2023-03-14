using Al_Basit_Corporation.Models;
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

namespace Al_Basit_Corporation.Screens.Investres
{
    public partial class detailinvesterForm1 : Form

    {
        investerdetailDataClassesDataContext id = new investerdetailDataClassesDataContext();
        public detailinvesterForm1()
        {
            InitializeComponent();
        }

        private void detailinvesterForm1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = id.tblinvsterdetails.ToList();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                MessageBox.Show("Please Enter Valid Invester Name OR Phone Number OR Father Name ....!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection((DecHelper.ConnectionString)))
                {

                    string str = "Select * FROM [Albbasitcorporation].[dbo].[tblinvsterdetail] WHERE [Name] LIKE '%" + textBox1.Text + "%' OR [Father Name] LIKE '%" + textBox1.Text + "%' OR [CNIC] LIKE '%" + textBox1.Text + "%' OR [Phone No] LIKE '%" + textBox1.Text + "%'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = "";
            }
        }
    }
}
