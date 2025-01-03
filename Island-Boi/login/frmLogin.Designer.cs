namespace Island_Boi
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.btnSubmit2 = new System.Windows.Forms.Button();
            this.lblSign = new System.Windows.Forms.Label();
            this.lblSign2 = new System.Windows.Forms.Label();
            this.lblStart2 = new System.Windows.Forms.Label();
            this.btnSubmit4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(138, 215);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 31);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(132, 185);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(117, 20);
            this.txtPass.TabIndex = 1;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(132, 159);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(117, 20);
            this.txtusername.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(152, 318);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 23);
            this.btnSign.TabIndex = 4;
            this.btnSign.Text = "Sign Up";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click_1);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(132, 127);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(109, 13);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Enter your Username:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(67, 159);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(67, 189);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(75, 153);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(228, 13);
            this.lblInfo2.TabIndex = 8;
            this.lblInfo2.Text = "Not you or forget your password? Sign up now!";
            this.lblInfo2.Click += new System.EventHandler(this.lblInfo2_Click);
            // 
            // btnSubmit2
            // 
            this.btnSubmit2.Location = new System.Drawing.Point(137, 214);
            this.btnSubmit2.Name = "btnSubmit2";
            this.btnSubmit2.Size = new System.Drawing.Size(104, 31);
            this.btnSubmit2.TabIndex = 9;
            this.btnSubmit2.Text = "Submit";
            this.btnSubmit2.UseVisualStyleBackColor = true;
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.Location = new System.Drawing.Point(94, 264);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(189, 13);
            this.lblSign.TabIndex = 12;
            this.lblSign.Text = "Don\'t have an account? Sign up Now!";
            this.lblSign.Click += new System.EventHandler(this.lblSign_Click);
            // 
            // lblSign2
            // 
            this.lblSign2.AutoSize = true;
            this.lblSign2.Location = new System.Drawing.Point(126, 287);
            this.lblSign2.Name = "lblSign2";
            this.lblSign2.Size = new System.Drawing.Size(134, 13);
            this.lblSign2.TabIndex = 13;
            this.lblSign2.Text = "Click this button to sign up:";
            this.lblSign2.Click += new System.EventHandler(this.lblSign2_Click);
            // 
            // lblStart2
            // 
            this.lblStart2.AutoSize = true;
            this.lblStart2.Location = new System.Drawing.Point(94, 127);
            this.lblStart2.Name = "lblStart2";
            this.lblStart2.Size = new System.Drawing.Size(202, 13);
            this.lblStart2.TabIndex = 14;
            this.lblStart2.Text = "Enter your new Username and Password:";
            this.lblStart2.Click += new System.EventHandler(this.lblStart2_Click);
            // 
            // btnSubmit4
            // 
            this.btnSubmit4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit4.Location = new System.Drawing.Point(137, 215);
            this.btnSubmit4.Name = "btnSubmit4";
            this.btnSubmit4.Size = new System.Drawing.Size(104, 31);
            this.btnSubmit4.TabIndex = 15;
            this.btnSubmit4.Text = "Submit";
            this.btnSubmit4.UseVisualStyleBackColor = false;
            this.btnSubmit4.Click += new System.EventHandler(this.btnSubmit4_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 404);
            this.Controls.Add(this.btnSubmit4);
            this.Controls.Add(this.lblStart2);
            this.Controls.Add(this.lblSign2);
            this.Controls.Add(this.lblSign);
            this.Controls.Add(this.btnSubmit2);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Button btnSubmit2;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.Label lblSign2;
        private System.Windows.Forms.Label lblStart2;
        private System.Windows.Forms.Button btnSubmit4;
    }
}

