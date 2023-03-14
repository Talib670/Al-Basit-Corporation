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

namespace Al_Basit_Corporation.Screens.Client_Accounts
{
    public partial class newclientorm1 : defaultForm
    {
       clientdetailDataClasses1DataContext df = new clientdetailDataClasses1DataContext();
        clientbqayaDataClasses1DataContext cd = new clientbqayaDataClasses1DataContext();
        public newclientorm1()
        {
            InitializeComponent();
        }

        private void newclientorm1_Load(object sender, EventArgs e)
        {

        }

        private void newRecordtoolStripButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                tblclientdetail t = new tblclientdetail();
                t.Name = clientnametextBox.Text;
                t.Father_Name = fnametextBox2.Text;
                t.Phone_No = phonetextBox1.Text;
                t.CNIC = cnictextBox.Text;
              

                t.Adress = adressrichTextBox1.Text;

               df.tblclientdetails.InsertOnSubmit(t);
                df.SubmitChanges();
                MessageBox.Show("New Client Account Created SuccessFully...!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                {

                 clientbqayaamount    s = new clientbqayaamount();
                    s.nameclient = clientnametextBox.Text;
                    s.bqayaamount = "0";
                    cd.clientbqayaamounts.InsertOnSubmit(s);
                    cd.SubmitChanges();
                }
            }
        }
        private bool IsFormValid()
        {
            {
                if (clientnametextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Client Name is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   clientnametextBox.Focus();
                    return false;
                }
                if (adressrichTextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Client Address is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    adressrichTextBox1.Focus();
                    return false;
                }

                if (fnametextBox2.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Father Name is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fnametextBox2.Focus();
                    return false;
                }
                if (phonetextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Client Phone Number is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phonetextBox1.Focus();
                    return false;
                }
                if (cnictextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Client CNIC Number is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phonetextBox1.Focus();
                    return false;
                }
                return true;
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            detailclientForm df = new detailclientForm();
            df.ShowDialog();
        }

        private void closetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
