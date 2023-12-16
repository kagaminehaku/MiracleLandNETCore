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
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.DGV1.Location = new System.Drawing.Point(41, 246);
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
            this.admin_add.Location = new System.Drawing.Point(41, 43);
            this.admin_add.Name = "admin_add";
            this.admin_add.Size = new System.Drawing.Size(103, 33);
            this.admin_add.TabIndex = 1;
            this.admin_add.Text = "➕ New Product";
            this.admin_add.UseVisualStyleBackColor = true;
            this.admin_add.Click += new System.EventHandler(this.admin_add_Click);
            // 
            // admin_delete
            // 
            this.admin_delete.Location = new System.Drawing.Point(41, 82);
            this.admin_delete.Name = "admin_delete";
            this.admin_delete.Size = new System.Drawing.Size(103, 35);
            this.admin_delete.TabIndex = 2;
            this.admin_delete.Text = "❌ Delete Product";
            this.admin_delete.UseVisualStyleBackColor = true;
            this.admin_delete.Click += new System.EventHandler(this.admin_delete_Click);
            // 
            // admin_edit
            // 
            this.admin_edit.Location = new System.Drawing.Point(41, 123);
            this.admin_edit.Name = "admin_edit";
            this.admin_edit.Size = new System.Drawing.Size(103, 37);
            this.admin_edit.TabIndex = 3;
            this.admin_edit.Text = "📝 Edit Product";
            this.admin_edit.UseVisualStyleBackColor = true;
            this.admin_edit.Click += new System.EventHandler(this.admin_edit_Click);
            // 
            // admin_logout
            // 
            this.admin_logout.Location = new System.Drawing.Point(41, 166);
            this.admin_logout.Name = "admin_logout";
            this.admin_logout.Size = new System.Drawing.Size(103, 34);
            this.admin_logout.TabIndex = 4;
            this.admin_logout.Text = "🔓Logout";
            this.admin_logout.UseVisualStyleBackColor = true;
            this.admin_logout.Click += new System.EventHandler(this.admin_logout_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(705, 20);
            this.textBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(525, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // admin_pid
            // 
            this.admin_pid.Enabled = false;
            this.admin_pid.Location = new System.Drawing.Point(220, 43);
            this.admin_pid.Name = "admin_pid";
            this.admin_pid.Size = new System.Drawing.Size(279, 20);
            this.admin_pid.TabIndex = 7;
            // 
            // pname
            // 
            this.pname.Enabled = false;
            this.pname.Location = new System.Drawing.Point(220, 69);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(279, 20);
            this.pname.TabIndex = 8;
            // 
            // pprice
            // 
            this.pprice.Enabled = false;
            this.pprice.Location = new System.Drawing.Point(220, 97);
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(279, 20);
            this.pprice.TabIndex = 9;
            // 
            // pquantity
            // 
            this.pquantity.Enabled = false;
            this.pquantity.Location = new System.Drawing.Point(220, 123);
            this.pquantity.Name = "pquantity";
            this.pquantity.Size = new System.Drawing.Size(279, 20);
            this.pquantity.TabIndex = 10;
            // 
            // pinfo
            // 
            this.pinfo.Enabled = false;
            this.pinfo.Location = new System.Drawing.Point(220, 150);
            this.pinfo.Name = "pinfo";
            this.pinfo.Size = new System.Drawing.Size(279, 59);
            this.pinfo.TabIndex = 11;
            this.pinfo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Info";
            // 
            // MiracleLandAdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 430);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pinfo);
            this.Controls.Add(this.pquantity);
            this.Controls.Add(this.pprice);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.admin_pid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.admin_logout);
            this.Controls.Add(this.admin_edit);
            this.Controls.Add(this.admin_delete);
            this.Controls.Add(this.admin_add);
            this.Controls.Add(this.DGV1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiracleLandAdminUI";
            this.Text = "Admin Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}