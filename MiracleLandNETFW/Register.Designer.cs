namespace MiracleLandNETFW
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.register_password = new System.Windows.Forms.TextBox();
            this.register_username = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.register_password2 = new System.Windows.Forms.TextBox();
            this.register_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.register_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.register_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // register_password
            // 
            this.register_password.Location = new System.Drawing.Point(166, 97);
            this.register_password.MaxLength = 32;
            this.register_password.Name = "register_password";
            this.register_password.Size = new System.Drawing.Size(294, 20);
            this.register_password.TabIndex = 9;
            this.register_password.UseSystemPasswordChar = true;
            // 
            // register_username
            // 
            this.register_username.Location = new System.Drawing.Point(166, 58);
            this.register_username.MaxLength = 128;
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(294, 20);
            this.register_username.TabIndex = 8;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(385, 286);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(72, 286);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(75, 23);
            this.register_btn.TabIndex = 6;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirm Password";
            // 
            // register_password2
            // 
            this.register_password2.Location = new System.Drawing.Point(166, 136);
            this.register_password2.MaxLength = 32;
            this.register_password2.Name = "register_password2";
            this.register_password2.Size = new System.Drawing.Size(294, 20);
            this.register_password2.TabIndex = 13;
            this.register_password2.UseSystemPasswordChar = true;
            // 
            // register_email
            // 
            this.register_email.Location = new System.Drawing.Point(166, 171);
            this.register_email.MaxLength = 128;
            this.register_email.Name = "register_email";
            this.register_email.Size = new System.Drawing.Size(294, 20);
            this.register_email.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email";
            // 
            // register_address
            // 
            this.register_address.Location = new System.Drawing.Point(166, 207);
            this.register_address.MaxLength = 128;
            this.register_address.Name = "register_address";
            this.register_address.Size = new System.Drawing.Size(294, 20);
            this.register_address.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Address";
            // 
            // register_phone
            // 
            this.register_phone.Location = new System.Drawing.Point(166, 245);
            this.register_phone.MaxLength = 16;
            this.register_phone.Name = "register_phone";
            this.register_phone.Size = new System.Drawing.Size(294, 20);
            this.register_phone.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Phone";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 358);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.register_phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.register_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_email);
            this.Controls.Add(this.register_password2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.register_btn);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox register_password2;
        private System.Windows.Forms.TextBox register_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox register_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox register_phone;
        private System.Windows.Forms.Label label6;
    }
}