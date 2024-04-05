using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VnAirLines
{
    public partial class ReportAmeni : Form
    {
        public ReportAmeni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbFlightID.Text.Trim().Equals(""))
            {
                if (dtpTo.Value >= dtpFrom.Value)
                {
                    crtAmenitiesDate rpt = new crtAmenitiesDate();
                    ParameterValues para1 = new ParameterValues();
                    ParameterValues para2 = new ParameterValues();
                    ParameterDiscreteValue val1 = new ParameterDiscreteValue();
                    val1.Value = dtpFrom.Value.ToString("yyyy/MM/dd");
                    ParameterDiscreteValue val2 = new ParameterDiscreteValue();
                    val2.Value = dtpTo.Value.ToString("yyyy/MM/dd");
                    para1.Add(val1);
                    para2.Add(val2);
                    rpt.DataDefinition.ParameterFields["@ngayTruoc"].ApplyCurrentValues(para1);
                    rpt.DataDefinition.ParameterFields["@ngaySau"].ApplyCurrentValues(para2);
                    crtViewAmenitiesR.ReportSource = rpt;
                }
                else
                {
                    MessageBox.Show("Ngày Trước Phải Lớn Hơn Ngày Sau!", "Thao Tác Sai!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                crtAmenitiesID rpt = new crtAmenitiesID();
                ParameterValues para1 = new ParameterValues();
                ParameterValues para2 = new ParameterValues();
                ParameterDiscreteValue val1 = new ParameterDiscreteValue();
                val1.Value = tbFlightID.Text.Trim();
                ParameterDiscreteValue val2 = new ParameterDiscreteValue();
                val2.Value = dtpFrom.Value.ToString("yyyy/MM/dd");
                para1.Add(val1);
                para2.Add(val2);
                rpt.DataDefinition.ParameterFields["@idBay"].ApplyCurrentValues(para1);
                rpt.DataDefinition.ParameterFields["@ngay"].ApplyCurrentValues(para2);
                crtViewAmenitiesR.ReportSource = rpt;
            }
        }
    }
}
