namespace TaxiCompanyPricesFunction
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
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnCalculateTaxiPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(74, 69);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(300, 20);
            this.txtDistance.TabIndex = 0;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(74, 50);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(95, 13);
            this.lblDistance.TabIndex = 1;
            this.lblDistance.Text = "Distance travelled:";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(74, 297);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(300, 20);
            this.txtTotalCost.TabIndex = 2;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(74, 281);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(91, 13);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "Total cost for taxi:";
            // 
            // btnCalculateTaxiPrice
            // 
            this.btnCalculateTaxiPrice.Location = new System.Drawing.Point(146, 160);
            this.btnCalculateTaxiPrice.Name = "btnCalculateTaxiPrice";
            this.btnCalculateTaxiPrice.Size = new System.Drawing.Size(150, 50);
            this.btnCalculateTaxiPrice.TabIndex = 4;
            this.btnCalculateTaxiPrice.Text = "Calculate Taxi Price";
            this.btnCalculateTaxiPrice.UseVisualStyleBackColor = true;
            this.btnCalculateTaxiPrice.Click += new System.EventHandler(this.btnCalculateTaxiPrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.btnCalculateTaxiPrice);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtDistance);
            this.Name = "Form1";
            this.Text = "Taxi Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnCalculateTaxiPrice;
    }
}

