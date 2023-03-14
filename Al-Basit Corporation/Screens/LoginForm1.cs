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

namespace Al_Basit_Corporation.Screens
{
    public partial class LoginForm1 : Form4
    {
        public LoginForm1()
        {
            InitializeComponent();
        }

        private void LoginForm1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        public static string username;
        public static string recby
        {
            get { return username; }
            set { username = value; }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (isformvalid())
            {



                SqlCommand cmd = new SqlCommand("SELECT * FROM [Albbasitcorporation].[dbo].[tblLogin] WHERE [User Name]=@username AND [Password]=@password;", new SqlConnection(DecHelper.ConnectionString));
                cmd.Parameters.AddWithValue("@username", usernametextBox.Text.ToString());

                cmd.Parameters.AddWithValue("@password", passtextBox.Text.ToString());
                cmd.Connection.Open();
                using (cmd.Connection)
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        recby = usernametextBox.Text;
                        this.Hide();
                        DashboaredForm1 d = new DashboaredForm1();
                        d.Show();
                    }
                    else
                    {

                        MessageBox.Show("UserName/Password is incorrect..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }

            bool isformvalid()
            {
                if (usernametextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("User Name is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernametextBox.Clear();
                    usernametextBox.Focus();
                    return false;
                }
                if (passtextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Password is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernametextBox.Clear();
                    usernametextBox.Focus();
                    return false;
                }
                return true;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                passtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passtextBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                button2.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
