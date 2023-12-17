namespace MiracleLandNETFW
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            this.cancel = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_info = new System.Windows.Forms.RichTextBox();
            this.edit_quantity = new System.Windows.Forms.TextBox();
            this.edit_price = new System.Windows.Forms.TextBox();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(223, 178);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(134, 41);
            this.cancel.TabIndex = 41;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(78, 177);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(134, 41);
            this.edit.TabIndex = 40;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Name";
            // 
            // edit_info
            // 
            this.edit_info.Location = new System.Drawing.Point(78, 102);
            this.edit_info.MaxLength = 256;
            this.edit_info.Name = "edit_info";
            this.edit_info.Size = new System.Drawing.Size(279, 69);
            this.edit_info.TabIndex = 35;
            this.edit_info.Text = "";
            // 
            // edit_quantity
            // 
            this.edit_quantity.Location = new System.Drawing.Point(78, 75);
            this.edit_quantity.MaxLength = 16;
            this.edit_quantity.Name = "edit_quantity";
            this.edit_quantity.Size = new System.Drawing.Size(279, 20);
            this.edit_quantity.TabIndex = 34;
            this.edit_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_quantity_KeyPress);
            // 
            // edit_price
            // 
            this.edit_price.Location = new System.Drawing.Point(78, 49);
            this.edit_price.MaxLength = 16;
            this.edit_price.Name = "edit_price";
            this.edit_price.Size = new System.Drawing.Size(279, 20);
            this.edit_price.TabIndex = 33;
            this.edit_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edit_price_KeyPress);
            // 
            // edit_name
            // 
            this.edit_name.Location = new System.Drawing.Point(78, 21);
            this.edit_name.MaxLength = 64;
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(279, 20);
            this.edit_name.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(380, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 240);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_info);
            this.Controls.Add(this.edit_quantity);
            this.Controls.Add(this.edit_price);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox edit_info;
        private System.Windows.Forms.TextBox edit_quantity;
        private System.Windows.Forms.TextBox edit_price;
        private System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}