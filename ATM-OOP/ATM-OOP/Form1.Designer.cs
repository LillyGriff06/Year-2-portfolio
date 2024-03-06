namespace ATM_OOP
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
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.btnCheckPin = new System.Windows.Forms.Button();
            this.btnWithdrawMoney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(306, 88);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(220, 20);
            this.txtWithdraw.TabIndex = 0;
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(312, 72);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(192, 13);
            this.lblWithdraw.TabIndex = 1;
            this.lblWithdraw.Text = "Enter the amount you wish to withdraw:";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(30, 88);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(220, 20);
            this.txtPin.TabIndex = 2;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(39, 69);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(162, 13);
            this.lblPin.TabIndex = 3;
            this.lblPin.Text = "Enter the pin number of the card:";
            // 
            // btnCheckPin
            // 
            this.btnCheckPin.Location = new System.Drawing.Point(62, 164);
            this.btnCheckPin.Name = "btnCheckPin";
            this.btnCheckPin.Size = new System.Drawing.Size(150, 50);
            this.btnCheckPin.TabIndex = 4;
            this.btnCheckPin.Text = "Check pin";
            this.btnCheckPin.UseVisualStyleBackColor = true;
            this.btnCheckPin.Click += new System.EventHandler(this.btnCheckPin_Click);
            // 
            // btnWithdrawMoney
            // 
            this.btnWithdrawMoney.Location = new System.Drawing.Point(344, 164);
            this.btnWithdrawMoney.Name = "btnWithdrawMoney";
            this.btnWithdrawMoney.Size = new System.Drawing.Size(150, 50);
            this.btnWithdrawMoney.TabIndex = 5;
            this.btnWithdrawMoney.Text = "Withdraw money";
            this.btnWithdrawMoney.UseVisualStyleBackColor = true;
            this.btnWithdrawMoney.Click += new System.EventHandler(this.btnWithdrawMoney_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.btnWithdrawMoney);
            this.Controls.Add(this.btnCheckPin);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.txtWithdraw);
            this.Name = "Form1";
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Button btnCheckPin;
        private System.Windows.Forms.Button btnWithdrawMoney;
    }
}

