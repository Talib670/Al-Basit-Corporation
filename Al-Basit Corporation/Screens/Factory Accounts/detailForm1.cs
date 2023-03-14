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
namespace Al_Basit_Corporation.Screens.Factory_Accounts
{
    public partial class detailForm1 : Form4
    {
        detailfactoryDataClasses1DataContext df = new detailfactoryDataClasses1DataContext();
        public detailForm1()
        {
            InitializeComponent();
        }

        private void detailForm1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = df.tblfactorydetails.ToList();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Industry Name OR Owner Name OR Address ....!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection((DecHelper.ConnectionString)))
                {

                    string str = "Select * FROM [Albbasitcorporation].[dbo].[tblfactorydetail] WHERE [Industry Name] LIKE '%" + textBox1.Text + "%' OR [Owner Name] LIKE '%" + textBox1.Text + "%' OR [Account No] LIKE '%" + textBox1.Text + "%' OR [Adress] LIKE '%" + textBox1.Text + "%'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = string.Empty; ;
            }
        }
    }
}
