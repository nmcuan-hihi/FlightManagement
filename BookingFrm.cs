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
using VnAirLines.Models;

namespace VnAirLines
{
    public partial class BookingFrm : Form
    {
        BindingList<Passenger> passengers = new BindingList<Passenger>();
        string date, time;
        double price = 0;
        public BookingFrm(DataGridView dgv1, DataGridView dgv2)
        {
            InitializeComponent();
            InitDgv(dgv1, dgv2);
            dgvPassenger.DataSource = passengers;
           
            dgvPassenger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void InitDgv(DataGridView dgv1, DataGridView dgv2)
        {
            try
            {
                var row = dgv1.SelectedRows[0];
                lbOutFrom.Text = row.Cells[0].Value.ToString();
                lbOutTo.Text = row.Cells["Column2"].Value.ToString();
                lbOutCabin.Text = "Economy";
                lbOutDate.Text = row.Cells["Date"].Value.ToString().Split(' ')[0];
                lbOutFlightNumber.Text = row.Cells["FlightNumber"].Value.ToString();
                date = row.Cells["Date"].Value.ToString().Split(' ')[0];
                time = row.Cells["Time"].Value.ToString();
                price += double.Parse(row.Cells["EconomyPrice"].Value.ToString());

                var row1 = dgv2.SelectedRows[0];
                lbReturnFrom.Text = row1.Cells["Column1"].Value.ToString();
                lbReturnTo.Text = row1.Cells["Column2"].Value.ToString();
                lbReturnCabin.Text = "Economy";
                lbReturnDate.Text = row1.Cells["Date"].Value.ToString();
                lbReturnFlightNumber.Text = row1.Cells["FlightNumber"].Value.ToString();
                price += double.Parse(row1.Cells["EconomyPrice"].Value.ToString());

            }
            catch (Exception)
            {
            }
            

            //DataTable dt = new DataTable();
            //DataTable dt2 = new DataTable();
            //List<DataGridViewRow> selectedRows = dgv1.SelectedRows.Cast<DataGridViewRow>().ToList();
            //foreach (DataGridViewColumn column in dgv1.Columns)
            //{
            //    dt.Columns.Add(column.HeaderText);
            //}

            //// Thêm các hàng đã chọn vào DataTable hoặc danh sách đối tượng
            //foreach (DataGridViewRow row in selectedRows)
            //{
            //    DataRow newRow = dt.NewRow();
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        newRow[cell.ColumnIndex] = cell.Value;
            //    }
            //    dt.Rows.Add(newRow);
            //}

            //// Đặt DataTable hoặc danh sách đối tượng như là nguồn dữ liệu cho dgv2
            ////this.dgv1.DataSource = dt;

            //List<DataGridViewRow> selectedRows2 = dgv2.SelectedRows.Cast<DataGridViewRow>().ToList();
            //foreach (DataGridViewColumn column in dgv2.Columns)
            //{
            //    dt2.Columns.Add(column.HeaderText);
            //}

            //// Thêm các hàng đã chọn vào DataTable hoặc danh sách đối tượng
            //foreach (DataGridViewRow row in selectedRows2)
            //{
            //    DataRow newRow = dt2.NewRow();
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        newRow[cell.ColumnIndex] = cell.Value;
            //    }
            //    dt2.Rows.Add(newRow);
            //}
            ////this.dgv2.DataSource = dt2;
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger();
            passenger.FirstName = txtFirstName.Text;
            passenger.LastName = txtLastName.Text;
            passenger.PassportNumber = txtPassportNumber.Text;
            passenger.PassportCountry = cbCountries.SelectedValue.ToString();
            passenger.Phone = txtPhone.Text;
            passenger.BirthDate = dtpBirthDate.Value;
            passengers.Add(passenger);
            dgvPassenger.DataSource = passengers;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> selectedIndexes = new List<int>();
                foreach (DataGridViewRow row in dgvPassenger.SelectedRows)
                {
                    selectedIndexes.Add(row.Index);
                }

                // Xóa các hàng từ nguồn dữ liệu của DataGridView
                foreach (int index in selectedIndexes.OrderByDescending(i => i))
                {
                    dgvPassenger.Rows.RemoveAt(index);
                }

                // Cập nhật hiển thị của DataGridView
                dgvPassenger.Refresh();
            }
            catch (Exception)
            {

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (passengers.Count == 0)
            {
                MessageBox.Show("You need to add passenger", "Error");
                return;
            }
            BookingConfirmFrm bookingConfirmFrm = new BookingConfirmFrm(passengers,date,time,lbOutFlightNumber.Text,price*passengers.Count);
            bookingConfirmFrm.ShowDialog();
        }
        private void BookingFrm_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable data = DAO.GetCountries();
            cbCountries.DataSource = data;
            cbCountries.DisplayMember = data.Columns[1].ColumnName;
            cbCountries.ValueMember = data.Columns[0].ColumnName;
        }
    }
}
