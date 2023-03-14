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

namespace Al_Basit_Corporation.Screens.Factory_Accounts
{
    public partial class newfactoryForm1 : Form4
    {
        bqayafactryDataClasses1DataContext bf = new bqayafactryDataClasses1DataContext();
        detailfactoryDataClasses1DataContext df = new detailfactoryDataClasses1DataContext();
        public newfactoryForm1()
        {
            InitializeComponent();
        }

        private void newfactoryForm1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            detailForm1 df = new detailForm1();
            df.ShowDialog();
        }

        private void closetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newRecordtoolStripButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                tblfactorydetail t = new tblfactorydetail();
                t.Industry_Name = banknametextBox.Text;
                t.Owner_Name = branchnametextBox2.Text;
                t.Account_No = actextBox1.Text;
              


                t.Adress = adressrichTextBox1.Text;

                df.tblfactorydetails.InsertOnSubmit(t);
                df.SubmitChanges();
                MessageBox.Show("New Industry Account Created SuccessFully...!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                {

                   factorybqayaamount s = new factorybqayaamount();
                    s.namefactory = banknametextBox.Text;
                    s.bqayaamount = "0";
                    bf.factorybqayaamounts.InsertOnSubmit(s);
                    bf.SubmitChanges();
                }
            }
        }
        private bool IsFormValid()
        {
            {
                if (banknametextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Industry  Name is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    banknametextBox.Focus();
                    return false;
                }
                if (adressrichTextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Industry  Address is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adressrichTextBox1.Focus();
                    return false;
                }

                if (branchnametextBox2.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Owner Name is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    branchnametextBox2.Focus();
                    return false;
                }
                if (actextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Industry Account Number is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    actextBox1.Focus();
                    return false;
                }
               
                return true;
            }
        }
    }
}
