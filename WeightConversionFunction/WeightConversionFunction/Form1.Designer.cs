namespace WeightConversionFunction
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
            this.txtOunces = new System.Windows.Forms.TextBox();
            this.lblOunces = new System.Windows.Forms.Label();
            this.txtPounds = new System.Windows.Forms.TextBox();
            this.lblPounds = new System.Windows.Forms.Label();
            this.txtGrams = new System.Windows.Forms.TextBox();
            this.lblGrams = new System.Windows.Forms.Label();
            this.txtKilogrammes = new System.Windows.Forms.TextBox();
            this.lblKilogrammes = new System.Windows.Forms.Label();
            this.btnConvertWeight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOunces
            // 
            this.txtOunces.Location = new System.Drawing.Point(90, 59);
            this.txtOunces.Name = "txtOunces";
            this.txtOunces.Size = new System.Drawing.Size(300, 20);
            this.txtOunces.TabIndex = 0;
            // 
            // lblOunces
            // 
            this.lblOunces.AutoSize = true;
            this.lblOunces.Location = new System.Drawing.Point(90, 40);
            this.lblOunces.Name = "lblOunces";
            this.lblOunces.Size = new System.Drawing.Size(136, 13);
            this.lblOunces.TabIndex = 1;
            this.lblOunces.Text = "Enter the weight in ounces:";
            // 
            // txtPounds
            // 
            this.txtPounds.Location = new System.Drawing.Point(90, 227);
            this.txtPounds.Name = "txtPounds";
            this.txtPounds.Size = new System.Drawing.Size(300, 20);
            this.txtPounds.TabIndex = 2;
            // 
            // lblPounds
            // 
            this.lblPounds.AutoSize = true;
            this.lblPounds.Location = new System.Drawing.Point(90, 211);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(46, 13);
            this.lblPounds.TabIndex = 3;
            this.lblPounds.Text = "Pounds:";
            // 
            // txtGrams
            // 
            this.txtGrams.Location = new System.Drawing.Point(90, 290);
            this.txtGrams.Name = "txtGrams";
            this.txtGrams.Size = new System.Drawing.Size(300, 20);
            this.txtGrams.TabIndex = 4;
            // 
            // lblGrams
            // 
            this.lblGrams.AutoSize = true;
            this.lblGrams.Location = new System.Drawing.Point(90, 274);
            this.lblGrams.Name = "lblGrams";
            this.lblGrams.Size = new System.Drawing.Size(40, 13);
            this.lblGrams.TabIndex = 5;
            this.lblGrams.Text = "Grams:";
            // 
            // txtKilogrammes
            // 
            this.txtKilogrammes.Location = new System.Drawing.Point(90, 352);
            this.txtKilogrammes.Name = "txtKilogrammes";
            this.txtKilogrammes.Size = new System.Drawing.Size(300, 20);
            this.txtKilogrammes.TabIndex = 6;
            // 
            // lblKilogrammes
            // 
            this.lblKilogrammes.AutoSize = true;
            this.lblKilogrammes.Location = new System.Drawing.Point(90, 336);
            this.lblKilogrammes.Name = "lblKilogrammes";
            this.lblKilogrammes.Size = new System.Drawing.Size(69, 13);
            this.lblKilogrammes.TabIndex = 7;
            this.lblKilogrammes.Text = "Kilogrammes:";
            // 
            // btnConvertWeight
            // 
            this.btnConvertWeight.Location = new System.Drawing.Point(163, 127);
            this.btnConvertWeight.Name = "btnConvertWeight";
            this.btnConvertWeight.Size = new System.Drawing.Size(150, 50);
            this.btnConvertWeight.TabIndex = 8;
            this.btnConvertWeight.Text = "Convert weight";
            this.btnConvertWeight.UseVisualStyleBackColor = true;
            this.btnConvertWeight.Click += new System.EventHandler(this.btnConvertWeight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.btnConvertWeight);
            this.Controls.Add(this.lblKilogrammes);
            this.Controls.Add(this.txtKilogrammes);
            this.Controls.Add(this.lblGrams);
            this.Controls.Add(this.txtGrams);
            this.Controls.Add(this.lblPounds);
            this.Controls.Add(this.txtPounds);
            this.Controls.Add(this.lblOunces);
            this.Controls.Add(this.txtOunces);
            this.Name = "Form1";
            this.Text = "Weight converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOunces;
        private System.Windows.Forms.Label lblOunces;
        private System.Windows.Forms.TextBox txtPounds;
        private System.Windows.Forms.Label lblPounds;
        private System.Windows.Forms.TextBox txtGrams;
        private System.Windows.Forms.Label lblGrams;
        private System.Windows.Forms.TextBox txtKilogrammes;
        private System.Windows.Forms.Label lblKilogrammes;
        private System.Windows.Forms.Button btnConvertWeight;
    }
}

