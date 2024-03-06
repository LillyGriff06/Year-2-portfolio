namespace PeopleDB2024
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTelephoneNumber = new System.Windows.Forms.Label();
            this.btnReadPeople = new System.Windows.Forms.Button();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDeleteAge = new System.Windows.Forms.Label();
            this.txtDeleteAge = new System.Windows.Forms.TextBox();
            this.lblDeleteName = new System.Windows.Forms.Label();
            this.txtDeleteName = new System.Windows.Forms.TextBox();
            this.lblUpdateAge = new System.Windows.Forms.Label();
            this.txtEditAge = new System.Windows.Forms.TextBox();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.btnUpdatePerson = new System.Windows.Forms.Button();
            this.lblUpdateID = new System.Windows.Forms.Label();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.lblUpdateTelephoneNumber = new System.Windows.Forms.Label();
            this.txtEditTelephoneNumber = new System.Windows.Forms.TextBox();
            this.lblUpdateAddress = new System.Windows.Forms.Label();
            this.txtEditAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(55, 94);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(130, 20);
            this.txtAge.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(58, 78);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age:";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(151, 142);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(90, 35);
            this.btnAddRecord.TabIndex = 4;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(203, 28);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(130, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.Location = new System.Drawing.Point(203, 94);
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(130, 20);
            this.txtTelephoneNumber.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(209, 12);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address:";
            // 
            // lblTelephoneNumber
            // 
            this.lblTelephoneNumber.AutoSize = true;
            this.lblTelephoneNumber.Location = new System.Drawing.Point(209, 78);
            this.lblTelephoneNumber.Name = "lblTelephoneNumber";
            this.lblTelephoneNumber.Size = new System.Drawing.Size(99, 13);
            this.lblTelephoneNumber.TabIndex = 8;
            this.lblTelephoneNumber.Text = "Telephone number:";
            // 
            // btnReadPeople
            // 
            this.btnReadPeople.Location = new System.Drawing.Point(151, 575);
            this.btnReadPeople.Name = "btnReadPeople";
            this.btnReadPeople.Size = new System.Drawing.Size(90, 35);
            this.btnReadPeople.TabIndex = 9;
            this.btnReadPeople.Text = "Read people";
            this.btnReadPeople.UseVisualStyleBackColor = true;
            this.btnReadPeople.Click += new System.EventHandler(this.btnReadPeople_Click);
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(12, 208);
            this.txtPeople.Multiline = true;
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(380, 350);
            this.txtPeople.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(570, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete person";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDeleteAge
            // 
            this.lblDeleteAge.AutoSize = true;
            this.lblDeleteAge.Location = new System.Drawing.Point(548, 78);
            this.lblDeleteAge.Name = "lblDeleteAge";
            this.lblDeleteAge.Size = new System.Drawing.Size(29, 13);
            this.lblDeleteAge.TabIndex = 15;
            this.lblDeleteAge.Text = "Age:";
            // 
            // txtDeleteAge
            // 
            this.txtDeleteAge.Location = new System.Drawing.Point(545, 94);
            this.txtDeleteAge.Name = "txtDeleteAge";
            this.txtDeleteAge.Size = new System.Drawing.Size(130, 20);
            this.txtDeleteAge.TabIndex = 14;
            this.txtDeleteAge.Text = "0";
            // 
            // lblDeleteName
            // 
            this.lblDeleteName.AutoSize = true;
            this.lblDeleteName.Location = new System.Drawing.Point(545, 12);
            this.lblDeleteName.Name = "lblDeleteName";
            this.lblDeleteName.Size = new System.Drawing.Size(38, 13);
            this.lblDeleteName.TabIndex = 13;
            this.lblDeleteName.Text = "Name:";
            // 
            // txtDeleteName
            // 
            this.txtDeleteName.Location = new System.Drawing.Point(545, 28);
            this.txtDeleteName.Name = "txtDeleteName";
            this.txtDeleteName.Size = new System.Drawing.Size(130, 20);
            this.txtDeleteName.TabIndex = 12;
            // 
            // lblUpdateAge
            // 
            this.lblUpdateAge.AutoSize = true;
            this.lblUpdateAge.Location = new System.Drawing.Point(467, 423);
            this.lblUpdateAge.Name = "lblUpdateAge";
            this.lblUpdateAge.Size = new System.Drawing.Size(29, 13);
            this.lblUpdateAge.TabIndex = 20;
            this.lblUpdateAge.Text = "Age:";
            // 
            // txtEditAge
            // 
            this.txtEditAge.Location = new System.Drawing.Point(464, 439);
            this.txtEditAge.Name = "txtEditAge";
            this.txtEditAge.Size = new System.Drawing.Size(130, 20);
            this.txtEditAge.TabIndex = 19;
            this.txtEditAge.Text = "0";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(467, 359);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(38, 13);
            this.lblUpdateName.TabIndex = 18;
            this.lblUpdateName.Text = "Name:";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(464, 375);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(130, 20);
            this.txtEditName.TabIndex = 17;
            // 
            // btnUpdatePerson
            // 
            this.btnUpdatePerson.Location = new System.Drawing.Point(570, 498);
            this.btnUpdatePerson.Name = "btnUpdatePerson";
            this.btnUpdatePerson.Size = new System.Drawing.Size(90, 35);
            this.btnUpdatePerson.TabIndex = 16;
            this.btnUpdatePerson.Text = "Update person";
            this.btnUpdatePerson.UseVisualStyleBackColor = true;
            this.btnUpdatePerson.Click += new System.EventHandler(this.btnUpdatePerson_Click);
            // 
            // lblUpdateID
            // 
            this.lblUpdateID.AutoSize = true;
            this.lblUpdateID.Location = new System.Drawing.Point(545, 289);
            this.lblUpdateID.Name = "lblUpdateID";
            this.lblUpdateID.Size = new System.Drawing.Size(21, 13);
            this.lblUpdateID.TabIndex = 22;
            this.lblUpdateID.Text = "ID:";
            // 
            // txtEditID
            // 
            this.txtEditID.Location = new System.Drawing.Point(545, 305);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(130, 20);
            this.txtEditID.TabIndex = 21;
            // 
            // lblUpdateTelephoneNumber
            // 
            this.lblUpdateTelephoneNumber.AutoSize = true;
            this.lblUpdateTelephoneNumber.Location = new System.Drawing.Point(637, 423);
            this.lblUpdateTelephoneNumber.Name = "lblUpdateTelephoneNumber";
            this.lblUpdateTelephoneNumber.Size = new System.Drawing.Size(99, 13);
            this.lblUpdateTelephoneNumber.TabIndex = 26;
            this.lblUpdateTelephoneNumber.Text = "Telephone number:";
            // 
            // txtEditTelephoneNumber
            // 
            this.txtEditTelephoneNumber.Location = new System.Drawing.Point(634, 439);
            this.txtEditTelephoneNumber.Name = "txtEditTelephoneNumber";
            this.txtEditTelephoneNumber.Size = new System.Drawing.Size(130, 20);
            this.txtEditTelephoneNumber.TabIndex = 25;
            this.txtEditTelephoneNumber.Text = "0";
            // 
            // lblUpdateAddress
            // 
            this.lblUpdateAddress.AutoSize = true;
            this.lblUpdateAddress.Location = new System.Drawing.Point(637, 359);
            this.lblUpdateAddress.Name = "lblUpdateAddress";
            this.lblUpdateAddress.Size = new System.Drawing.Size(48, 13);
            this.lblUpdateAddress.TabIndex = 24;
            this.lblUpdateAddress.Text = "Address:";
            // 
            // txtEditAddress
            // 
            this.txtEditAddress.Location = new System.Drawing.Point(634, 375);
            this.txtEditAddress.Name = "txtEditAddress";
            this.txtEditAddress.Size = new System.Drawing.Size(130, 20);
            this.txtEditAddress.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.lblUpdateTelephoneNumber);
            this.Controls.Add(this.txtEditTelephoneNumber);
            this.Controls.Add(this.lblUpdateAddress);
            this.Controls.Add(this.txtEditAddress);
            this.Controls.Add(this.lblUpdateID);
            this.Controls.Add(this.txtEditID);
            this.Controls.Add(this.lblUpdateAge);
            this.Controls.Add(this.txtEditAge);
            this.Controls.Add(this.lblUpdateName);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.btnUpdatePerson);
            this.Controls.Add(this.lblDeleteAge);
            this.Controls.Add(this.txtDeleteAge);
            this.Controls.Add(this.lblDeleteName);
            this.Controls.Add(this.txtDeleteName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPeople);
            this.Controls.Add(this.btnReadPeople);
            this.Controls.Add(this.lblTelephoneNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtTelephoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "People Database App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTelephoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTelephoneNumber;
        private System.Windows.Forms.Button btnReadPeople;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDeleteAge;
        private System.Windows.Forms.TextBox txtDeleteAge;
        private System.Windows.Forms.Label lblDeleteName;
        private System.Windows.Forms.TextBox txtDeleteName;
        private System.Windows.Forms.Label lblUpdateAge;
        private System.Windows.Forms.TextBox txtEditAge;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Button btnUpdatePerson;
        private System.Windows.Forms.Label lblUpdateID;
        private System.Windows.Forms.TextBox txtEditID;
        private System.Windows.Forms.Label lblUpdateTelephoneNumber;
        private System.Windows.Forms.TextBox txtEditTelephoneNumber;
        private System.Windows.Forms.Label lblUpdateAddress;
        private System.Windows.Forms.TextBox txtEditAddress;
    }
}

