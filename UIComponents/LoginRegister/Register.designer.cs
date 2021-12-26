
namespace EcoCoinMarket.Models.LoginRegister
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(306, 92);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(178, 23);
            this.txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(306, 152);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(178, 23);
            this.txtpassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(306, 209);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(178, 23);
            this.txtconfirmpassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password :";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(342, 248);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(110, 46);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register ";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(342, 312);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(110, 46);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login Now";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
    }
}