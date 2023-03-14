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
    
    public partial class detailpumpForm : Form4
    {
        detailpumpDataClasses1DataContext d = new detailpumpDataClasses1DataContext();
        public detailpumpForm()
        {
            InitializeComponent();
        }

        private void detailpumpForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = d.tblpetroldetails.ToList();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Petrolium Station Name OR Account Number OR Branch Name ....!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection((DecHelper.ConnectionString)))
                {

                    string str = "Select * FROM [Albbasitcorporation].[dbo].[tblpetroldetail] WHERE [Station Name] LIKE '%" + textBox1.Text + "%' OR [Owner Name]LIKE '%" + textBox1.Text + "%' OR [Account No] LIKE '%" + textBox1.Text + "%' OR [Adress] LIKE '%" + textBox1.Text + "%'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text =string.Empty;
            }
        }
    }
}
