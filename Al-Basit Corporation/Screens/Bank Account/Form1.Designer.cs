namespace Al_Basit_Corporation.Screens.Bank_Account
{
    partial class testForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.f1button1 = new System.Windows.Forms.Button();
            this.escbutton2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.f2button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // f1button1
            // 
            this.f1button1.Location = new System.Drawing.Point(125, 37);
            this.f1button1.Name = "f1button1";
            this.f1button1.Size = new System.Drawing.Size(75, 23);
            this.f1button1.TabIndex = 0;
            this.f1button1.Text = "F1";
            this.f1button1.UseVisualStyleBackColor = true;
            this.f1button1.Click += new System.EventHandler(this.f1button1_Click);
            // 
            // escbutton2
            // 
            this.escbutton2.Location = new System.Drawing.Point(44, 37);
            this.escbutton2.Name = "escbutton2";
            this.escbutton2.Size = new System.Drawing.Size(75, 23);
            this.escbutton2.TabIndex = 0;
            this.escbutton2.Text = "Esc";
            this.escbutton2.UseVisualStyleBackColor = true;
            this.escbutton2.Click += new System.EventHandler(this.escbutton2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "F3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // f2button4
            // 
            this.f2button4.Location = new System.Drawing.Point(206, 37);
            this.f2button4.Name = "f2button4";
            this.f2button4.Size = new System.Drawing.Size(75, 23);
            this.f2button4.TabIndex = 0;
            this.f2button4.Text = "F2";
            this.f2button4.UseVisualStyleBackColor = true;
            // 
            // testForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.f2button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.escbutton2);
            this.Controls.Add(this.f1button1);
            this.Name = "testForm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.testForm1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button f1button1;
        private System.Windows.Forms.Button escbutton2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button f2button4;
    }
}