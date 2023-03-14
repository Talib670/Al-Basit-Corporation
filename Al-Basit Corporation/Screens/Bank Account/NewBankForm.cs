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

namespace Al_Basit_Corporation.Screens.Bank_Account
{
    public partial class NewBankForm :defaultForm
    {
        bankdetailDataClassesDataContext b = new bankdetailDataClassesDataContext();
        bankbqayaDataClasses1DataContext d = new bankbqayaDataClasses1DataContext();
        public NewBankForm()
        {
            InitializeComponent();
        }

        private void NewBankForm_Load(object sender, EventArgs e)
        {

        }

        private void closetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newRecordtoolStripButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                tblbankdetail t = new tblbankdetail();
                t.Bank_Name = banknametextBox.Text;
                t.Branch_Name = branchnametextBox2.Text;
                t.Account_No = actextBox1.Text;
               
                t.Adress = adressrichTextBox1.Text;
              
                b.tblbankdetails.InsertOnSubmit(t);
                b.SubmitChanges();
                MessageBox.Show("New Bank Account Created SuccessFully...!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                {

                   bankbqayaamount  s = new bankbqayaamount();
                    s.namebank = banknametextBox.Text;
                    s.bqayaamount = "0";
                    d.bankbqayaamounts.InsertOnSubmit(s);
                    d.SubmitChanges();
                }
            }
        }
        private bool IsFormValid()
        {
            {
                if (banknametextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Bank Name is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    banknametextBox.Focus();
                    return false;
                }
                if (adressrichTextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Bank Address is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adressrichTextBox1.Focus();
                    return false;
                }
              
                if (branchnametextBox2.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Bank Branch Name is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    branchnametextBox2.Focus();
                    return false;
                }
                if (actextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Bank Account Number is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    actextBox1.Focus();
                    return false;
                }
                return true;
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            detailbankForm df = new detailbankForm();
            df.ShowDialog();
        }
    }
}
