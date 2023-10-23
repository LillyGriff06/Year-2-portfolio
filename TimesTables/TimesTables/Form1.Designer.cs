namespace TimesTables
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnTimesTables = new System.Windows.Forms.Button();
            this.txtTimesTables = new System.Windows.Forms.TextBox();
            this.lblTimesTables = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(67, 55);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(300, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(67, 36);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(144, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Choose a times table (1 - 12):";
            // 
            // btnTimesTables
            // 
            this.btnTimesTables.Location = new System.Drawing.Point(142, 108);
            this.btnTimesTables.Name = "btnTimesTables";
            this.btnTimesTables.Size = new System.Drawing.Size(150, 40);
            this.btnTimesTables.TabIndex = 2;
            this.btnTimesTables.Text = "Time tables";
            this.btnTimesTables.UseVisualStyleBackColor = true;
            this.btnTimesTables.Click += new System.EventHandler(this.btnTimesTables_Click);
            // 
            // txtTimesTables
            // 
            this.txtTimesTables.Location = new System.Drawing.Point(67, 199);
            this.txtTimesTables.Multiline = true;
            this.txtTimesTables.Name = "txtTimesTables";
            this.txtTimesTables.Size = new System.Drawing.Size(300, 165);
            this.txtTimesTables.TabIndex = 3;
            // 
            // lblTimesTables
            // 
            this.lblTimesTables.AutoSize = true;
            this.lblTimesTables.Location = new System.Drawing.Point(67, 183);
            this.lblTimesTables.Name = "lblTimesTables";
            this.lblTimesTables.Size = new System.Drawing.Size(73, 13);
            this.lblTimesTables.TabIndex = 4;
            this.lblTimesTables.Text = "Times Tables:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimesTables);
            this.Controls.Add(this.txtTimesTables);
            this.Controls.Add(this.btnTimesTables);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Times Tables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnTimesTables;
        private System.Windows.Forms.TextBox txtTimesTables;
        private System.Windows.Forms.Label lblTimesTables;
    }
}

