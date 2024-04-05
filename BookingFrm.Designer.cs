namespace VnAirLines
{
    partial class BookingFrm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPassenger = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbOutTo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbOutFrom = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbOutCabin = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbOutDate = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbOutFlightNumber = new System.Windows.Forms.Label();
            this.lbReturnFlightNumber = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbReturnDate = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbReturnCabin = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lbReturnFrom = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbReturnTo = new System.Windows.Forms.Label();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Outbound flight details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Return flight details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Passenger Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Firstname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Passport number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lastname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Birthdate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Passport country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(569, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Phone";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(142, 204);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 11;
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(142, 242);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(121, 20);
            this.txtPassportNumber.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(398, 204);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(120, 20);
            this.txtLastName.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(627, 242);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(115, 20);
            this.txtPhone.TabIndex = 15;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(627, 204);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(115, 20);
            this.dtpBirthDate.TabIndex = 16;
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.Location = new System.Drawing.Point(627, 278);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(115, 23);
            this.btnAddPassenger.TabIndex = 17;
            this.btnAddPassenger.Text = "Add Passenger";
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            this.btnAddPassenger.Click += new System.EventHandler(this.btnAddPassenger_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Passenger List";
            // 
            // dgvPassenger
            // 
            this.dgvPassenger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassenger.ContextMenuStrip = this.contextMenuStrip;
            this.dgvPassenger.Location = new System.Drawing.Point(34, 337);
            this.dgvPassenger.Name = "dgvPassenger";
            this.dgvPassenger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassenger.Size = new System.Drawing.Size(724, 150);
            this.dgvPassenger.TabIndex = 19;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(95, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItem1.Text = "Xóa";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(33, 510);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back to search for flights";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(222, 510);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 23);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "Confirm booking";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbOutTo
            // 
            this.lbOutTo.AutoSize = true;
            this.lbOutTo.Location = new System.Drawing.Point(193, 42);
            this.lbOutTo.Name = "lbOutTo";
            this.lbOutTo.Size = new System.Drawing.Size(30, 13);
            this.lbOutTo.TabIndex = 22;
            this.lbOutTo.Text = "AUH";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "From:";
            // 
            // lbOutFrom
            // 
            this.lbOutFrom.AutoSize = true;
            this.lbOutFrom.Location = new System.Drawing.Point(90, 42);
            this.lbOutFrom.Name = "lbOutFrom";
            this.lbOutFrom.Size = new System.Drawing.Size(24, 13);
            this.lbOutFrom.TabIndex = 24;
            this.lbOutFrom.Text = "CAI";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(167, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "To:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(283, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Cabin type:";
            // 
            // lbOutCabin
            // 
            this.lbOutCabin.AutoSize = true;
            this.lbOutCabin.Location = new System.Drawing.Point(346, 42);
            this.lbOutCabin.Name = "lbOutCabin";
            this.lbOutCabin.Size = new System.Drawing.Size(51, 13);
            this.lbOutCabin.TabIndex = 27;
            this.lbOutCabin.Text = "Economy";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(444, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Date:";
            // 
            // lbOutDate
            // 
            this.lbOutDate.AutoSize = true;
            this.lbOutDate.Location = new System.Drawing.Point(483, 42);
            this.lbOutDate.Name = "lbOutDate";
            this.lbOutDate.Size = new System.Drawing.Size(65, 13);
            this.lbOutDate.TabIndex = 29;
            this.lbOutDate.Text = "11/10/2020";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(596, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Flight number:";
            // 
            // lbOutFlightNumber
            // 
            this.lbOutFlightNumber.AutoSize = true;
            this.lbOutFlightNumber.Location = new System.Drawing.Point(677, 42);
            this.lbOutFlightNumber.Name = "lbOutFlightNumber";
            this.lbOutFlightNumber.Size = new System.Drawing.Size(31, 13);
            this.lbOutFlightNumber.TabIndex = 31;
            this.lbOutFlightNumber.Text = "1908";
            // 
            // lbReturnFlightNumber
            // 
            this.lbReturnFlightNumber.AutoSize = true;
            this.lbReturnFlightNumber.Location = new System.Drawing.Point(677, 126);
            this.lbReturnFlightNumber.Name = "lbReturnFlightNumber";
            this.lbReturnFlightNumber.Size = new System.Drawing.Size(0, 13);
            this.lbReturnFlightNumber.TabIndex = 41;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(596, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 13);
            this.label22.TabIndex = 40;
            this.label22.Text = "Flight number:";
            // 
            // lbReturnDate
            // 
            this.lbReturnDate.AutoSize = true;
            this.lbReturnDate.Location = new System.Drawing.Point(483, 126);
            this.lbReturnDate.Name = "lbReturnDate";
            this.lbReturnDate.Size = new System.Drawing.Size(0, 13);
            this.lbReturnDate.TabIndex = 39;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(444, 126);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "Date:";
            // 
            // lbReturnCabin
            // 
            this.lbReturnCabin.AutoSize = true;
            this.lbReturnCabin.Location = new System.Drawing.Point(346, 126);
            this.lbReturnCabin.Name = "lbReturnCabin";
            this.lbReturnCabin.Size = new System.Drawing.Size(0, 13);
            this.lbReturnCabin.TabIndex = 37;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(283, 126);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 13);
            this.label26.TabIndex = 36;
            this.label26.Text = "Cabin type:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(167, 126);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 13);
            this.label27.TabIndex = 35;
            this.label27.Text = "To:";
            // 
            // lbReturnFrom
            // 
            this.lbReturnFrom.AutoSize = true;
            this.lbReturnFrom.Location = new System.Drawing.Point(90, 126);
            this.lbReturnFrom.Name = "lbReturnFrom";
            this.lbReturnFrom.Size = new System.Drawing.Size(0, 13);
            this.lbReturnFrom.TabIndex = 34;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(54, 126);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(33, 13);
            this.label29.TabIndex = 33;
            this.label29.Text = "From:";
            // 
            // lbReturnTo
            // 
            this.lbReturnTo.AutoSize = true;
            this.lbReturnTo.Location = new System.Drawing.Point(193, 126);
            this.lbReturnTo.Name = "lbReturnTo";
            this.lbReturnTo.Size = new System.Drawing.Size(0, 13);
            this.lbReturnTo.TabIndex = 32;
            // 
            // cbCountries
            // 
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(398, 242);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(120, 21);
            this.cbCountries.TabIndex = 42;
            // 
            // BookingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 575);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.lbReturnFlightNumber);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lbReturnDate);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lbReturnCabin);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lbReturnFrom);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.lbReturnTo);
            this.Controls.Add(this.lbOutFlightNumber);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbOutDate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbOutCabin);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbOutFrom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbOutTo);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvPassenger);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAddPassenger);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookingFrm";
            this.Text = "Booking confirmation";
            this.Load += new System.EventHandler(this.BookingFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassenger)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvPassenger;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lbOutTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbOutFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbOutCabin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbOutDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbOutFlightNumber;
        private System.Windows.Forms.Label lbReturnFlightNumber;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbReturnDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbReturnCabin;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lbReturnFrom;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lbReturnTo;
        private System.Windows.Forms.ComboBox cbCountries;
    }
}