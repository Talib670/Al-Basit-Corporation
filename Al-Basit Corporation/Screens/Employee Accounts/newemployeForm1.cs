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

namespace Al_Basit_Corporation.Screens.Employee_Accounts
{
    public partial class newemployeForm1 : Form4
    {
        detailemployeeDataClasses1DataContext d = new detailemployeeDataClasses1DataContext();
        bqayaemployeeDataClasses1DataContext b = new bqayaemployeeDataClasses1DataContext();
        public newemployeForm1()
        {
            InitializeComponent();
        }

        private void newemployeForm1_Load(object sender, EventArgs e)
        {

        }

        private void newRecordtoolStripButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                tblemployedetail t = new tblemployedetail();
                t.Name = clientnametextBox.Text;
                t.Father_Name = fnametextBox2.Text;
                t.Phone_No = phonetextBox1.Text;
                t.CNIC = cnictextBox.Text;


                t.Adress = adressrichTextBox1.Text;

                d.tblemployedetails.InsertOnSubmit(t);
                d.SubmitChanges();
                MessageBox.Show("New Employee Account Created SuccessFully...!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                {

                    employebqayaamount s = new employebqayaamount();
                    s.nameemployee = clientnametextBox.Text;
                    s.bqayaamount = "0";
                    b.employebqayaamounts.InsertOnSubmit(s);
                    b.SubmitChanges();
                }
            }
        }
        private bool IsFormValid()
        {
            {
                if (clientnametextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Employee  Name is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clientnametextBox.Focus();
                    return false;
                }
                if (adressrichTextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Employee  Address is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Employee Phone Number is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phonetextBox1.Focus();
                    return false;
                }
                if (cnictextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Employee  CNIC Number is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    phonetextBox1.Focus();
                    return false;
                }
                return true;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            detailemployeForm1 df = new detailemployeForm1();
            df.ShowDialog();
        }

        private void closetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
