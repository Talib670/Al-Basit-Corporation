namespace Al_Basit_Corporation.Screens
{
    partial class LoginForm1
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
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.passtextBox = new System.Windows.Forms.TextBox();
            this.passlabel = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox1.Location = new System.Drawing.Point(73, 193);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(101, 17);
            this.CheckBox1.TabIndex = 52;
            this.CheckBox1.Text = "Show password";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.Location = new System.Drawing.Point(240, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 49;
            this.button2.Text = "E&xit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 48;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passtextBox
            // 
            this.passtextBox.AcceptsReturn = true;
            this.passtextBox.AcceptsTab = true;
            this.passtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.passtextBox.Location = new System.Drawing.Point(73, 158);
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.Size = new System.Drawing.Size(268, 29);
            this.passtextBox.TabIndex = 47;
            this.passtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passtextBox.UseSystemPasswordChar = true;
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.passlabel.Location = new System.Drawing.Point(144, 114);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(106, 24);
            this.passlabel.TabIndex = 51;
            this.passlabel.Text = "Password:";
            // 
            // usernametextBox
            // 
            this.usernametextBox.AcceptsTab = true;
            this.usernametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.usernametextBox.Location = new System.Drawing.Point(73, 65);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(268, 29);
            this.usernametextBox.TabIndex = 46;
            this.usernametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.usernamelabel.Location = new System.Drawing.Point(130, 21);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(120, 24);
            this.usernamelabel.TabIndex = 50;
            this.usernamelabel.Text = "User Name:";
            // 
            // LoginForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 275);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passtextBox);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.usernamelabel);
            this.MinimizeBox = false;
            this.Name = "LoginForm1";
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.LoginForm1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox passtextBox;
        private System.Windows.Forms.Label passlabel;
        public System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.Label usernamelabel;
    }
}