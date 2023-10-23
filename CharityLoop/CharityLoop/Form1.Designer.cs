namespace CharityLoop
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
            this.txtDonation = new System.Windows.Forms.TextBox();
            this.lblDonation = new System.Windows.Forms.Label();
            this.txtTotalDonated = new System.Windows.Forms.TextBox();
            this.lblTotalDonated = new System.Windows.Forms.Label();
            this.btnDonations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDonation
            // 
            this.txtDonation.Location = new System.Drawing.Point(56, 65);
            this.txtDonation.Name = "txtDonation";
            this.txtDonation.Size = new System.Drawing.Size(200, 20);
            this.txtDonation.TabIndex = 0;
            this.txtDonation.TextChanged += new System.EventHandler(this.txtDonation_TextChanged);
            // 
            // lblDonation
            // 
            this.lblDonation.AutoSize = true;
            this.lblDonation.Location = new System.Drawing.Point(56, 46);
            this.lblDonation.Name = "lblDonation";
            this.lblDonation.Size = new System.Drawing.Size(115, 13);
            this.lblDonation.TabIndex = 1;
            this.lblDonation.Text = "Amount to be donated:";
            // 
            // txtTotalDonated
            // 
            this.txtTotalDonated.Location = new System.Drawing.Point(59, 273);
            this.txtTotalDonated.Name = "txtTotalDonated";
            this.txtTotalDonated.Size = new System.Drawing.Size(200, 20);
            this.txtTotalDonated.TabIndex = 2;
            // 
            // lblTotalDonated
            // 
            this.lblTotalDonated.AutoSize = true;
            this.lblTotalDonated.Location = new System.Drawing.Point(59, 254);
            this.lblTotalDonated.Name = "lblTotalDonated";
            this.lblTotalDonated.Size = new System.Drawing.Size(76, 13);
            this.lblTotalDonated.TabIndex = 3;
            this.lblTotalDonated.Text = "Total donated:";
            // 
            // btnDonations
            // 
            this.btnDonations.Location = new System.Drawing.Point(77, 147);
            this.btnDonations.Name = "btnDonations";
            this.btnDonations.Size = new System.Drawing.Size(150, 50);
            this.btnDonations.TabIndex = 4;
            this.btnDonations.Text = "Donate";
            this.btnDonations.UseVisualStyleBackColor = true;
            this.btnDonations.Click += new System.EventHandler(this.btnDonations_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDonations);
            this.Controls.Add(this.lblTotalDonated);
            this.Controls.Add(this.txtTotalDonated);
            this.Controls.Add(this.lblDonation);
            this.Controls.Add(this.txtDonation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDonation;
        private System.Windows.Forms.Label lblDonation;
        private System.Windows.Forms.TextBox txtTotalDonated;
        private System.Windows.Forms.Label lblTotalDonated;
        private System.Windows.Forms.Button btnDonations;
    }
}

