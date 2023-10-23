namespace LetterGradeToGradePoint
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
            this.txtLetterGrade = new System.Windows.Forms.TextBox();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.btnConvertLetterGrade = new System.Windows.Forms.Button();
            this.txtGradePoints = new System.Windows.Forms.TextBox();
            this.lblGradePoints = new System.Windows.Forms.Label();
            this.txtGradePointIn = new System.Windows.Forms.TextBox();
            this.lblGradePointIn = new System.Windows.Forms.Label();
            this.btnConvertGradePoint = new System.Windows.Forms.Button();
            this.txtLetterGradeOut = new System.Windows.Forms.TextBox();
            this.lblLetterGradeOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLetterGrade
            // 
            this.txtLetterGrade.Location = new System.Drawing.Point(90, 65);
            this.txtLetterGrade.Name = "txtLetterGrade";
            this.txtLetterGrade.Size = new System.Drawing.Size(100, 20);
            this.txtLetterGrade.TabIndex = 0;
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.AutoSize = true;
            this.lblLetterGrade.Location = new System.Drawing.Point(90, 46);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(96, 13);
            this.lblLetterGrade.TabIndex = 1;
            this.lblLetterGrade.Text = "Input Letter Grade:";
            // 
            // btnConvertLetterGrade
            // 
            this.btnConvertLetterGrade.Location = new System.Drawing.Point(104, 125);
            this.btnConvertLetterGrade.Name = "btnConvertLetterGrade";
            this.btnConvertLetterGrade.Size = new System.Drawing.Size(75, 23);
            this.btnConvertLetterGrade.TabIndex = 2;
            this.btnConvertLetterGrade.Text = "Convert Letter Grade";
            this.btnConvertLetterGrade.UseVisualStyleBackColor = true;
            this.btnConvertLetterGrade.Click += new System.EventHandler(this.btnConvertLetterGrade_Click);
            // 
            // txtGradePoints
            // 
            this.txtGradePoints.Location = new System.Drawing.Point(90, 197);
            this.txtGradePoints.Name = "txtGradePoints";
            this.txtGradePoints.Size = new System.Drawing.Size(100, 20);
            this.txtGradePoints.TabIndex = 3;
            // 
            // lblGradePoints
            // 
            this.lblGradePoints.AutoSize = true;
            this.lblGradePoints.Location = new System.Drawing.Point(90, 178);
            this.lblGradePoints.Name = "lblGradePoints";
            this.lblGradePoints.Size = new System.Drawing.Size(106, 13);
            this.lblGradePoints.TabIndex = 4;
            this.lblGradePoints.Text = "Output Grade Points:";
            // 
            // txtGradePointIn
            // 
            this.txtGradePointIn.Location = new System.Drawing.Point(392, 65);
            this.txtGradePointIn.Name = "txtGradePointIn";
            this.txtGradePointIn.Size = new System.Drawing.Size(100, 20);
            this.txtGradePointIn.TabIndex = 5;
            // 
            // lblGradePointIn
            // 
            this.lblGradePointIn.AutoSize = true;
            this.lblGradePointIn.Location = new System.Drawing.Point(392, 45);
            this.lblGradePointIn.Name = "lblGradePointIn";
            this.lblGradePointIn.Size = new System.Drawing.Size(98, 13);
            this.lblGradePointIn.TabIndex = 6;
            this.lblGradePointIn.Text = "Input Grade Points:";
            // 
            // btnConvertGradePoint
            // 
            this.btnConvertGradePoint.Location = new System.Drawing.Point(406, 125);
            this.btnConvertGradePoint.Name = "btnConvertGradePoint";
            this.btnConvertGradePoint.Size = new System.Drawing.Size(75, 23);
            this.btnConvertGradePoint.TabIndex = 7;
            this.btnConvertGradePoint.Text = "Convert";
            this.btnConvertGradePoint.UseVisualStyleBackColor = true;
            this.btnConvertGradePoint.Click += new System.EventHandler(this.btnConvertGradePoint_Click);
            // 
            // txtLetterGradeOut
            // 
            this.txtLetterGradeOut.Location = new System.Drawing.Point(392, 197);
            this.txtLetterGradeOut.Name = "txtLetterGradeOut";
            this.txtLetterGradeOut.Size = new System.Drawing.Size(100, 20);
            this.txtLetterGradeOut.TabIndex = 8;
            // 
            // lblLetterGradeOut
            // 
            this.lblLetterGradeOut.AutoSize = true;
            this.lblLetterGradeOut.Location = new System.Drawing.Point(392, 178);
            this.lblLetterGradeOut.Name = "lblLetterGradeOut";
            this.lblLetterGradeOut.Size = new System.Drawing.Size(104, 13);
            this.lblLetterGradeOut.TabIndex = 9;
            this.lblLetterGradeOut.Text = "Output Letter Grade:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLetterGradeOut);
            this.Controls.Add(this.txtLetterGradeOut);
            this.Controls.Add(this.btnConvertGradePoint);
            this.Controls.Add(this.lblGradePointIn);
            this.Controls.Add(this.txtGradePointIn);
            this.Controls.Add(this.lblGradePoints);
            this.Controls.Add(this.txtGradePoints);
            this.Controls.Add(this.btnConvertLetterGrade);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.txtLetterGrade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLetterGrade;
        private System.Windows.Forms.Label lblLetterGrade;
        private System.Windows.Forms.Button btnConvertLetterGrade;
        private System.Windows.Forms.TextBox txtGradePoints;
        private System.Windows.Forms.Label lblGradePoints;
        private System.Windows.Forms.TextBox txtGradePointIn;
        private System.Windows.Forms.Label lblGradePointIn;
        private System.Windows.Forms.Button btnConvertGradePoint;
        private System.Windows.Forms.TextBox txtLetterGradeOut;
        private System.Windows.Forms.Label lblLetterGradeOut;
    }
}

