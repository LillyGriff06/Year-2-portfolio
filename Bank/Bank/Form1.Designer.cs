namespace Bank
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(58, 242);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(140, 55);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(234, 242);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(140, 55);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Make Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(587, 242);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(140, 55);
            this.btnBalance.TabIndex = 2;
            this.btnBalance.Text = "Display Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(113, 77);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(200, 20);
            this.txtDeposit.TabIndex = 3;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(113, 58);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(85, 13);
            this.lblDeposit.TabIndex = 4;
            this.lblDeposit.Text = "Deposit Amount:";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(407, 242);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(140, 55);
            this.btnWithdraw.TabIndex = 5;
            this.btnWithdraw.Text = "Make Withdrawal";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(476, 77);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(200, 20);
            this.txtWithdraw.TabIndex = 6;
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(476, 58);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(94, 13);
            this.lblWithdraw.TabIndex = 7;
            this.lblWithdraw.Text = "Withdraw Amount:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Label lblWithdraw;
    }
}

