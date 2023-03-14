using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Al_Basit_Corporation.Models;
namespace Al_Basit_Corporation.Screens.Investres
{
    public partial class newinvesterForm1 : defaultForm
    {
        investerdetailDataClassesDataContext d = new investerdetailDataClassesDataContext();
        investerbqayaDataClassesDataContext da = new investerbqayaDataClassesDataContext();
        public newinvesterForm1()
        {
            InitializeComponent();
        }

        private void newinvesterForm1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            detailinvesterForm1 df = new detailinvesterForm1();
            
            df.ShowDialog();
        }

        private void newRecordtoolStripButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                tblinvsterdetail t = new tblinvsterdetail();
                t.Name = clientnametextBox.Text;
                t.Father_Name = fnametextBox2.Text;
                t.CNIC = cnictextBox.Text;
                t.Account_No = actextBox1.Text;
                t.Adress = adressrichTextBox1.Text;
                t.Phone_No = phonetextBox1.Text;
                d.tblinvsterdetails.InsertOnSubmit(t);
                d.SubmitChanges();
                MessageBox.Show("New Client Account Created SuccessFully...!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                {

                    investerbqayaamount s = new investerbqayaamount();
                    s.nameinvester= clientnametextBox.Text;
                    s.bqayaamount = "0";
                    da.investerbqayaamounts.InsertOnSubmit(s);
                    da.SubmitChanges();
                }
            }
        }
        private bool IsFormValid()
        {
            {
                if (clientnametextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Invester Name is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clientnametextBox.Focus();
                    return false;
                }
                if (adressrichTextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Invester Address is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adressrichTextBox1.Focus();
                    return false;
                }
                if (cnictextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Invester cnic is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cnictextBox.Focus();
                    return false;
                }
                if (fnametextBox2.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Invester Father Name is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fnametextBox2.Focus();
                    return false;
                }
                if (phonetextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Invester Phone Number is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phonetextBox1.Focus();
                    return false;
                }
                return true;
            }
        }

        private void closetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
