namespace MiracleLandNETFW
{
    partial class MiracleLandAdminUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiracleLandAdminUI));
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_add = new System.Windows.Forms.Button();
            this.admin_delete = new System.Windows.Forms.Button();
            this.admin_edit = new System.Windows.Forms.Button();
            this.admin_logout = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_pid = new System.Windows.Forms.TextBox();
            this.pname = new System.Windows.Forms.TextBox();
            this.pprice = new System.Windows.Forms.TextBox();
            this.pquantity = new System.Windows.Forms.TextBox();
            this.pinfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.change_password = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cn_password = new System.Windows.Forms.TextBox();
            this.n_password = new System.Windows.Forms.TextBox();
            this.current_password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.AllowUserToResizeColumns = false;
            this.DGV1.AllowUserToResizeRows = false;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.price,
            this.quantity,
            this.info});
            this.DGV1.Location = new System.Drawing.Point(19, 231);
            this.DGV1.MultiSelect = false;
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(705, 163);
            this.DGV1.TabIndex = 0;
            this.DGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellClick);
            // 
            // id
            // 
            this.id.FillWeight = 30F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.FillWeight = 50F;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.FillWeight = 50F;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 40F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // info
            // 
            this.info.FillWeight = 150F;
            this.info.HeaderText = "Info";
            this.info.Name = "info";
            this.info.ReadOnly = true;
            // 
            // admin_add
            // 
            this.admin_add.Location = new System.Drawing.Point(19, 28);
            this.admin_add.Name = "admin_add";
            this.admin_add.Size = new System.Drawing.Size(103, 33);
            this.admin_add.TabIndex = 1;
            this.admin_add.Text = "➕ New Product";
            this.admin_add.UseVisualStyleBackColor = true;
            this.admin_add.Click += new System.EventHandler(this.admin_add_Click);
            // 
            // admin_delete
            // 
            this.admin_delete.Location = new System.Drawing.Point(19, 67);
            this.admin_delete.Name = "admin_delete";
            this.admin_delete.Size = new System.Drawing.Size(103, 35);
            this.admin_delete.TabIndex = 2;
            this.admin_delete.Text = "❌ Delete Product";
            this.admin_delete.UseVisualStyleBackColor = true;
            this.admin_delete.Click += new System.EventHandler(this.admin_delete_Click);
            // 
            // admin_edit
            // 
            this.admin_edit.Location = new System.Drawing.Point(19, 108);
            this.admin_edit.Name = "admin_edit";
            this.admin_edit.Size = new System.Drawing.Size(103, 37);
            this.admin_edit.TabIndex = 3;
            this.admin_edit.Text = "📝 Edit Product";
            this.admin_edit.UseVisualStyleBackColor = true;
            this.admin_edit.Click += new System.EventHandler(this.admin_edit_Click);
            // 
            // admin_logout
            // 
            this.admin_logout.Location = new System.Drawing.Point(19, 151);
            this.admin_logout.Name = "admin_logout";
            this.admin_logout.Size = new System.Drawing.Size(103, 34);
            this.admin_logout.TabIndex = 4;
            this.admin_logout.Text = "🔓 Logout";
            this.admin_logout.UseVisualStyleBackColor = true;
            this.admin_logout.Click += new System.EventHandler(this.admin_logout_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(705, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(503, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // admin_pid
            // 
            this.admin_pid.Enabled = false;
            this.admin_pid.Location = new System.Drawing.Point(198, 28);
            this.admin_pid.Name = "admin_pid";
            this.admin_pid.Size = new System.Drawing.Size(279, 20);
            this.admin_pid.TabIndex = 7;
            // 
            // pname
            // 
            this.pname.Enabled = false;
            this.pname.Location = new System.Drawing.Point(198, 54);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(279, 20);
            this.pname.TabIndex = 8;
            // 
            // pprice
            // 
            this.pprice.Enabled = false;
            this.pprice.Location = new System.Drawing.Point(198, 82);
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(279, 20);
            this.pprice.TabIndex = 9;
            // 
            // pquantity
            // 
            this.pquantity.Enabled = false;
            this.pquantity.Location = new System.Drawing.Point(198, 108);
            this.pquantity.Name = "pquantity";
            this.pquantity.Size = new System.Drawing.Size(279, 20);
            this.pquantity.TabIndex = 10;
            // 
            // pinfo
            // 
            this.pinfo.Enabled = false;
            this.pinfo.Location = new System.Drawing.Point(198, 135);
            this.pinfo.Name = "pinfo";
            this.pinfo.Size = new System.Drawing.Size(279, 59);
            this.pinfo.TabIndex = 11;
            this.pinfo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Info";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 436);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.admin_add);
            this.tabPage1.Controls.Add(this.admin_logout);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.pinfo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.admin_edit);
            this.tabPage1.Controls.Add(this.pname);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.DGV1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.admin_pid);
            this.tabPage1.Controls.Add(this.pquantity);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.admin_delete);
            this.tabPage1.Controls.Add(this.pprice);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.change_password);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cn_password);
            this.tabPage2.Controls.Add(this.n_password);
            this.tabPage2.Controls.Add(this.current_password);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Account";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // change_password
            // 
            this.change_password.Location = new System.Drawing.Point(283, 236);
            this.change_password.Name = "change_password";
            this.change_password.Size = new System.Drawing.Size(142, 34);
            this.change_password.TabIndex = 6;
            this.change_password.Text = "Change password";
            this.change_password.UseVisualStyleBackColor = true;
            this.change_password.Click += new System.EventHandler(this.change_password_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Confirm password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "New password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Current password";
            // 
            // cn_password
            // 
            this.cn_password.Location = new System.Drawing.Point(207, 191);
            this.cn_password.Name = "cn_password";
            this.cn_password.Size = new System.Drawing.Size(303, 20);
            this.cn_password.TabIndex = 2;
            this.cn_password.UseSystemPasswordChar = true;
            // 
            // n_password
            // 
            this.n_password.Location = new System.Drawing.Point(207, 148);
            this.n_password.Name = "n_password";
            this.n_password.Size = new System.Drawing.Size(303, 20);
            this.n_password.TabIndex = 1;
            this.n_password.UseSystemPasswordChar = true;
            // 
            // current_password
            // 
            this.current_password.Location = new System.Drawing.Point(207, 107);
            this.current_password.Name = "current_password";
            this.current_password.Size = new System.Drawing.Size(303, 20);
            this.current_password.TabIndex = 0;
            this.current_password.UseSystemPasswordChar = true;
            // 
            // MiracleLandAdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 462);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiracleLandAdminUI";
            this.Text = "Admin Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button admin_add;
        private System.Windows.Forms.Button admin_delete;
        private System.Windows.Forms.Button admin_edit;
        private System.Windows.Forms.Button admin_logout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox admin_pid;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.TextBox pprice;
        private System.Windows.Forms.TextBox pquantity;
        private System.Windows.Forms.RichTextBox pinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn info;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox cn_password;
        private System.Windows.Forms.TextBox n_password;
        private System.Windows.Forms.TextBox current_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button change_password;
    }
}