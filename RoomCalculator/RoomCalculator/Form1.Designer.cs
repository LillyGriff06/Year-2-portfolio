namespace RoomCalculator
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
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.txtRoomLength = new System.Windows.Forms.TextBox();
            this.txtRoomWidth = new System.Windows.Forms.TextBox();
            this.txtRoomArea = new System.Windows.Forms.TextBox();
            this.lblRoomLength = new System.Windows.Forms.Label();
            this.lblRoomWidth = new System.Windows.Forms.Label();
            this.lblRoomArea = new System.Windows.Forms.Label();
            this.txtRoomHeight = new System.Windows.Forms.TextBox();
            this.lblRoomHeight = new System.Windows.Forms.Label();
            this.btnCalculateVolume = new System.Windows.Forms.Button();
            this.txtRoomVolume = new System.Windows.Forms.TextBox();
            this.lblRoomVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.Location = new System.Drawing.Point(150, 268);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(166, 47);
            this.btnCalculateArea.TabIndex = 0;
            this.btnCalculateArea.Text = "Calculate Room Area";
            this.btnCalculateArea.UseVisualStyleBackColor = true;
            this.btnCalculateArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRoomLength
            // 
            this.txtRoomLength.Location = new System.Drawing.Point(150, 43);
            this.txtRoomLength.Multiline = true;
            this.txtRoomLength.Name = "txtRoomLength";
            this.txtRoomLength.Size = new System.Drawing.Size(493, 40);
            this.txtRoomLength.TabIndex = 1;
            // 
            // txtRoomWidth
            // 
            this.txtRoomWidth.Location = new System.Drawing.Point(150, 118);
            this.txtRoomWidth.Multiline = true;
            this.txtRoomWidth.Name = "txtRoomWidth";
            this.txtRoomWidth.Size = new System.Drawing.Size(493, 40);
            this.txtRoomWidth.TabIndex = 2;
            // 
            // txtRoomArea
            // 
            this.txtRoomArea.Location = new System.Drawing.Point(150, 378);
            this.txtRoomArea.Multiline = true;
            this.txtRoomArea.Name = "txtRoomArea";
            this.txtRoomArea.Size = new System.Drawing.Size(206, 37);
            this.txtRoomArea.TabIndex = 3;
            // 
            // lblRoomLength
            // 
            this.lblRoomLength.AutoSize = true;
            this.lblRoomLength.Location = new System.Drawing.Point(147, 27);
            this.lblRoomLength.Name = "lblRoomLength";
            this.lblRoomLength.Size = new System.Drawing.Size(90, 13);
            this.lblRoomLength.TabIndex = 4;
            this.lblRoomLength.Text = "Enter room length";
            // 
            // lblRoomWidth
            // 
            this.lblRoomWidth.AutoSize = true;
            this.lblRoomWidth.Location = new System.Drawing.Point(147, 102);
            this.lblRoomWidth.Name = "lblRoomWidth";
            this.lblRoomWidth.Size = new System.Drawing.Size(86, 13);
            this.lblRoomWidth.TabIndex = 5;
            this.lblRoomWidth.Text = "Enter room width";
            // 
            // lblRoomArea
            // 
            this.lblRoomArea.AutoSize = true;
            this.lblRoomArea.Location = new System.Drawing.Point(147, 362);
            this.lblRoomArea.Name = "lblRoomArea";
            this.lblRoomArea.Size = new System.Drawing.Size(62, 13);
            this.lblRoomArea.TabIndex = 6;
            this.lblRoomArea.Text = "Room area:";
            // 
            // txtRoomHeight
            // 
            this.txtRoomHeight.Location = new System.Drawing.Point(150, 199);
            this.txtRoomHeight.Multiline = true;
            this.txtRoomHeight.Name = "txtRoomHeight";
            this.txtRoomHeight.Size = new System.Drawing.Size(493, 40);
            this.txtRoomHeight.TabIndex = 7;
            // 
            // lblRoomHeight
            // 
            this.lblRoomHeight.AutoSize = true;
            this.lblRoomHeight.Location = new System.Drawing.Point(147, 183);
            this.lblRoomHeight.Name = "lblRoomHeight";
            this.lblRoomHeight.Size = new System.Drawing.Size(90, 13);
            this.lblRoomHeight.TabIndex = 8;
            this.lblRoomHeight.Text = "Enter room height";
            // 
            // btnCalculateVolume
            // 
            this.btnCalculateVolume.Location = new System.Drawing.Point(477, 268);
            this.btnCalculateVolume.Name = "btnCalculateVolume";
            this.btnCalculateVolume.Size = new System.Drawing.Size(166, 47);
            this.btnCalculateVolume.TabIndex = 9;
            this.btnCalculateVolume.Text = "Calculate Room Volume";
            this.btnCalculateVolume.UseVisualStyleBackColor = true;
            this.btnCalculateVolume.Click += new System.EventHandler(this.btnCalculateVolume_Click);
            // 
            // txtRoomVolume
            // 
            this.txtRoomVolume.Location = new System.Drawing.Point(437, 378);
            this.txtRoomVolume.Multiline = true;
            this.txtRoomVolume.Name = "txtRoomVolume";
            this.txtRoomVolume.Size = new System.Drawing.Size(206, 37);
            this.txtRoomVolume.TabIndex = 10;
            // 
            // lblRoomVolume
            // 
            this.lblRoomVolume.AutoSize = true;
            this.lblRoomVolume.Location = new System.Drawing.Point(434, 362);
            this.lblRoomVolume.Name = "lblRoomVolume";
            this.lblRoomVolume.Size = new System.Drawing.Size(75, 13);
            this.lblRoomVolume.TabIndex = 11;
            this.lblRoomVolume.Text = "Room volume:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRoomVolume);
            this.Controls.Add(this.txtRoomVolume);
            this.Controls.Add(this.btnCalculateVolume);
            this.Controls.Add(this.lblRoomHeight);
            this.Controls.Add(this.txtRoomHeight);
            this.Controls.Add(this.lblRoomArea);
            this.Controls.Add(this.lblRoomWidth);
            this.Controls.Add(this.lblRoomLength);
            this.Controls.Add(this.txtRoomArea);
            this.Controls.Add(this.txtRoomWidth);
            this.Controls.Add(this.txtRoomLength);
            this.Controls.Add(this.btnCalculateArea);
            this.Name = "Form1";
            this.Text = "Room Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateArea;
        private System.Windows.Forms.TextBox txtRoomLength;
        private System.Windows.Forms.TextBox txtRoomWidth;
        private System.Windows.Forms.TextBox txtRoomArea;
        private System.Windows.Forms.Label lblRoomLength;
        private System.Windows.Forms.Label lblRoomWidth;
        private System.Windows.Forms.Label lblRoomArea;
        private System.Windows.Forms.TextBox txtRoomHeight;
        private System.Windows.Forms.Label lblRoomHeight;
        private System.Windows.Forms.Button btnCalculateVolume;
        private System.Windows.Forms.TextBox txtRoomVolume;
        private System.Windows.Forms.Label lblRoomVolume;
    }
}

