using Al_Basit_Corporation.Models;
using Al_Basit_Corporation.Screens.Bank_Account;
using Al_Basit_Corporation.Screens.Client_Accounts;
using Al_Basit_Corporation.Screens.Employee_Accounts;
using Al_Basit_Corporation.Screens.Factory_Accounts;
using Al_Basit_Corporation.Screens.Genral_Purchase;
using Al_Basit_Corporation.Screens.Investres;
using Al_Basit_Corporation.Screens.Machinery_Account;
using Al_Basit_Corporation.Screens.Petrol_Pump_Accounts;
using Al_Basit_Corporation.Screens.Purchase_Account;
using Al_Basit_Corporation.Screens.Sale_Accounts;
using System;
using System.Data.SqlClient;

namespace Al_Basit_Corporation.Screens
{
    public partial class DashboaredForm1 : Form4
    {
        public object LoginForm { get; private set; }

        public DashboaredForm1()
        {
            InitializeComponent();
        }

        private void DashboaredForm1_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(DecHelper.ConnectionString);
            con.Open();
            string str = "SELECT  * FROM [Albbasitcorporation].[dbo].[tblgrandtotal]";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                grandtotal.Text = rd[1].ToString();

                //txtbal.Text = "";
                // textacno.Text = "";
                // textuname.Text= "";
                //   textnowbal.Visible = true;
                // textacno.Focus();
            }
            loginuser.Text = LoginForm1.recby;
          

        }

        private void ManageUserstoolStripButton_Click(object sender, EventArgs e)
        {
            investerForm1 i = new investerForm1();
            i.ShowDialog();
        }

        private void ManageBranchestoolStripButton_Click(object sender, EventArgs e)
        {
            BankForm bf = new BankForm();
            bf.ShowDialog();
        }

        private void newstudenttoolStripButton_Click(object sender, EventArgs e)
        {
            ClientsFormForm cf = new ClientsFormForm();
            cf.ShowDialog();
        }

        private void SystemSetuptoolStripButton_Click(object sender, EventArgs e)
        {
            factoryForm f = new factoryForm();
            f.ShowDialog();
        }

        private void EditProfiletoolStripButton_Click(object sender, EventArgs e)
        {
            employeeForm1 ef = new employeeForm1();
            ef.ShowDialog();
        }

        private void ts_StockOut_Click(object sender, EventArgs e)
        {

        }

        private void generalPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genralpurchaseForm gf = new genralpurchaseForm();
            gf.ShowDialog();
        }

        private void saleAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleForm1 s = new SaleForm1();
            s.ShowDialog();
        }

        private void purchaseAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseForm1 p = new PurchaseForm1();
            p.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PetrolPumpForm pf = new PetrolPumpForm();
            pf.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MachineryForm1 mf = new MachineryForm1();
            mf.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DecHelper.ConnectionString);
            con.Open();
            string str = "SELECT  * FROM [Albbasitcorporation].[dbo].[tblgrandtotal]";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                grandtotal.Text = rd[1].ToString();

                //txtbal.Text = "";
                // textacno.Text = "";
                // textuname.Text= "";
                //   textnowbal.Visible = true;
                // textacno.Focus();
            }
        }
    }
}
