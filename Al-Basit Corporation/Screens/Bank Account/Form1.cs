using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Basit_Corporation.Screens.Bank_Account
{
    public partial class testForm1 : Form
    {
        public testForm1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                escbutton2.PerformClick();
            }
            if (e.KeyCode == Keys.F1)
            {
                f1button1.PerformClick();
            }
        }

        private void escbutton2_Click(object sender, EventArgs e)
        {
            escbutton2.Visible = false;
        }

        private void f1button1_Click(object sender, EventArgs e)
        {
            f1button1.Visible = false;
        }

        private void testForm1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
