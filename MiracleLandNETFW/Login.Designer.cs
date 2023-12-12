namespace MiracleLandNETFW
{
    partial class Login
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
            this.login_btn = new System.Windows.Forms.Button();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Guest = new System.Windows.Forms.Button();
            this.reg_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(143, 151);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(143, 54);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(294, 20);
            this.login_username.TabIndex = 2;
            // 
            // login_password
            // 
            this.login_password.Location = new System.Drawing.Point(143, 93);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(294, 20);
            this.login_password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Guest
            // 
            this.Guest.Location = new System.Drawing.Point(243, 151);
            this.Guest.Name = "Guest";
            this.Guest.Size = new System.Drawing.Size(100, 23);
            this.Guest.TabIndex = 6;
            this.Guest.Text = "Login as Guest";
            this.Guest.UseVisualStyleBackColor = true;
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(362, 151);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(75, 23);
            this.reg_btn.TabIndex = 7;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 221);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.Guest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.login_btn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Guest;
        private System.Windows.Forms.Button reg_btn;
    }
}