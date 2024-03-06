namespace TemperatureExceptionHandling
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
            this.txtCelsius1 = new System.Windows.Forms.TextBox();
            this.lblInputC = new System.Windows.Forms.Label();
            this.btnConvertCtoF = new System.Windows.Forms.Button();
            this.txtFahrenheit1 = new System.Windows.Forms.TextBox();
            this.lblOutputF = new System.Windows.Forms.Label();
            this.txtFahrenheit2 = new System.Windows.Forms.TextBox();
            this.txtCelsius2 = new System.Windows.Forms.TextBox();
            this.lblInputF = new System.Windows.Forms.Label();
            this.lblOutputC = new System.Windows.Forms.Label();
            this.btnConvertFtoC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCelsius1
            // 
            this.txtCelsius1.Location = new System.Drawing.Point(33, 50);
            this.txtCelsius1.Name = "txtCelsius1";
            this.txtCelsius1.Size = new System.Drawing.Size(125, 20);
            this.txtCelsius1.TabIndex = 0;
            // 
            // lblInputC
            // 
            this.lblInputC.AutoSize = true;
            this.lblInputC.Location = new System.Drawing.Point(30, 34);
            this.lblInputC.Name = "lblInputC";
            this.lblInputC.Size = new System.Drawing.Size(71, 13);
            this.lblInputC.TabIndex = 1;
            this.lblInputC.Text = "Input Celcius:";
            // 
            // btnConvertCtoF
            // 
            this.btnConvertCtoF.Location = new System.Drawing.Point(59, 96);
            this.btnConvertCtoF.Name = "btnConvertCtoF";
            this.btnConvertCtoF.Size = new System.Drawing.Size(75, 23);
            this.btnConvertCtoF.TabIndex = 2;
            this.btnConvertCtoF.Text = "Convert";
            this.btnConvertCtoF.UseVisualStyleBackColor = true;
            this.btnConvertCtoF.Click += new System.EventHandler(this.btnConvertCtoF_Click);
            // 
            // txtFahrenheit1
            // 
            this.txtFahrenheit1.Location = new System.Drawing.Point(33, 162);
            this.txtFahrenheit1.Name = "txtFahrenheit1";
            this.txtFahrenheit1.Size = new System.Drawing.Size(125, 20);
            this.txtFahrenheit1.TabIndex = 3;
            // 
            // lblOutputF
            // 
            this.lblOutputF.AutoSize = true;
            this.lblOutputF.Location = new System.Drawing.Point(30, 146);
            this.lblOutputF.Name = "lblOutputF";
            this.lblOutputF.Size = new System.Drawing.Size(95, 13);
            this.lblOutputF.TabIndex = 4;
            this.lblOutputF.Text = "Output Fahrenheit:";
            // 
            // txtFahrenheit2
            // 
            this.txtFahrenheit2.Location = new System.Drawing.Point(40, 50);
            this.txtFahrenheit2.Name = "txtFahrenheit2";
            this.txtFahrenheit2.Size = new System.Drawing.Size(125, 20);
            this.txtFahrenheit2.TabIndex = 5;
            // 
            // txtCelsius2
            // 
            this.txtCelsius2.Location = new System.Drawing.Point(40, 162);
            this.txtCelsius2.Name = "txtCelsius2";
            this.txtCelsius2.Size = new System.Drawing.Size(125, 20);
            this.txtCelsius2.TabIndex = 6;
            // 
            // lblInputF
            // 
            this.lblInputF.AutoSize = true;
            this.lblInputF.Location = new System.Drawing.Point(37, 34);
            this.lblInputF.Name = "lblInputF";
            this.lblInputF.Size = new System.Drawing.Size(87, 13);
            this.lblInputF.TabIndex = 7;
            this.lblInputF.Text = "Input Fahrenheit:";
            // 
            // lblOutputC
            // 
            this.lblOutputC.AutoSize = true;
            this.lblOutputC.Location = new System.Drawing.Point(37, 146);
            this.lblOutputC.Name = "lblOutputC";
            this.lblOutputC.Size = new System.Drawing.Size(79, 13);
            this.lblOutputC.TabIndex = 8;
            this.lblOutputC.Text = "Output Celcius:";
            // 
            // btnConvertFtoC
            // 
            this.btnConvertFtoC.Location = new System.Drawing.Point(65, 96);
            this.btnConvertFtoC.Name = "btnConvertFtoC";
            this.btnConvertFtoC.Size = new System.Drawing.Size(75, 23);
            this.btnConvertFtoC.TabIndex = 9;
            this.btnConvertFtoC.Text = "Convert";
            this.btnConvertFtoC.UseVisualStyleBackColor = true;
            this.btnConvertFtoC.Click += new System.EventHandler(this.btnConvertFtoC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFahrenheit1);
            this.groupBox1.Controls.Add(this.txtCelsius1);
            this.groupBox1.Controls.Add(this.lblInputC);
            this.groupBox1.Controls.Add(this.btnConvertCtoF);
            this.groupBox1.Controls.Add(this.lblOutputF);
            this.groupBox1.Location = new System.Drawing.Point(144, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 228);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Celsius to Fahrenheit";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOutputC);
            this.groupBox2.Controls.Add(this.btnConvertFtoC);
            this.groupBox2.Controls.Add(this.txtCelsius2);
            this.groupBox2.Controls.Add(this.txtFahrenheit2);
            this.groupBox2.Controls.Add(this.lblInputF);
            this.groupBox2.Location = new System.Drawing.Point(453, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 228);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fahrenheit to Celsius";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Converting temperatures";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCelsius1;
        private System.Windows.Forms.Label lblInputC;
        private System.Windows.Forms.Button btnConvertCtoF;
        private System.Windows.Forms.TextBox txtFahrenheit1;
        private System.Windows.Forms.Label lblOutputF;
        private System.Windows.Forms.TextBox txtFahrenheit2;
        private System.Windows.Forms.TextBox txtCelsius2;
        private System.Windows.Forms.Label lblInputF;
        private System.Windows.Forms.Label lblOutputC;
        private System.Windows.Forms.Button btnConvertFtoC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

