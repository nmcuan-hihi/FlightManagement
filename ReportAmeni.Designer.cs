namespace VnAirLines
{
    partial class ReportAmeni
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
            this.crtViewAmenitiesR = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbFlightID = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crtViewAmenitiesR
            // 
            this.crtViewAmenitiesR.ActiveViewIndex = -1;
            this.crtViewAmenitiesR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtViewAmenitiesR.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtViewAmenitiesR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crtViewAmenitiesR.Location = new System.Drawing.Point(0, 232);
            this.crtViewAmenitiesR.Name = "crtViewAmenitiesR";
            this.crtViewAmenitiesR.Size = new System.Drawing.Size(1144, 714);
            this.crtViewAmenitiesR.TabIndex = 0;
            // 
            // tbFlightID
            // 
            this.tbFlightID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlightID.Location = new System.Drawing.Point(51, 53);
            this.tbFlightID.Name = "tbFlightID";
            this.tbFlightID.Size = new System.Drawing.Size(530, 40);
            this.tbFlightID.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(51, 145);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(530, 40);
            this.dtpFrom.TabIndex = 2;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(599, 145);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(530, 40);
            this.dtpTo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(599, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportAmeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 946);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.tbFlightID);
            this.Controls.Add(this.crtViewAmenitiesR);
            this.Name = "ReportAmeni";
            this.Text = "ReportAmeni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtViewAmenitiesR;
        private System.Windows.Forms.TextBox tbFlightID;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button button1;
    }
}