namespace BirthDateToZodiac
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
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtZodiac = new System.Windows.Forms.TextBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblZodiac = new System.Windows.Forms.Label();
            this.btnConvertDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(59, 60);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(200, 20);
            this.txtMonth.TabIndex = 0;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(59, 127);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(200, 20);
            this.txtDay.TabIndex = 1;
            // 
            // txtZodiac
            // 
            this.txtZodiac.Location = new System.Drawing.Point(59, 319);
            this.txtZodiac.Name = "txtZodiac";
            this.txtZodiac.Size = new System.Drawing.Size(200, 20);
            this.txtZodiac.TabIndex = 2;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(59, 41);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(67, 13);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "Enter month:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(59, 108);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(55, 13);
            this.lblDay.TabIndex = 4;
            this.lblDay.Text = "Enter day:";
            // 
            // lblZodiac
            // 
            this.lblZodiac.AutoSize = true;
            this.lblZodiac.Location = new System.Drawing.Point(59, 300);
            this.lblZodiac.Name = "lblZodiac";
            this.lblZodiac.Size = new System.Drawing.Size(76, 13);
            this.lblZodiac.TabIndex = 5;
            this.lblZodiac.Text = "Output zodiac:";
            // 
            // btnConvertDate
            // 
            this.btnConvertDate.Location = new System.Drawing.Point(84, 209);
            this.btnConvertDate.Name = "btnConvertDate";
            this.btnConvertDate.Size = new System.Drawing.Size(150, 40);
            this.btnConvertDate.TabIndex = 6;
            this.btnConvertDate.Text = "Date to Zodiac";
            this.btnConvertDate.UseVisualStyleBackColor = true;
            this.btnConvertDate.Click += new System.EventHandler(this.btnConvertDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvertDate);
            this.Controls.Add(this.lblZodiac);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtZodiac);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtMonth);
            this.Name = "Form1";
            this.Text = "Date to Zodiac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtZodiac;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblZodiac;
        private System.Windows.Forms.Button btnConvertDate;
    }
}

