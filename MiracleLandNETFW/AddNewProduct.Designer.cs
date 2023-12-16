namespace MiracleLandNETFW
{
    partial class AddNewProduct
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_info = new System.Windows.Forms.RichTextBox();
            this.add_quantity = new System.Windows.Forms.TextBox();
            this.add_price = new System.Windows.Forms.TextBox();
            this.add_name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name";
            // 
            // add_info
            // 
            this.add_info.Location = new System.Drawing.Point(77, 105);
            this.add_info.MaxLength = 256;
            this.add_info.Name = "add_info";
            this.add_info.Size = new System.Drawing.Size(279, 69);
            this.add_info.TabIndex = 22;
            this.add_info.Text = "";
            // 
            // add_quantity
            // 
            this.add_quantity.Location = new System.Drawing.Point(77, 78);
            this.add_quantity.MaxLength = 16;
            this.add_quantity.Name = "add_quantity";
            this.add_quantity.Size = new System.Drawing.Size(279, 20);
            this.add_quantity.TabIndex = 21;
            this.add_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_quantity_KeyPress);
            // 
            // add_price
            // 
            this.add_price.Location = new System.Drawing.Point(77, 52);
            this.add_price.MaxLength = 16;
            this.add_price.Name = "add_price";
            this.add_price.Size = new System.Drawing.Size(279, 20);
            this.add_price.TabIndex = 20;
            this.add_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.add_price_KeyPress);
            // 
            // add_name
            // 
            this.add_name.Location = new System.Drawing.Point(77, 24);
            this.add_name.MaxLength = 64;
            this.add_name.Name = "add_name";
            this.add_name.Size = new System.Drawing.Size(279, 20);
            this.add_name.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(379, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(77, 180);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(134, 41);
            this.add.TabIndex = 29;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(222, 181);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(134, 41);
            this.cancel.TabIndex = 30;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 240);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_info);
            this.Controls.Add(this.add_quantity);
            this.Controls.Add(this.add_price);
            this.Controls.Add(this.add_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddNewProduct";
            this.Text = "AddNewProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox add_info;
        private System.Windows.Forms.TextBox add_quantity;
        private System.Windows.Forms.TextBox add_price;
        private System.Windows.Forms.TextBox add_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
    }
}