namespace HotelOOP
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnRegisterCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateRooms = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBookAmenity = new System.Windows.Forms.Button();
            this.btnShowReports = new System.Windows.Forms.Button();
            this.btnVacateRoom = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblShowIncome = new System.Windows.Forms.Label();
            this.lblCountCustomer = new System.Windows.Forms.Label();
            this.txtShowIncome = new System.Windows.Forms.TextBox();
            this.txtCountCustomers = new System.Windows.Forms.TextBox();
            this.lblReportOnRooms = new System.Windows.Forms.Label();
            this.txtReportOnRooms = new System.Windows.Forms.TextBox();
            this.btnBookSpa = new System.Windows.Forms.Button();
            this.btnBookRestaurant = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnEnterChoice = new System.Windows.Forms.Button();
            this.txtChooseAmenity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRestaurantTime = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSpaTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(15, 38);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(180, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(15, 19);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(135, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Enter the customer\'s name:";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(7, 19);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(100, 45);
            this.btnBooking.TabIndex = 2;
            this.btnBooking.Text = "Make a room booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnRegisterCustomer
            // 
            this.btnRegisterCustomer.Location = new System.Drawing.Point(40, 80);
            this.btnRegisterCustomer.Name = "btnRegisterCustomer";
            this.btnRegisterCustomer.Size = new System.Drawing.Size(110, 50);
            this.btnRegisterCustomer.TabIndex = 3;
            this.btnRegisterCustomer.Text = "Register customer";
            this.btnRegisterCustomer.UseVisualStyleBackColor = true;
            this.btnRegisterCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateRooms);
            this.groupBox1.Location = new System.Drawing.Point(1, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 35);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // btnCreateRooms
            // 
            this.btnCreateRooms.Location = new System.Drawing.Point(7, 9);
            this.btnCreateRooms.Name = "btnCreateRooms";
            this.btnCreateRooms.Size = new System.Drawing.Size(79, 27);
            this.btnCreateRooms.TabIndex = 5;
            this.btnCreateRooms.Text = "Create rooms";
            this.btnCreateRooms.UseVisualStyleBackColor = true;
            this.btnCreateRooms.Click += new System.EventHandler(this.btnCreateRooms_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBookAmenity);
            this.groupBox2.Controls.Add(this.btnShowReports);
            this.groupBox2.Controls.Add(this.btnVacateRoom);
            this.groupBox2.Controls.Add(this.btnBooking);
            this.groupBox2.Location = new System.Drawing.Point(40, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 227);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            this.groupBox2.Visible = false;
            // 
            // btnBookAmenity
            // 
            this.btnBookAmenity.Location = new System.Drawing.Point(7, 173);
            this.btnBookAmenity.Name = "btnBookAmenity";
            this.btnBookAmenity.Size = new System.Drawing.Size(100, 45);
            this.btnBookAmenity.TabIndex = 13;
            this.btnBookAmenity.Text = "Book amenity";
            this.btnBookAmenity.UseVisualStyleBackColor = true;
            this.btnBookAmenity.Click += new System.EventHandler(this.btnBookAmenity_Click);
            // 
            // btnShowReports
            // 
            this.btnShowReports.Location = new System.Drawing.Point(7, 121);
            this.btnShowReports.Name = "btnShowReports";
            this.btnShowReports.Size = new System.Drawing.Size(100, 45);
            this.btnShowReports.TabIndex = 10;
            this.btnShowReports.Text = "Show reports";
            this.btnShowReports.UseVisualStyleBackColor = true;
            this.btnShowReports.Click += new System.EventHandler(this.btnShowReports_Click);
            // 
            // btnVacateRoom
            // 
            this.btnVacateRoom.Location = new System.Drawing.Point(6, 70);
            this.btnVacateRoom.Name = "btnVacateRoom";
            this.btnVacateRoom.Size = new System.Drawing.Size(100, 45);
            this.btnVacateRoom.TabIndex = 3;
            this.btnVacateRoom.Text = "Vacate room";
            this.btnVacateRoom.UseVisualStyleBackColor = true;
            this.btnVacateRoom.Click += new System.EventHandler(this.btnVacateRoom_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblShowIncome);
            this.groupBox3.Controls.Add(this.lblCountCustomer);
            this.groupBox3.Controls.Add(this.txtShowIncome);
            this.groupBox3.Controls.Add(this.txtCountCustomers);
            this.groupBox3.Controls.Add(this.lblReportOnRooms);
            this.groupBox3.Controls.Add(this.txtReportOnRooms);
            this.groupBox3.Location = new System.Drawing.Point(215, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 404);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reports";
            this.groupBox3.Visible = false;
            // 
            // lblShowIncome
            // 
            this.lblShowIncome.AutoSize = true;
            this.lblShowIncome.Location = new System.Drawing.Point(16, 274);
            this.lblShowIncome.Name = "lblShowIncome";
            this.lblShowIncome.Size = new System.Drawing.Size(72, 13);
            this.lblShowIncome.TabIndex = 9;
            this.lblShowIncome.Text = "Income report";
            // 
            // lblCountCustomer
            // 
            this.lblCountCustomer.AutoSize = true;
            this.lblCountCustomer.Location = new System.Drawing.Point(16, 143);
            this.lblCountCustomer.Name = "lblCountCustomer";
            this.lblCountCustomer.Size = new System.Drawing.Size(111, 13);
            this.lblCountCustomer.TabIndex = 8;
            this.lblCountCustomer.Text = "Customer count report";
            // 
            // txtShowIncome
            // 
            this.txtShowIncome.Location = new System.Drawing.Point(16, 290);
            this.txtShowIncome.Multiline = true;
            this.txtShowIncome.Name = "txtShowIncome";
            this.txtShowIncome.Size = new System.Drawing.Size(235, 100);
            this.txtShowIncome.TabIndex = 7;
            // 
            // txtCountCustomers
            // 
            this.txtCountCustomers.Location = new System.Drawing.Point(16, 159);
            this.txtCountCustomers.Multiline = true;
            this.txtCountCustomers.Name = "txtCountCustomers";
            this.txtCountCustomers.Size = new System.Drawing.Size(235, 100);
            this.txtCountCustomers.TabIndex = 6;
            // 
            // lblReportOnRooms
            // 
            this.lblReportOnRooms.AutoSize = true;
            this.lblReportOnRooms.Location = new System.Drawing.Point(16, 12);
            this.lblReportOnRooms.Name = "lblReportOnRooms";
            this.lblReportOnRooms.Size = new System.Drawing.Size(88, 13);
            this.lblReportOnRooms.TabIndex = 5;
            this.lblReportOnRooms.Text = "Report on rooms:";
            // 
            // txtReportOnRooms
            // 
            this.txtReportOnRooms.Location = new System.Drawing.Point(16, 28);
            this.txtReportOnRooms.Multiline = true;
            this.txtReportOnRooms.Name = "txtReportOnRooms";
            this.txtReportOnRooms.Size = new System.Drawing.Size(235, 100);
            this.txtReportOnRooms.TabIndex = 4;
            // 
            // btnBookSpa
            // 
            this.btnBookSpa.Location = new System.Drawing.Point(110, 97);
            this.btnBookSpa.Name = "btnBookSpa";
            this.btnBookSpa.Size = new System.Drawing.Size(100, 45);
            this.btnBookSpa.TabIndex = 6;
            this.btnBookSpa.Text = "Book a spa slot";
            this.btnBookSpa.UseVisualStyleBackColor = true;
            this.btnBookSpa.Click += new System.EventHandler(this.btnBookSpa_Click);
            // 
            // btnBookRestaurant
            // 
            this.btnBookRestaurant.Location = new System.Drawing.Point(67, 102);
            this.btnBookRestaurant.Name = "btnBookRestaurant";
            this.btnBookRestaurant.Size = new System.Drawing.Size(100, 45);
            this.btnBookRestaurant.TabIndex = 12;
            this.btnBookRestaurant.Text = "Book a restaurant slot";
            this.btnBookRestaurant.UseVisualStyleBackColor = true;
            this.btnBookRestaurant.Click += new System.EventHandler(this.btnBookRestaurant_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.btnEnterChoice);
            this.groupBox4.Controls.Add(this.txtChooseAmenity);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(492, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 77);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Choosing amenities";
            this.groupBox4.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(203, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Book a two hour slot";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // btnEnterChoice
            // 
            this.btnEnterChoice.Location = new System.Drawing.Point(206, 41);
            this.btnEnterChoice.Name = "btnEnterChoice";
            this.btnEnterChoice.Size = new System.Drawing.Size(40, 20);
            this.btnEnterChoice.TabIndex = 2;
            this.btnEnterChoice.Text = "Enter";
            this.btnEnterChoice.UseVisualStyleBackColor = true;
            this.btnEnterChoice.Click += new System.EventHandler(this.btnEnterChoice_Click);
            // 
            // txtChooseAmenity
            // 
            this.txtChooseAmenity.Location = new System.Drawing.Point(6, 41);
            this.txtChooseAmenity.Name = "txtChooseAmenity";
            this.txtChooseAmenity.Size = new System.Drawing.Size(185, 20);
            this.txtChooseAmenity.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose an amenity (spa or restaurant):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a time between 7am and 10pm:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtRestaurantTime);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btnBookRestaurant);
            this.groupBox5.Location = new System.Drawing.Point(492, 102);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 163);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Restaurant booking";
            this.groupBox5.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Afternoon tea:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Max number of guests = 40";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(249, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "£35.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(249, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "£22.50";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(246, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "£17.50";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "£9.50";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "18 - 22";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Dinner:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "15 - 17";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "11 - 14";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Lunch:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "7 - 10";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Breakfast: ";
            // 
            // txtRestaurantTime
            // 
            this.txtRestaurantTime.Location = new System.Drawing.Point(16, 61);
            this.txtRestaurantTime.Name = "txtRestaurantTime";
            this.txtRestaurantTime.Size = new System.Drawing.Size(194, 20);
            this.txtRestaurantTime.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtSpaTime);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.btnBookSpa);
            this.groupBox6.Location = new System.Drawing.Point(492, 265);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(308, 158);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Spa booking";
            this.groupBox6.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Max number of guests = 18";
            // 
            // txtSpaTime
            // 
            this.txtSpaTime.Location = new System.Drawing.Point(16, 60);
            this.txtSpaTime.Name = "txtSpaTime";
            this.txtSpaTime.Size = new System.Drawing.Size(264, 20);
            this.txtSpaTime.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select a time between 6am and 10pm:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRegisterCustomer);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "Form1";
            this.Text = "The Eagle Hotel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnRegisterCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateRooms;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVacateRoom;
        private System.Windows.Forms.Label lblCountCustomer;
        private System.Windows.Forms.TextBox txtShowIncome;
        private System.Windows.Forms.TextBox txtCountCustomers;
        private System.Windows.Forms.Label lblReportOnRooms;
        private System.Windows.Forms.TextBox txtReportOnRooms;
        private System.Windows.Forms.Button btnShowReports;
        private System.Windows.Forms.Label lblShowIncome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBookRestaurant;
        private System.Windows.Forms.Button btnBookSpa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChooseAmenity;
        private System.Windows.Forms.Button btnBookAmenity;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRestaurantTime;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpaTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnEnterChoice;
        private System.Windows.Forms.Label label18;
    }
}

