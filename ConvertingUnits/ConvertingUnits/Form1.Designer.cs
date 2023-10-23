namespace ConvertingUnits
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
            this.txtMetre = new System.Windows.Forms.TextBox();
            this.lblMetre = new System.Windows.Forms.Label();
            this.txtKilogram = new System.Windows.Forms.TextBox();
            this.lblKilogram = new System.Windows.Forms.Label();
            this.txtLitre = new System.Windows.Forms.TextBox();
            this.lblLitre = new System.Windows.Forms.Label();
            this.txtGallon = new System.Windows.Forms.TextBox();
            this.lblGallon = new System.Windows.Forms.Label();
            this.txtPound = new System.Windows.Forms.TextBox();
            this.lblPound = new System.Windows.Forms.Label();
            this.txtFoot = new System.Windows.Forms.TextBox();
            this.lblFoot = new System.Windows.Forms.Label();
            this.btnConvertMetres = new System.Windows.Forms.Button();
            this.btnConvertKilogrames = new System.Windows.Forms.Button();
            this.btnConvertLitres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMetre
            // 
            this.txtMetre.Location = new System.Drawing.Point(12, 81);
            this.txtMetre.Name = "txtMetre";
            this.txtMetre.Size = new System.Drawing.Size(215, 20);
            this.txtMetre.TabIndex = 0;
            // 
            // lblMetre
            // 
            this.lblMetre.AutoSize = true;
            this.lblMetre.Location = new System.Drawing.Point(9, 65);
            this.lblMetre.Name = "lblMetre";
            this.lblMetre.Size = new System.Drawing.Size(188, 13);
            this.lblMetre.TabIndex = 1;
            this.lblMetre.Text = "Enter the number of metres to convert:";
            // 
            // txtKilogram
            // 
            this.txtKilogram.Location = new System.Drawing.Point(291, 81);
            this.txtKilogram.Name = "txtKilogram";
            this.txtKilogram.Size = new System.Drawing.Size(215, 20);
            this.txtKilogram.TabIndex = 2;
            // 
            // lblKilogram
            // 
            this.lblKilogram.AutoSize = true;
            this.lblKilogram.Location = new System.Drawing.Point(288, 65);
            this.lblKilogram.Name = "lblKilogram";
            this.lblKilogram.Size = new System.Drawing.Size(215, 13);
            this.lblKilogram.TabIndex = 3;
            this.lblKilogram.Text = "Enter the number of kilogrammes to convert:";
            // 
            // txtLitre
            // 
            this.txtLitre.Location = new System.Drawing.Point(570, 81);
            this.txtLitre.Name = "txtLitre";
            this.txtLitre.Size = new System.Drawing.Size(215, 20);
            this.txtLitre.TabIndex = 4;
            // 
            // lblLitre
            // 
            this.lblLitre.AutoSize = true;
            this.lblLitre.Location = new System.Drawing.Point(567, 65);
            this.lblLitre.Name = "lblLitre";
            this.lblLitre.Size = new System.Drawing.Size(178, 13);
            this.lblLitre.TabIndex = 5;
            this.lblLitre.Text = "Enter the number of litres to convert:";
            // 
            // txtGallon
            // 
            this.txtGallon.Location = new System.Drawing.Point(570, 292);
            this.txtGallon.Name = "txtGallon";
            this.txtGallon.Size = new System.Drawing.Size(215, 20);
            this.txtGallon.TabIndex = 6;
            // 
            // lblGallon
            // 
            this.lblGallon.AutoSize = true;
            this.lblGallon.Location = new System.Drawing.Point(567, 276);
            this.lblGallon.Name = "lblGallon";
            this.lblGallon.Size = new System.Drawing.Size(45, 13);
            this.lblGallon.TabIndex = 7;
            this.lblGallon.Text = "Gallons:";
            // 
            // txtPound
            // 
            this.txtPound.Location = new System.Drawing.Point(291, 292);
            this.txtPound.Name = "txtPound";
            this.txtPound.Size = new System.Drawing.Size(215, 20);
            this.txtPound.TabIndex = 8;
            // 
            // lblPound
            // 
            this.lblPound.AutoSize = true;
            this.lblPound.Location = new System.Drawing.Point(291, 275);
            this.lblPound.Name = "lblPound";
            this.lblPound.Size = new System.Drawing.Size(46, 13);
            this.lblPound.TabIndex = 9;
            this.lblPound.Text = "Pounds:";
            // 
            // txtFoot
            // 
            this.txtFoot.Location = new System.Drawing.Point(12, 291);
            this.txtFoot.Name = "txtFoot";
            this.txtFoot.Size = new System.Drawing.Size(215, 20);
            this.txtFoot.TabIndex = 10;
            // 
            // lblFoot
            // 
            this.lblFoot.AutoSize = true;
            this.lblFoot.Location = new System.Drawing.Point(12, 275);
            this.lblFoot.Name = "lblFoot";
            this.lblFoot.Size = new System.Drawing.Size(31, 13);
            this.lblFoot.TabIndex = 11;
            this.lblFoot.Text = "Feet:";
            // 
            // btnConvertMetres
            // 
            this.btnConvertMetres.Location = new System.Drawing.Point(43, 163);
            this.btnConvertMetres.Name = "btnConvertMetres";
            this.btnConvertMetres.Size = new System.Drawing.Size(145, 65);
            this.btnConvertMetres.TabIndex = 12;
            this.btnConvertMetres.Text = "Convert metres to feet";
            this.btnConvertMetres.UseVisualStyleBackColor = true;
            this.btnConvertMetres.Click += new System.EventHandler(this.btnConvertMetres_Click);
            // 
            // btnConvertKilogrames
            // 
            this.btnConvertKilogrames.Location = new System.Drawing.Point(331, 163);
            this.btnConvertKilogrames.Name = "btnConvertKilogrames";
            this.btnConvertKilogrames.Size = new System.Drawing.Size(145, 65);
            this.btnConvertKilogrames.TabIndex = 13;
            this.btnConvertKilogrames.Text = "Convert kilogrammes to pounds";
            this.btnConvertKilogrames.UseVisualStyleBackColor = true;
            this.btnConvertKilogrames.Click += new System.EventHandler(this.btnConvertKilogrames_Click);
            // 
            // btnConvertLitres
            // 
            this.btnConvertLitres.Location = new System.Drawing.Point(606, 163);
            this.btnConvertLitres.Name = "btnConvertLitres";
            this.btnConvertLitres.Size = new System.Drawing.Size(145, 65);
            this.btnConvertLitres.TabIndex = 14;
            this.btnConvertLitres.Text = "Convert litres to gallons";
            this.btnConvertLitres.UseVisualStyleBackColor = true;
            this.btnConvertLitres.Click += new System.EventHandler(this.btnConvertLitres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvertLitres);
            this.Controls.Add(this.btnConvertKilogrames);
            this.Controls.Add(this.btnConvertMetres);
            this.Controls.Add(this.lblFoot);
            this.Controls.Add(this.txtFoot);
            this.Controls.Add(this.lblPound);
            this.Controls.Add(this.txtPound);
            this.Controls.Add(this.lblGallon);
            this.Controls.Add(this.txtGallon);
            this.Controls.Add(this.lblLitre);
            this.Controls.Add(this.txtLitre);
            this.Controls.Add(this.lblKilogram);
            this.Controls.Add(this.txtKilogram);
            this.Controls.Add(this.lblMetre);
            this.Controls.Add(this.txtMetre);
            this.Name = "Form1";
            this.Text = "Unit Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetre;
        private System.Windows.Forms.Label lblMetre;
        private System.Windows.Forms.TextBox txtKilogram;
        private System.Windows.Forms.Label lblKilogram;
        private System.Windows.Forms.TextBox txtLitre;
        private System.Windows.Forms.Label lblLitre;
        private System.Windows.Forms.TextBox txtGallon;
        private System.Windows.Forms.Label lblGallon;
        private System.Windows.Forms.TextBox txtPound;
        private System.Windows.Forms.Label lblPound;
        private System.Windows.Forms.TextBox txtFoot;
        private System.Windows.Forms.Label lblFoot;
        private System.Windows.Forms.Button btnConvertMetres;
        private System.Windows.Forms.Button btnConvertKilogrames;
        private System.Windows.Forms.Button btnConvertLitres;
    }
}

