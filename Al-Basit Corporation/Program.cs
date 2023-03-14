using Al_Basit_Corporation.Screens;
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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Basit_Corporation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm1());
        }
    }
}
