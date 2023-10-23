namespace BikeHire
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
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtSeason = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(83, 91);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(500, 20);
            this.txtDays.TabIndex = 0;
            // 
            // txtSeason
            // 
            this.txtSeason.Location = new System.Drawing.Point(83, 157);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Size = new System.Drawing.Size(500, 20);
            this.txtSeason.TabIndex = 1;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(86, 65);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(266, 13);
            this.lblDays.TabIndex = 2;
            this.lblDays.Text = "Enter the number of days that you wish to hire the bike:";
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(86, 132);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(239, 13);
            this.lblSeason.TabIndex = 3;
            this.lblSeason.Text = "Enter the season that you wish to hire the bike in:";
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.Location = new System.Drawing.Point(252, 211);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(155, 55);
            this.btnCalculateCost.TabIndex = 4;
            this.btnCalculateCost.Text = "Calculate cost";
            this.btnCalculateCost.UseVisualStyleBackColor = true;
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(86, 298);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(65, 13);
            this.lblCost.TabIndex = 5;
            this.lblCost.Text = "Output cost:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(83, 315);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(500, 20);
            this.txtCost.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnCalculateCost);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.txtSeason);
            this.Controls.Add(this.txtDays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtSeason;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.Button btnCalculateCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
    }
}

