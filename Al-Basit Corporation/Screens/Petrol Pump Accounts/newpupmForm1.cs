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

namespace Al_Basit_Corporation.Screens.Petrol_Pump_Accounts
{
    public partial class newpupmForm1 : defaultForm
    {
        detailpumpDataClasses1DataContext b = new detailpumpDataClasses1DataContext();
        petrolbqayaDataClasses1DataContext p = new petrolbqayaDataClasses1DataContext();
        public newpupmForm1()
        {
            InitializeComponent();
        }

        private void newpupmForm1_Load(object sender, EventArgs e)
        {

        }

        private void newRecordtoolStripButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                tblpetroldetail t = new tblpetroldetail();
                t.Station_Name = banknametextBox.Text;
                t.Owner_Name = branchnametextBox2.Text;
                t.Account_No = actextBox1.Text;

                t.Adress = adressrichTextBox1.Text;

                b.tblpetroldetails.InsertOnSubmit(t);
                b.SubmitChanges();
                MessageBox.Show("New Petrol Account Created SuccessFully...!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                {

                   petrolbqayaamount  s  = new petrolbqayaamount();
                    s.namepump = banknametextBox.Text;
                    s.bqayaamount = "0";
                    p.petrolbqayaamounts.InsertOnSubmit(s);
                    p.SubmitChanges();
                }
            }
        }
        private bool IsFormValid()
        {
            {
                if (banknametextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Petrol Pump Name is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    banknametextBox.Focus();
                    return false;
                }
                if (adressrichTextBox1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Pump Address is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Petrol Station Account Number is Required..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    actextBox1.Focus();
                    return false;
                }
                return true;
            }
        }

        private void closetoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            detailpumpForm df = new detailpumpForm();
            df.ShowDialog();
        }
    }
}
