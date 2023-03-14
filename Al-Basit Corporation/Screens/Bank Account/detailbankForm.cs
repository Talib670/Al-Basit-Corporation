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

namespace Al_Basit_Corporation.Screens.Bank_Account
{
    public partial class detailbankForm : Form4
    {
        bankdetailDataClassesDataContext b = new bankdetailDataClassesDataContext();
        public detailbankForm()
        {
            InitializeComponent();
        }

        private void detailbankForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = b.tblbankdetails.ToList();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Bank Name OR Account Number OR Branch Name ....!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection((DecHelper.ConnectionString)))
                {

                    string str = "Select * FROM [Albbasitcorporation].[dbo].[tblbankdetail] WHERE [Bank Name] LIKE '%" + textBox1.Text + "%' OR [Branch Name] LIKE '%" + textBox1.Text + "%' OR [Account No] LIKE '%" + textBox1.Text + "%' OR [Adress] LIKE '%" + textBox1.Text + "%'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = " ";
            }
        }
    }
}
