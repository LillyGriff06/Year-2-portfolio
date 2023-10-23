namespace CalculatorOOP
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnCreateCalculator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(91, 144);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(252, 144);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 1;
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(111, 128);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(56, 13);
            this.lblNumber1.TabIndex = 2;
            this.lblNumber1.Text = "Number 1:";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(278, 128);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(56, 13);
            this.lblNumber2.TabIndex = 3;
            this.lblNumber2.Text = "Number 2:";
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(81, 219);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(120, 50);
            this.btnAddition.TabIndex = 4;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(242, 219);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(120, 50);
            this.btnSubtraction.TabIndex = 5;
            this.btnSubtraction.Text = "Subtraction";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(81, 301);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(120, 50);
            this.btnMultiplication.TabIndex = 6;
            this.btnMultiplication.Text = "Multiplication";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(242, 301);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(120, 50);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnCreateCalculator
            // 
            this.btnCreateCalculator.Location = new System.Drawing.Point(35, 33);
            this.btnCreateCalculator.Name = "btnCreateCalculator";
            this.btnCreateCalculator.Size = new System.Drawing.Size(379, 21);
            this.btnCreateCalculator.TabIndex = 8;
            this.btnCreateCalculator.Text = "Turn calculator on";
            this.btnCreateCalculator.UseVisualStyleBackColor = true;
            this.btnCreateCalculator.Click += new System.EventHandler(this.btnCreateCalculator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.btnCreateCalculator);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnCreateCalculator;
    }
}

