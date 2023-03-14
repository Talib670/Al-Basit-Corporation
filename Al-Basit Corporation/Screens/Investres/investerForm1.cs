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
using Al_Basit_Corporation.Models;

namespace Al_Basit_Corporation.Screens.Investres
{
    public partial class investerForm1 : defaultForm
    {
        investerDataClasses1DataContext ad = new investerDataClasses1DataContext();
        public investerForm1()
        {
            InitializeComponent();
        }
        public static string NumberToWord(int numbers)
        {
            if (numbers == 0) return "Zero";
            if (numbers < 0) return "Minus" + NumberToWord(Math.Abs(numbers));
            string words = "";
            if ((numbers / 1000000) > 0)

            {
                words += NumberToWord(numbers / 1000000) + " Millions ";
                numbers %= 1000000;

            }
            if ((numbers / 100000) > 0)
            {
                words += NumberToWord(numbers / 100000) + " Lac ";
                numbers %= 100000;

            }
            if ((numbers / 1000) > 0)
            {
                words += NumberToWord(numbers / 1000) + " Thousands ";
                numbers %= 1000;

            }
            if ((numbers / 100) > 0)
            {
                words += NumberToWord(numbers / 100) + " Hundreds ";
                numbers %= 100;

            }
            if (numbers > 0)
            {
                if (words != "") words += " AND ";
                var unitsmap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen","Fourteen" ,"Fifteen", "Sixteen", "Seventeen", "Eighteen", "Ninteen" };
                var tenmap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
                if (numbers < 20) words += unitsmap[numbers];
                else
                {
                    words += tenmap[numbers / 10];
                    if ((numbers % 10) > 0) words += "-" + unitsmap[numbers % 10];

                }


            }
            return words;
        }
        private void investerForm1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            total.Visible = false;
            {
                grandtotal.Visible = false;
                SqlConnection conn = new SqlConnection(DecHelper.ConnectionString);
                conn.Open();
                string strr = "SELECT  * FROM [Albbasitcorporation].[dbo].[tblgrandtotal]  ";
                SqlCommand cmdd = new SqlCommand(strr, conn);
                SqlDataReader rdd = cmdd.ExecuteReader();
                while (rdd.Read())
                {
                    grandtotal.Text = rdd[1].ToString();

                    //txtbal.Text = "";
                    // textacno.Text = "";
                    // textuname.Text= "";
                    //   textnowbal.Visible = true;
                    // textacno.Focus();
                }
            }
            label5.Visible = false;
            {
                SqlConnection conn = new SqlConnection(DecHelper.ConnectionString);
                conn.Open();
                string str = "  Select * FROM [Albbasitcorporation].[dbo].[investerbqayaamount]";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    comboBox1.Items.Add(da[1].ToString());
                    //  purchasepricelabel.Text = da[6].ToString();
                }
            }

        }

        private void closetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            investerReportsForm1 af = new investerReportsForm1();
            af.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newinvesterForm1 af = new newinvesterForm1();
            af.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                SqlConnection conn = new SqlConnection(DecHelper.ConnectionString);
                conn.Open();
                string str = "  Select * FROM [Albbasitcorporation].[dbo].[investerbqayaamount] WHERE  [nameinvester]= '" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    label5.Text = da[2].ToString();
                    //  purchasepricelabel.Text = da[6].ToString();
                }
            }
        }

        private void newRecordtoolStripButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {

                {
                    SqlConnection conn = new SqlConnection(DecHelper.ConnectionString);
                    conn.Open();
                    //StudentB s = new StudentB();
                    //MemoryStream ms = new MemoryStream();
                    //i.Save(ms, ImageFormat.Jpeg);
                    //byte[] arrrrr = ms.ToArray();

                    string str = @" UPDATE [Albbasitcorporation].[dbo].[tblgrandtotal]
SET [Grand Total] = '" + total.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }


                tblinvester t = new tblinvester();
                t.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                t.Details = detailtextBox.Text;
                t.Name_Amount = nametextBox2.Text;
                t.Jumma_Amount = jummatextBox.Text;
                t.Bqaya_Amount = bqayatextBox1.Text;
                t.Invester_Name = comboBox1.Text;

                ad.tblinvesters.InsertOnSubmit(t);
                ad.SubmitChanges();
                MessageBox.Show("Invester Record Save SuccessFully...!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);


                {
                    SqlConnection conn = new SqlConnection(DecHelper.ConnectionString);
                    conn.Open();
                    //StudentB s = new StudentB();
                    //MemoryStream ms = new MemoryStream();
                    //i.Save(ms, ImageFormat.Jpeg);
                    //byte[] arrrrr = ms.ToArray();

                    string str = @" UPDATE [Albbasitcorporation].[dbo].[investerbqayaamount]
SET [bqayaamount]= '" + bqayatextBox1.Text + "'  WHERE [nameinvester] = '" + comboBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                }
                {
                    total.Visible = false;
                    {
                        grandtotal.Visible = false;
                        SqlConnection conn = new SqlConnection(DecHelper.ConnectionString);
                        conn.Open();
                        string strr = "SELECT  * FROM [Albbasitcorporation].[dbo].[tblgrandtotal]  ";
                        SqlCommand cmdd = new SqlCommand(strr, conn);
                        SqlDataReader rdd = cmdd.ExecuteReader();
                        while (rdd.Read())
                        {
                            grandtotal.Text = rdd[1].ToString();

                            //txtbal.Text = "";
                            // textacno.Text = "";
                            // textuname.Text= "";
                            //   textnowbal.Visible = true;
                            // textacno.Focus();
                        }
                    }
                    label5.Visible = false;
                    {
                        SqlConnection conn = new SqlConnection(DecHelper.ConnectionString);
                        conn.Open();
                        string str = "  Select * FROM [Albbasitcorporation].[dbo].[investerbqayaamount]";
                        SqlCommand cmd = new SqlCommand(str, conn);
                        SqlDataReader da = cmd.ExecuteReader();
                        while (da.Read())
                        {
                            comboBox1.Items.Add(da[1].ToString());
                            //  purchasepricelabel.Text = da[6].ToString();
                        }
                    }
                }
                this.Hide();
                investerForm1 i = new investerForm1();
                i.ShowDialog();


            }
        }
        private bool IsFormValid()
        {
            {
                if (detailtextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Comapany Details is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    detailtextBox.Focus();
                    return false;
                }
                if (nametextBox2.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Name Amount is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nametextBox2.Focus();
                    return false;
                }
                if (jummatextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("jumma Amount is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    jummatextBox.Focus();
                    return false;
                }
                if (bqayatextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Buqaya Amount is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bqayatextBox1.Focus();
                    return false;
                }
                return true;
            }
        }

        private void nametextBox2_TextChanged(object sender, EventArgs e)
        {

            try
            {

                if (nametextBox2.Text.Length > 0)
                {
                    wordlbl.Text = NumberToWord(Convert.ToInt32(nametextBox2.Text));
                    total.Text = (Convert.ToDouble(grandtotal.Text) + Convert.ToDouble(jummatextBox.Text) - Convert.ToDouble(nametextBox2.Text)).ToString();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please Select Digital Values as 123..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {


                if (nametextBox2.Text.Length > 0)
                {
                    bqayatextBox1.Text = (Convert.ToDecimal(label5.Text) + Convert.
                           ToDecimal(nametextBox2.Text)).ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please Select Digital Values as 123..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void jummatextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (jummatextBox.Text.Length > 0)
                {
                    wordlbl.Text = NumberToWord(Convert.ToInt32(jummatextBox.Text));
                    bqayatextBox1.Text = (Convert.ToDecimal(label5.Text) + Convert.
                           ToDecimal(nametextBox2.Text) - Convert.ToDecimal(jummatextBox.Text)).ToString();
                    total.Text = (Convert.ToDouble(grandtotal.Text) + Convert.ToDouble(jummatextBox.Text) - Convert.ToDouble(nametextBox2.Text)).ToString();


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please Select Digital Values as 123..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {


                if (jummatextBox.Text.Length > 0)
                {
                    bqayatextBox1.Text = (Convert.ToDecimal(label5.Text) - Convert.
                           ToDecimal(jummatextBox.Text)).ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please Select Digital Values as 123..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void investerForm1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                newRecordtoolStripButton.PerformClick();
            }
        }
    }
        }
