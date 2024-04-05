namespace VnAirLines
{
    partial class ReportAm
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
            this.crtAmenities = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crtAmenitiesID1 = new VnAirLines.crtAmenitiesID();
            this.tbID = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtbTo = new System.Windows.Forms.DateTimePicker();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crtAmenities
            // 
            this.crtAmenities.ActiveViewIndex = 0;
            this.crtAmenities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtAmenities.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtAmenities.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crtAmenities.Location = new System.Drawing.Point(0, 260);
            this.crtAmenities.Name = "crtAmenities";
            this.crtAmenities.ReportSource = this.crtAmenitiesID1;
            this.crtAmenities.Size = new System.Drawing.Size(1462, 639);
            this.crtAmenities.TabIndex = 0;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(107, 57);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(467, 38);
            this.tbID.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(107, 149);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(467, 40);
            this.dtpFrom.TabIndex = 2;
            // 
            // dtbTo
            // 
            this.dtbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbTo.Location = new System.Drawing.Point(649, 149);
            this.dtbTo.Name = "dtbTo";
            this.dtbTo.Size = new System.Drawing.Size(467, 40);
            this.dtbTo.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(1187, 101);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(201, 88);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "button1";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // ReportAm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 899);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.dtbTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.crtAmenities);
            this.Name = "ReportAm";
            this.Text = "ReportAm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtAmenities;
        private crtAmenitiesID crtAmenitiesID1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtbTo;
        private System.Windows.Forms.Button btnCheck;
    }
}