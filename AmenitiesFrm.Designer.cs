namespace VnAirLines
{
    partial class AmenitiesFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoThamChieu = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAmenities = new System.Windows.Forms.Button();
            this.cbbFlight = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCheckin = new System.Windows.Forms.CheckBox();
            this.cbExBag = new System.Windows.Forms.CheckBox();
            this.cbHeadPhone = new System.Windows.Forms.CheckBox();
            this.cbTableRetal = new System.Windows.Forms.CheckBox();
            this.cbNeighboringSeat = new System.Windows.Forms.CheckBox();
            this.cbNextSeat = new System.Windows.Forms.CheckBox();
            this.cbWifi50 = new System.Windows.Forms.CheckBox();
            this.cbLoungeAccess = new System.Windows.Forms.CheckBox();
            this.cbWifi250 = new System.Windows.Forms.CheckBox();
            this.cbExBlanket = new System.Windows.Forms.CheckBox();
            this.cbLaptopRental = new System.Windows.Forms.CheckBox();
            this.cbSoftDrink = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbPassport = new System.Windows.Forms.Label();
            this.lbCabinClass = new System.Windows.Forms.Label();
            this.lbItemSelected = new System.Windows.Forms.Label();
            this.lbTaxes = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking reference:";
            // 
            // txtSoThamChieu
            // 
            this.txtSoThamChieu.Location = new System.Drawing.Point(180, 25);
            this.txtSoThamChieu.Name = "txtSoThamChieu";
            this.txtSoThamChieu.Size = new System.Drawing.Size(177, 22);
            this.txtSoThamChieu.TabIndex = 1;
            this.txtSoThamChieu.TextChanged += new System.EventHandler(this.txtSoThamChieu_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(377, 24);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowAmenities);
            this.groupBox1.Controls.Add(this.cbbFlight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(25, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight list";
            // 
            // btnShowAmenities
            // 
            this.btnShowAmenities.Location = new System.Drawing.Point(566, 37);
            this.btnShowAmenities.Name = "btnShowAmenities";
            this.btnShowAmenities.Size = new System.Drawing.Size(138, 23);
            this.btnShowAmenities.TabIndex = 3;
            this.btnShowAmenities.Text = "Show amenities";
            this.btnShowAmenities.UseVisualStyleBackColor = true;
            this.btnShowAmenities.Click += new System.EventHandler(this.btnShowAmenities_Click);
            // 
            // cbbFlight
            // 
            this.cbbFlight.FormattingEnabled = true;
            this.cbbFlight.Location = new System.Drawing.Point(234, 37);
            this.cbbFlight.Name = "cbbFlight";
            this.cbbFlight.Size = new System.Drawing.Size(286, 24);
            this.cbbFlight.TabIndex = 2;
            this.cbbFlight.SelectedIndexChanged += new System.EventHandler(this.cbFlight_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose your flights";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fullname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Passport number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Your cabin class is:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCheckin);
            this.groupBox2.Controls.Add(this.cbExBag);
            this.groupBox2.Controls.Add(this.cbHeadPhone);
            this.groupBox2.Controls.Add(this.cbTableRetal);
            this.groupBox2.Controls.Add(this.cbNeighboringSeat);
            this.groupBox2.Controls.Add(this.cbNextSeat);
            this.groupBox2.Controls.Add(this.cbWifi50);
            this.groupBox2.Controls.Add(this.cbLoungeAccess);
            this.groupBox2.Controls.Add(this.cbWifi250);
            this.groupBox2.Controls.Add(this.cbExBlanket);
            this.groupBox2.Controls.Add(this.cbLaptopRental);
            this.groupBox2.Controls.Add(this.cbSoftDrink);
            this.groupBox2.Location = new System.Drawing.Point(25, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 131);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VN Airlines Amenties";
            // 
            // cbCheckin
            // 
            this.cbCheckin.AutoSize = true;
            this.cbCheckin.Location = new System.Drawing.Point(546, 47);
            this.cbCheckin.Name = "cbCheckin";
            this.cbCheckin.Size = new System.Drawing.Size(166, 20);
            this.cbCheckin.TabIndex = 11;
            this.cbCheckin.Text = "Fast checkin Lane(10$)";
            this.cbCheckin.UseVisualStyleBackColor = true;
            this.cbCheckin.CheckedChanged += new System.EventHandler(this.cbCheckin_CheckedChanged);
            // 
            // cbExBag
            // 
            this.cbExBag.AutoSize = true;
            this.cbExBag.Location = new System.Drawing.Point(546, 21);
            this.cbExBag.Name = "cbExBag";
            this.cbExBag.Size = new System.Drawing.Size(119, 20);
            this.cbExBag.TabIndex = 10;
            this.cbExBag.Text = "Extra Bag (15$)";
            this.cbExBag.UseVisualStyleBackColor = true;
            this.cbExBag.CheckedChanged += new System.EventHandler(this.cbExBag_CheckedChanged);
            // 
            // cbHeadPhone
            // 
            this.cbHeadPhone.AutoSize = true;
            this.cbHeadPhone.Location = new System.Drawing.Point(296, 100);
            this.cbHeadPhone.Name = "cbHeadPhone";
            this.cbHeadPhone.Size = new System.Drawing.Size(231, 20);
            this.cbHeadPhone.TabIndex = 9;
            this.cbHeadPhone.Text = "Premium Headphones Rental (5$)";
            this.cbHeadPhone.UseVisualStyleBackColor = true;
            this.cbHeadPhone.CheckedChanged += new System.EventHandler(this.cbHeadPhone_CheckedChanged);
            // 
            // cbTableRetal
            // 
            this.cbTableRetal.AutoSize = true;
            this.cbTableRetal.Location = new System.Drawing.Point(42, 100);
            this.cbTableRetal.Name = "cbTableRetal";
            this.cbTableRetal.Size = new System.Drawing.Size(139, 20);
            this.cbTableRetal.TabIndex = 8;
            this.cbTableRetal.Text = "Table Rental (12$)";
            this.cbTableRetal.UseVisualStyleBackColor = true;
            this.cbTableRetal.CheckedChanged += new System.EventHandler(this.cbTableRetal_CheckedChanged);
            // 
            // cbNeighboringSeat
            // 
            this.cbNeighboringSeat.AutoSize = true;
            this.cbNeighboringSeat.Enabled = false;
            this.cbNeighboringSeat.Location = new System.Drawing.Point(42, 74);
            this.cbNeighboringSeat.Name = "cbNeighboringSeat";
            this.cbNeighboringSeat.Size = new System.Drawing.Size(233, 20);
            this.cbNeighboringSeat.TabIndex = 7;
            this.cbNeighboringSeat.Text = "Two Neighboring Seats Free (50$)";
            this.cbNeighboringSeat.UseVisualStyleBackColor = true;
            this.cbNeighboringSeat.CheckedChanged += new System.EventHandler(this.cbNeighboringSeat_CheckedChanged);
            // 
            // cbNextSeat
            // 
            this.cbNextSeat.AutoSize = true;
            this.cbNextSeat.Enabled = false;
            this.cbNextSeat.Location = new System.Drawing.Point(42, 47);
            this.cbNextSeat.Name = "cbNextSeat";
            this.cbNextSeat.Size = new System.Drawing.Size(150, 20);
            this.cbNextSeat.TabIndex = 6;
            this.cbNextSeat.Text = "Next Seat Free (30$)";
            this.cbNextSeat.UseVisualStyleBackColor = true;
            this.cbNextSeat.CheckedChanged += new System.EventHandler(this.cbNextSeat_CheckedChanged_1);
            // 
            // cbWifi50
            // 
            this.cbWifi50.AutoSize = true;
            this.cbWifi50.Enabled = false;
            this.cbWifi50.Location = new System.Drawing.Point(546, 74);
            this.cbWifi50.Name = "cbWifi50";
            this.cbWifi50.Size = new System.Drawing.Size(133, 20);
            this.cbWifi50.TabIndex = 5;
            this.cbWifi50.Text = "Wi-Fi 50 mb (free)";
            this.cbWifi50.UseVisualStyleBackColor = true;
            // 
            // cbLoungeAccess
            // 
            this.cbLoungeAccess.AutoSize = true;
            this.cbLoungeAccess.Location = new System.Drawing.Point(295, 47);
            this.cbLoungeAccess.Name = "cbLoungeAccess";
            this.cbLoungeAccess.Size = new System.Drawing.Size(154, 20);
            this.cbLoungeAccess.TabIndex = 4;
            this.cbLoungeAccess.Text = "Lounge Access (25$)";
            this.cbLoungeAccess.UseVisualStyleBackColor = true;
            this.cbLoungeAccess.CheckedChanged += new System.EventHandler(this.cbLoungeAccess_CheckedChanged);
            // 
            // cbWifi250
            // 
            this.cbWifi250.AutoSize = true;
            this.cbWifi250.Location = new System.Drawing.Point(546, 100);
            this.cbWifi250.Name = "cbWifi250";
            this.cbWifi250.Size = new System.Drawing.Size(138, 20);
            this.cbWifi250.TabIndex = 3;
            this.cbWifi250.Text = "Wi-Fi 250 mb (25$)";
            this.cbWifi250.UseVisualStyleBackColor = true;
            this.cbWifi250.CheckedChanged += new System.EventHandler(this.cbWifi250_CheckedChanged);
            // 
            // cbExBlanket
            // 
            this.cbExBlanket.AutoSize = true;
            this.cbExBlanket.Location = new System.Drawing.Point(42, 21);
            this.cbExBlanket.Name = "cbExBlanket";
            this.cbExBlanket.Size = new System.Drawing.Size(139, 20);
            this.cbExBlanket.TabIndex = 2;
            this.cbExBlanket.Text = "Extra Blanket (10$)";
            this.cbExBlanket.UseVisualStyleBackColor = true;
            this.cbExBlanket.CheckedChanged += new System.EventHandler(this.cbExtraBag_CheckedChanged);
            // 
            // cbLaptopRental
            // 
            this.cbLaptopRental.AutoSize = true;
            this.cbLaptopRental.Location = new System.Drawing.Point(295, 21);
            this.cbLaptopRental.Name = "cbLaptopRental";
            this.cbLaptopRental.Size = new System.Drawing.Size(139, 20);
            this.cbLaptopRental.TabIndex = 1;
            this.cbLaptopRental.Text = "Laptop rental (15$)";
            this.cbLaptopRental.UseVisualStyleBackColor = true;
            this.cbLaptopRental.CheckedChanged += new System.EventHandler(this.cbLaptopRental_CheckedChanged);
            // 
            // cbSoftDrink
            // 
            this.cbSoftDrink.AutoSize = true;
            this.cbSoftDrink.Enabled = false;
            this.cbSoftDrink.Location = new System.Drawing.Point(295, 74);
            this.cbSoftDrink.Name = "cbSoftDrink";
            this.cbSoftDrink.Size = new System.Drawing.Size(127, 20);
            this.cbSoftDrink.TabIndex = 0;
            this.cbSoftDrink.Text = "Soft Drinks (free)";
            this.cbSoftDrink.UseVisualStyleBackColor = true;
            this.cbSoftDrink.CheckedChanged += new System.EventHandler(this.cbSoftDrink_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Item Selected:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Duties and taxes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total payable:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save an confirm";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(307, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(107, 165);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(0, 16);
            this.lbFullName.TabIndex = 13;
            // 
            // lbPassport
            // 
            this.lbPassport.AutoSize = true;
            this.lbPassport.Location = new System.Drawing.Point(387, 165);
            this.lbPassport.Name = "lbPassport";
            this.lbPassport.Size = new System.Drawing.Size(0, 16);
            this.lbPassport.TabIndex = 14;
            // 
            // lbCabinClass
            // 
            this.lbCabinClass.AutoSize = true;
            this.lbCabinClass.Location = new System.Drawing.Point(164, 196);
            this.lbCabinClass.Name = "lbCabinClass";
            this.lbCabinClass.Size = new System.Drawing.Size(0, 16);
            this.lbCabinClass.TabIndex = 15;
            // 
            // lbItemSelected
            // 
            this.lbItemSelected.AutoSize = true;
            this.lbItemSelected.Location = new System.Drawing.Point(146, 368);
            this.lbItemSelected.Name = "lbItemSelected";
            this.lbItemSelected.Size = new System.Drawing.Size(14, 16);
            this.lbItemSelected.TabIndex = 16;
            this.lbItemSelected.Text = "0";
            // 
            // lbTaxes
            // 
            this.lbTaxes.AutoSize = true;
            this.lbTaxes.Location = new System.Drawing.Point(164, 396);
            this.lbTaxes.Name = "lbTaxes";
            this.lbTaxes.Size = new System.Drawing.Size(14, 16);
            this.lbTaxes.TabIndex = 17;
            this.lbTaxes.Text = "0";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(145, 425);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(14, 16);
            this.lbTotal.TabIndex = 18;
            this.lbTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 424);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "$";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(530, 368);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(14, 16);
            this.lbTotalPrice.TabIndex = 22;
            this.lbTotalPrice.Text = "0";
            this.lbTotalPrice.Visible = false;
            this.lbTotalPrice.Click += new System.EventHandler(this.lbTotalPrice_Click);
            // 
            // AmenitiesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbTaxes);
            this.Controls.Add(this.lbItemSelected);
            this.Controls.Add(this.lbCabinClass);
            this.Controls.Add(this.lbPassport);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSoThamChieu);
            this.Controls.Add(this.label1);
            this.Name = "AmenitiesFrm";
            this.Text = "Purchase Amenities";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AmenitiesFrm_FormClosing);
            this.Load += new System.EventHandler(this.AmenitiesFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoThamChieu;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowAmenities;
        private System.Windows.Forms.ComboBox cbbFlight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbWifi50;
        private System.Windows.Forms.CheckBox cbLoungeAccess;
        private System.Windows.Forms.CheckBox cbWifi250;
        private System.Windows.Forms.CheckBox cbExBlanket;
        private System.Windows.Forms.CheckBox cbLaptopRental;
        private System.Windows.Forms.CheckBox cbSoftDrink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbPassport;
        private System.Windows.Forms.Label lbCabinClass;
        private System.Windows.Forms.Label lbItemSelected;
        private System.Windows.Forms.Label lbTaxes;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbNextSeat;
        private System.Windows.Forms.CheckBox cbNeighboringSeat;
        private System.Windows.Forms.CheckBox cbTableRetal;
        private System.Windows.Forms.CheckBox cbCheckin;
        private System.Windows.Forms.CheckBox cbExBag;
        private System.Windows.Forms.CheckBox cbHeadPhone;
        private System.Windows.Forms.Label lbTotalPrice;
    }
}