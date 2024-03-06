namespace ExceptionHandling1
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
            this.txtTicketsSold = new System.Windows.Forms.TextBox();
            this.lblTicketsSold = new System.Windows.Forms.Label();
            this.btnCalculateSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTicketsSold
            // 
            this.txtTicketsSold.Location = new System.Drawing.Point(44, 59);
            this.txtTicketsSold.Name = "txtTicketsSold";
            this.txtTicketsSold.Size = new System.Drawing.Size(170, 20);
            this.txtTicketsSold.TabIndex = 0;
            // 
            // lblTicketsSold
            // 
            this.lblTicketsSold.AutoSize = true;
            this.lblTicketsSold.Location = new System.Drawing.Point(41, 43);
            this.lblTicketsSold.Name = "lblTicketsSold";
            this.lblTicketsSold.Size = new System.Drawing.Size(153, 13);
            this.lblTicketsSold.TabIndex = 1;
            this.lblTicketsSold.Text = "Input the number of ticket sold:";
            // 
            // btnCalculateSales
            // 
            this.btnCalculateSales.Location = new System.Drawing.Point(77, 116);
            this.btnCalculateSales.Name = "btnCalculateSales";
            this.btnCalculateSales.Size = new System.Drawing.Size(100, 40);
            this.btnCalculateSales.TabIndex = 2;
            this.btnCalculateSales.Text = "Calculate sales";
            this.btnCalculateSales.UseVisualStyleBackColor = true;
            this.btnCalculateSales.Click += new System.EventHandler(this.btnCalculateSales_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculateSales);
            this.Controls.Add(this.lblTicketsSold);
            this.Controls.Add(this.txtTicketsSold);
            this.Name = "Form1";
            this.Text = "Ticket sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTicketsSold;
        private System.Windows.Forms.Label lblTicketsSold;
        private System.Windows.Forms.Button btnCalculateSales;
    }
}

