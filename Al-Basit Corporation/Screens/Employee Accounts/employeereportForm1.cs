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
namespace Al_Basit_Corporation.Screens.Employee_Accounts
{
    public partial class employeereportForm1 : Form4
    {
        employeeDataClasses1DataContext ed = new employeeDataClasses1DataContext();
        public employeereportForm1()
        {
            InitializeComponent();
        }

        private void employeereportForm1_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = ed.tblemployees.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Employee Name OR bqaya Amount OR Jumma Amount ....!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection((DecHelper.ConnectionString)))
                {

                    string str = "Select * FROM [Albbasitcorporation].[dbo].[tblemployee] WHERE [Employee Name] LIKE '%" + textBox1.Text + "%' OR [Date] LIKE '%" + textBox1.Text + "%' OR [Details] LIKE '%" + textBox1.Text + "%' OR [Name Amount] LIKE '%" + textBox1.Text + "%' OR [Jumma Amount] LIKE '%" + textBox1.Text + "%' OR [Bqaya Amount] LIKE '%" + textBox1.Text + "%'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView2.DataSource = new BindingSource(dt, null);
                }
                textBox1.Text = " ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                using (SqlConnection con = new SqlConnection((DecHelper.ConnectionString)))
                {

                    string str = "Select * FROM [Albbasitcorporation].[dbo].[tblemployee] WHERE [Employee Name] LIKE '%" + textBox1.Text + "%' OR [Date] LIKE '%" + textBox1.Text + "%' OR [Details] LIKE '%" + textBox1.Text + "%' OR [Name Amount] LIKE '%" + textBox1.Text + "%' OR [Jumma Amount] LIKE '%" + textBox1.Text + "%' OR [Bqaya Amount] LIKE '%" + textBox1.Text + "%'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView2.DataSource = new BindingSource(dt, null);
                }
            }
    }
}
}
