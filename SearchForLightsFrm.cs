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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VnAirLines
{
    public partial class SearchForLightsFrm : Form
    {
        
        public SearchForLightsFrm()
        {
			//29/3
            InitializeComponent();
        }

   

        private void SearchForLightsFrm_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable data = DAO.GetDataSanBay();
            cboFrom.DataSource = data;
            cboFrom.DisplayMember = data.Columns[2].ColumnName;
            cboFrom.ValueMember = data.Columns[0].ColumnName;

            // Tạo bản sao khác của DataTable để sử dụng cho ComboBox
            DataTable dataTo = data.Copy();
            cboTo.DataSource = dataTo;
            cboTo.DisplayMember = dataTo.Columns[2].ColumnName;
            cboTo.ValueMember = dataTo.Columns[0].ColumnName;



            DataTable d = DAO.GetDataCabinType();
            cboCabinType.DataSource = d;
            cboCabinType.DisplayMember = d.Columns[1].ColumnName;
            cboCabinType.ValueMember = d.Columns[0].ColumnName;


            cboFrom.SelectedIndex = 0;
            cboTo.SelectedIndex = 1;
            radOneWay.Checked = true;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date1 = dtime1.Value.ToString("yyyy-MM-dd");
            string date2 = dtime2.Value.ToString("yyyy-MM-dd");
            
            dgv1.DataSource = DAO.GetDataChuyenBay(cboFrom.SelectedValue.ToString(), cboTo.SelectedValue.ToString(), date1, "0", "0");
            if (radReturn.Checked == true)
            {
                dgv2.DataSource = DAO.GetDataChuyenBay(cboTo.SelectedValue.ToString(), cboFrom.SelectedValue.ToString(), date2, "0", "0");
                if (checkBox2.Checked)
                {
                    dgv2.DataSource = DAO.GetDataChuyenBay(cboTo.SelectedValue.ToString(), cboFrom.SelectedValue.ToString(), date2, "3", "3");

                }
            }
            if (checkBox1.Checked)
            {
                dgv1.DataSource = DAO.GetDataChuyenBay(cboFrom.SelectedValue.ToString(), cboTo.SelectedValue.ToString(), date1, "3", "3");

            }
            else
            {
                dgv2.DataSource = null;
            }

        }


        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (dgv1.DataSource != null)
            {
                BookingFrm bookingFrm = new BookingFrm(dgv1, dgv2);
                bookingFrm.MdiParent = MdiParent;
                bookingFrm.Show();
            }
        }
    }
}
