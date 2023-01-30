namespace assignment4
{
    partial class Form1
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
            this.listInventory = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbProductDescription = new System.Windows.Forms.RichTextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProcedureMinutes = new System.Windows.Forms.TextBox();
            this.btnDeleteProcedure = new System.Windows.Forms.Button();
            this.btnUpdateProcedure = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddProcedure = new System.Windows.Forms.Button();
            this.rtbProcedureDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProcedureName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcedurePrice = new System.Windows.Forms.TextBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblProductError = new System.Windows.Forms.Label();
            this.lblProcedureError = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listInventory
            // 
            this.listInventory.FormattingEnabled = true;
            this.listInventory.Location = new System.Drawing.Point(38, 65);
            this.listInventory.Name = "listInventory";
            this.listInventory.Size = new System.Drawing.Size(162, 459);
            this.listInventory.Sorted = true;
            this.listInventory.TabIndex = 0;
            this.listInventory.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteProduct);
            this.groupBox1.Controls.Add(this.btnUpdateProduct);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtbProductDescription);
            this.groupBox1.Controls.Add(this.txtProductPrice);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Location = new System.Drawing.Point(301, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products:";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(304, 199);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(110, 27);
            this.btnDeleteProduct.TabIndex = 8;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(166, 199);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(110, 27);
            this.btnUpdateProduct.TabIndex = 7;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(25, 199);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(110, 27);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Add new";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:            $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // rtbProductDescription
            // 
            this.rtbProductDescription.Location = new System.Drawing.Point(102, 62);
            this.rtbProductDescription.Name = "rtbProductDescription";
            this.rtbProductDescription.Size = new System.Drawing.Size(284, 72);
            this.rtbProductDescription.TabIndex = 2;
            this.rtbProductDescription.Text = "";
            this.rtbProductDescription.TextChanged += new System.EventHandler(this.rtbProductDescription_TextChanged);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(102, 151);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(284, 20);
            this.txtProductPrice.TabIndex = 1;
            this.txtProductPrice.TextChanged += new System.EventHandler(this.txtProductPrice_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(102, 36);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(284, 20);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtProcedureMinutes);
            this.groupBox2.Controls.Add(this.btnDeleteProcedure);
            this.groupBox2.Controls.Add(this.btnUpdateProcedure);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAddProcedure);
            this.groupBox2.Controls.Add(this.rtbProcedureDescription);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtProcedureName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtProcedurePrice);
            this.groupBox2.Location = new System.Drawing.Point(301, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 259);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procedures:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Minutes:";
            // 
            // txtProcedureMinutes
            // 
            this.txtProcedureMinutes.Location = new System.Drawing.Point(102, 181);
            this.txtProcedureMinutes.Name = "txtProcedureMinutes";
            this.txtProcedureMinutes.Size = new System.Drawing.Size(284, 20);
            this.txtProcedureMinutes.TabIndex = 12;
            this.txtProcedureMinutes.TextChanged += new System.EventHandler(this.txtProcedureMinutes_TextChanged);
            // 
            // btnDeleteProcedure
            // 
            this.btnDeleteProcedure.Location = new System.Drawing.Point(304, 226);
            this.btnDeleteProcedure.Name = "btnDeleteProcedure";
            this.btnDeleteProcedure.Size = new System.Drawing.Size(110, 27);
            this.btnDeleteProcedure.TabIndex = 11;
            this.btnDeleteProcedure.Text = "Delete";
            this.btnDeleteProcedure.UseVisualStyleBackColor = true;
            this.btnDeleteProcedure.Click += new System.EventHandler(this.btnDeleteProcedure_Click);
            // 
            // btnUpdateProcedure
            // 
            this.btnUpdateProcedure.Location = new System.Drawing.Point(166, 226);
            this.btnUpdateProcedure.Name = "btnUpdateProcedure";
            this.btnUpdateProcedure.Size = new System.Drawing.Size(110, 27);
            this.btnUpdateProcedure.TabIndex = 10;
            this.btnUpdateProcedure.Text = "Update";
            this.btnUpdateProcedure.UseVisualStyleBackColor = true;
            this.btnUpdateProcedure.Click += new System.EventHandler(this.btnUpdateProcedure_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price:            $";
            // 
            // btnAddProcedure
            // 
            this.btnAddProcedure.Location = new System.Drawing.Point(25, 226);
            this.btnAddProcedure.Name = "btnAddProcedure";
            this.btnAddProcedure.Size = new System.Drawing.Size(110, 27);
            this.btnAddProcedure.TabIndex = 9;
            this.btnAddProcedure.Text = "Add new";
            this.btnAddProcedure.UseVisualStyleBackColor = true;
            this.btnAddProcedure.Click += new System.EventHandler(this.btnAddProcedure_Click);
            // 
            // rtbProcedureDescription
            // 
            this.rtbProcedureDescription.Location = new System.Drawing.Point(102, 54);
            this.rtbProcedureDescription.Name = "rtbProcedureDescription";
            this.rtbProcedureDescription.Size = new System.Drawing.Size(284, 72);
            this.rtbProcedureDescription.TabIndex = 8;
            this.rtbProcedureDescription.Text = "";
            this.rtbProcedureDescription.TextChanged += new System.EventHandler(this.rtbProcedureDescription_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description:";
            // 
            // txtProcedureName
            // 
            this.txtProcedureName.Location = new System.Drawing.Point(102, 28);
            this.txtProcedureName.Name = "txtProcedureName";
            this.txtProcedureName.Size = new System.Drawing.Size(284, 20);
            this.txtProcedureName.TabIndex = 6;
            this.txtProcedureName.TextChanged += new System.EventHandler(this.txtProcedureName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name:";
            // 
            // txtProcedurePrice
            // 
            this.txtProcedurePrice.Location = new System.Drawing.Point(102, 143);
            this.txtProcedurePrice.Name = "txtProcedurePrice";
            this.txtProcedurePrice.Size = new System.Drawing.Size(284, 20);
            this.txtProcedurePrice.TabIndex = 7;
            this.txtProcedurePrice.TextChanged += new System.EventHandler(this.txtProcedurePrice_TextChanged);
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(38, 40);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(54, 13);
            this.lblInventory.TabIndex = 3;
            this.lblInventory.Text = "Inventory:";
            // 
            // lblProductError
            // 
            this.lblProductError.AutoSize = true;
            this.lblProductError.ForeColor = System.Drawing.Color.Red;
            this.lblProductError.Location = new System.Drawing.Point(322, 281);
            this.lblProductError.Name = "lblProductError";
            this.lblProductError.Size = new System.Drawing.Size(68, 13);
            this.lblProductError.TabIndex = 4;
            this.lblProductError.Text = "Product error";
            // 
            // lblProcedureError
            // 
            this.lblProcedureError.AutoSize = true;
            this.lblProcedureError.ForeColor = System.Drawing.Color.Red;
            this.lblProcedureError.Location = new System.Drawing.Point(322, 618);
            this.lblProcedureError.Name = "lblProcedureError";
            this.lblProcedureError.Size = new System.Drawing.Size(80, 13);
            this.lblProcedureError.TabIndex = 5;
            this.lblProcedureError.Text = "Procedure error";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(74, 544);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 699);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblProcedureError);
            this.Controls.Add(this.lblProductError);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listInventory);
            this.Name = "Form1";
            this.Text = "Beauty Shop Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listInventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbProductDescription;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProcedureMinutes;
        private System.Windows.Forms.Button btnDeleteProcedure;
        private System.Windows.Forms.Button btnUpdateProcedure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddProcedure;
        private System.Windows.Forms.RichTextBox rtbProcedureDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProcedureName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProcedurePrice;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblProductError;
        private System.Windows.Forms.Label lblProcedureError;
        private System.Windows.Forms.Label lblStatus;
    }
}

