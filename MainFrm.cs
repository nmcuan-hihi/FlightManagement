using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VnAirLines
{
    public partial class MainFrm : Form
    {
        private SqlConnection conn = Connection.Connect();
        public MainFrm()
        {
            InitializeComponent();

        }

        private void searchForLightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForLightsFrm searchForLightsFrm = new SearchForLightsFrm();
           searchForLightsFrm.MdiParent = this;
            searchForLightsFrm.Show();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BookingFrm bookingFrm = new BookingFrm();
            //bookingFrm.MdiParent = this; 
            //bookingFrm.Show();
        }

        private void amenitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmenitiesFrm amenitiesFrm = new AmenitiesFrm();
            amenitiesFrm.MdiParent = this;
            amenitiesFrm.Show();
        }

        private void bookingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingReportFrm bookingReportFrm = new BookingReportFrm();
            bookingReportFrm.MdiParent = this;
            bookingReportFrm.Show();
        }

        private void amenitiesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportAmeni amenitiesReportFrm = new ReportAmeni();   
            amenitiesReportFrm.MdiParent = this;
            amenitiesReportFrm.Show();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
