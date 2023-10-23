namespace PythagorasTheorumFunction
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
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.lblSideA = new System.Windows.Forms.Label();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.lblSideB = new System.Windows.Forms.Label();
            this.txtHypotenuse = new System.Windows.Forms.TextBox();
            this.lblHypotenuse = new System.Windows.Forms.Label();
            this.btnHypotenuse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(55, 62);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(300, 20);
            this.txtSideA.TabIndex = 0;
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Location = new System.Drawing.Point(55, 43);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(128, 13);
            this.lblSideA.TabIndex = 1;
            this.lblSideA.Text = "Input the length of side A:";
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(55, 133);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(300, 20);
            this.txtSideB.TabIndex = 2;
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Location = new System.Drawing.Point(58, 114);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(128, 13);
            this.lblSideB.TabIndex = 3;
            this.lblSideB.Text = "Input the length of side B:";
            // 
            // txtHypotenuse
            // 
            this.txtHypotenuse.Location = new System.Drawing.Point(55, 301);
            this.txtHypotenuse.Name = "txtHypotenuse";
            this.txtHypotenuse.Size = new System.Drawing.Size(300, 20);
            this.txtHypotenuse.TabIndex = 4;
            // 
            // lblHypotenuse
            // 
            this.lblHypotenuse.AutoSize = true;
            this.lblHypotenuse.Location = new System.Drawing.Point(58, 282);
            this.lblHypotenuse.Name = "lblHypotenuse";
            this.lblHypotenuse.Size = new System.Drawing.Size(100, 13);
            this.lblHypotenuse.TabIndex = 5;
            this.lblHypotenuse.Text = "Output hypotenuse:";
            // 
            // btnHypotenuse
            // 
            this.btnHypotenuse.Location = new System.Drawing.Point(122, 193);
            this.btnHypotenuse.Name = "btnHypotenuse";
            this.btnHypotenuse.Size = new System.Drawing.Size(150, 50);
            this.btnHypotenuse.TabIndex = 6;
            this.btnHypotenuse.Text = "Calculate hypotenuse";
            this.btnHypotenuse.UseVisualStyleBackColor = true;
            this.btnHypotenuse.Click += new System.EventHandler(this.btnHypotenuse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 385);
            this.Controls.Add(this.btnHypotenuse);
            this.Controls.Add(this.lblHypotenuse);
            this.Controls.Add(this.txtHypotenuse);
            this.Controls.Add(this.lblSideB);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.lblSideA);
            this.Controls.Add(this.txtSideA);
            this.Name = "Form1";
            this.Text = "Finding the hypotenuse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.TextBox txtHypotenuse;
        private System.Windows.Forms.Label lblHypotenuse;
        private System.Windows.Forms.Button btnHypotenuse;
    }
}

