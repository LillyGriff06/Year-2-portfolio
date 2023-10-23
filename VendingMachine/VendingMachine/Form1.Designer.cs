namespace VendingMachine
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
            this.btnBuyChocolate = new System.Windows.Forms.Button();
            this.btnBuyCrisps = new System.Windows.Forms.Button();
            this.btnBuyWater = new System.Windows.Forms.Button();
            this.btnAddStockChocolate = new System.Windows.Forms.Button();
            this.btnAddStockCrisps = new System.Windows.Forms.Button();
            this.btnAddStockWater = new System.Windows.Forms.Button();
            this.txtStockChocolate = new System.Windows.Forms.TextBox();
            this.txtStockCrisps = new System.Windows.Forms.TextBox();
            this.txtStockWater = new System.Windows.Forms.TextBox();
            this.btnCreateVendingMachine = new System.Windows.Forms.Button();
            this.btnCheckStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuyChocolate
            // 
            this.btnBuyChocolate.Location = new System.Drawing.Point(36, 109);
            this.btnBuyChocolate.Name = "btnBuyChocolate";
            this.btnBuyChocolate.Size = new System.Drawing.Size(120, 50);
            this.btnBuyChocolate.TabIndex = 0;
            this.btnBuyChocolate.Text = "Buy chocolate";
            this.btnBuyChocolate.UseVisualStyleBackColor = true;
            this.btnBuyChocolate.Click += new System.EventHandler(this.btnBuyChocolate_Click);
            // 
            // btnBuyCrisps
            // 
            this.btnBuyCrisps.Location = new System.Drawing.Point(231, 109);
            this.btnBuyCrisps.Name = "btnBuyCrisps";
            this.btnBuyCrisps.Size = new System.Drawing.Size(120, 50);
            this.btnBuyCrisps.TabIndex = 1;
            this.btnBuyCrisps.Text = "Buy crisps";
            this.btnBuyCrisps.UseVisualStyleBackColor = true;
            this.btnBuyCrisps.Click += new System.EventHandler(this.btnBuyCrisps_Click);
            // 
            // btnBuyWater
            // 
            this.btnBuyWater.Location = new System.Drawing.Point(430, 109);
            this.btnBuyWater.Name = "btnBuyWater";
            this.btnBuyWater.Size = new System.Drawing.Size(120, 50);
            this.btnBuyWater.TabIndex = 2;
            this.btnBuyWater.Text = "Buy water";
            this.btnBuyWater.UseVisualStyleBackColor = true;
            this.btnBuyWater.Click += new System.EventHandler(this.btnBuyWater_Click);
            // 
            // btnAddStockChocolate
            // 
            this.btnAddStockChocolate.AutoSize = true;
            this.btnAddStockChocolate.Location = new System.Drawing.Point(36, 227);
            this.btnAddStockChocolate.Name = "btnAddStockChocolate";
            this.btnAddStockChocolate.Size = new System.Drawing.Size(120, 30);
            this.btnAddStockChocolate.TabIndex = 3;
            this.btnAddStockChocolate.Text = "Add stock";
            this.btnAddStockChocolate.UseVisualStyleBackColor = true;
            this.btnAddStockChocolate.Click += new System.EventHandler(this.btnAddStockChocolate_Click);
            // 
            // btnAddStockCrisps
            // 
            this.btnAddStockCrisps.AutoSize = true;
            this.btnAddStockCrisps.Location = new System.Drawing.Point(231, 227);
            this.btnAddStockCrisps.Name = "btnAddStockCrisps";
            this.btnAddStockCrisps.Size = new System.Drawing.Size(120, 30);
            this.btnAddStockCrisps.TabIndex = 4;
            this.btnAddStockCrisps.Text = "Add stock";
            this.btnAddStockCrisps.UseVisualStyleBackColor = true;
            this.btnAddStockCrisps.Click += new System.EventHandler(this.btnAddStockCrisps_Click);
            // 
            // btnAddStockWater
            // 
            this.btnAddStockWater.AutoSize = true;
            this.btnAddStockWater.Location = new System.Drawing.Point(430, 227);
            this.btnAddStockWater.Name = "btnAddStockWater";
            this.btnAddStockWater.Size = new System.Drawing.Size(120, 30);
            this.btnAddStockWater.TabIndex = 5;
            this.btnAddStockWater.Text = "Add stock";
            this.btnAddStockWater.UseVisualStyleBackColor = true;
            this.btnAddStockWater.Click += new System.EventHandler(this.btnAddStockWater_Click);
            // 
            // txtStockChocolate
            // 
            this.txtStockChocolate.Location = new System.Drawing.Point(52, 201);
            this.txtStockChocolate.Name = "txtStockChocolate";
            this.txtStockChocolate.Size = new System.Drawing.Size(90, 20);
            this.txtStockChocolate.TabIndex = 6;
            // 
            // txtStockCrisps
            // 
            this.txtStockCrisps.Location = new System.Drawing.Point(245, 201);
            this.txtStockCrisps.Name = "txtStockCrisps";
            this.txtStockCrisps.Size = new System.Drawing.Size(90, 20);
            this.txtStockCrisps.TabIndex = 7;
            // 
            // txtStockWater
            // 
            this.txtStockWater.Location = new System.Drawing.Point(446, 201);
            this.txtStockWater.Name = "txtStockWater";
            this.txtStockWater.Size = new System.Drawing.Size(90, 20);
            this.txtStockWater.TabIndex = 8;
            // 
            // btnCreateVendingMachine
            // 
            this.btnCreateVendingMachine.Location = new System.Drawing.Point(95, 29);
            this.btnCreateVendingMachine.Name = "btnCreateVendingMachine";
            this.btnCreateVendingMachine.Size = new System.Drawing.Size(396, 24);
            this.btnCreateVendingMachine.TabIndex = 9;
            this.btnCreateVendingMachine.Text = "Use vending machine";
            this.btnCreateVendingMachine.UseVisualStyleBackColor = true;
            this.btnCreateVendingMachine.Click += new System.EventHandler(this.btnCreateVendingMachine_Click);
            // 
            // btnCheckStock
            // 
            this.btnCheckStock.Location = new System.Drawing.Point(95, 336);
            this.btnCheckStock.Name = "btnCheckStock";
            this.btnCheckStock.Size = new System.Drawing.Size(396, 35);
            this.btnCheckStock.TabIndex = 10;
            this.btnCheckStock.Text = "Check Stock";
            this.btnCheckStock.UseVisualStyleBackColor = true;
            this.btnCheckStock.Click += new System.EventHandler(this.btnCheckStock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 408);
            this.Controls.Add(this.btnCheckStock);
            this.Controls.Add(this.btnCreateVendingMachine);
            this.Controls.Add(this.txtStockWater);
            this.Controls.Add(this.txtStockCrisps);
            this.Controls.Add(this.txtStockChocolate);
            this.Controls.Add(this.btnAddStockWater);
            this.Controls.Add(this.btnAddStockCrisps);
            this.Controls.Add(this.btnAddStockChocolate);
            this.Controls.Add(this.btnBuyWater);
            this.Controls.Add(this.btnBuyCrisps);
            this.Controls.Add(this.btnBuyChocolate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuyChocolate;
        private System.Windows.Forms.Button btnBuyCrisps;
        private System.Windows.Forms.Button btnBuyWater;
        private System.Windows.Forms.Button btnAddStockChocolate;
        private System.Windows.Forms.Button btnAddStockCrisps;
        private System.Windows.Forms.Button btnAddStockWater;
        private System.Windows.Forms.TextBox txtStockChocolate;
        private System.Windows.Forms.TextBox txtStockCrisps;
        private System.Windows.Forms.TextBox txtStockWater;
        private System.Windows.Forms.Button btnCreateVendingMachine;
        private System.Windows.Forms.Button btnCheckStock;
    }
}

