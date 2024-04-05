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
    public partial class AmenitiesFrm : Form
    {        
        int ticketID;
        List<int> amenitiesService;
        double itemSelected = 0;
        double taxes = 0;
        double total = 0;
        double lastTotal = 0;
        public AmenitiesFrm()
        {
            InitializeComponent();
        }

        private void txtSoThamChieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DataTable dt = DAO.GetDataFligthByBookingReferences(txtSoThamChieu.Text);
            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("Booking reference does not exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {               
                cbbFlight.DataSource = dt;
                cbbFlight.DisplayMember = "FlightDetails";
                cbbFlight.ValueMember = "FlightDetails";
                ResetCheckBox();
            }
        }

        private void cbFlight_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AmenitiesFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowAmenities_Click(object sender, EventArgs e)
        {           
            string[] t = cbbFlight.SelectedValue.ToString().Split(',');
            int scheduleID = int.Parse(t[0]);          
            string departureAirportCode = t[1].Split('-')[0];
            string arrivalAirportCode = t[1].Split('-')[1];
            DateTime.TryParse(t[2], out DateTime date);
            TimeSpan.TryParse(t[3], out TimeSpan time);
            string bookingReference = txtSoThamChieu.Text;
            ticketID = DAO.GetTicketIDByFlightListAndBookingReference(date, time, departureAirportCode, arrivalAirportCode, bookingReference, scheduleID);          
            List<string> passengerInfo = new List<string>();
                      
            passengerInfo = DAO.GetPassengerDetails(ticketID);
           
            lbFullName.Text = passengerInfo[0];
            lbPassport.Text = passengerInfo[1];
            lbCabinClass.Text = passengerInfo[2];           

            cbExBag.Enabled = false;
            cbCheckin.Enabled = false;
            cbExBlanket.Enabled = false;
            cbHeadPhone.Enabled = false;
            cbNextSeat.Enabled = false;
            cbNeighboringSeat.Enabled = false;
            cbTableRetal.Enabled = false;
            cbWifi250.Enabled = false;
            cbLaptopRental.Enabled = false;
            cbLoungeAccess.Enabled = false;
            cbWifi50.Enabled = false;
            cbSoftDrink.Enabled = false;
            //bỏ chọn amanities
            cbExBag.Checked = false;
            cbCheckin.Checked = false;
            cbExBlanket.Checked = false;
            cbHeadPhone.Checked = false;
            cbNextSeat.Checked = false;
            cbNeighboringSeat.Checked = false;
            cbTableRetal.Checked = false;
            cbWifi250.Checked = false;
            cbLaptopRental.Checked = false;
            cbLoungeAccess.Checked = false;
            cbWifi50.Checked = false;
            cbSoftDrink.Checked = false;
            if (lbCabinClass.Text.Equals("Economy"))
            {              
                cbWifi50.Enabled = true;
                cbSoftDrink.Enabled = true;
            }
            else if (lbCabinClass.Text.Equals("Business"))
            {
                cbExBlanket.Enabled = true;
                cbTableRetal.Enabled = true;              
                cbLoungeAccess.Enabled = true;
                cbWifi50.Enabled = true;
                cbSoftDrink.Enabled = true;
            }
            else
            {
                cbExBlanket.Enabled = true;
                cbTableRetal.Enabled = true;
                cbLaptopRental.Enabled = true;
                cbLoungeAccess.Enabled = true;
                cbHeadPhone.Enabled = true;
                cbExBag.Enabled = true;
                cbWifi250.Enabled = true;
                cbSoftDrink.Enabled = true;
            }
            itemSelected = 0;
            taxes = 0;
            total = 0;
            //kiem tra dich vu da chon chua
            amenitiesService = new List<int>();
            amenitiesService = DAO.GetAmanitiesService(ticketID);
            for (int i = 0; i < amenitiesService.Count; i++)
            {
                CheckAmanitiesService(amenitiesService[i]);
            }
            lastTotal = DAO.GetAmanitiesTotalPrice(ticketID);
            if (lastTotal > 0)
            {
                lbTotal.Text = 0 + "";
            }            
            lbTotalPrice.Text = lastTotal + "";                    
        }

        public void CheckAmanitiesService(int amenityID)
        {
            switch (amenityID)
            {
                case 1:
                    cbExBlanket.Checked = true;                                    
                    break;
                case 2:
                    cbNextSeat.Checked = true;                   
                    break;
                case 3:
                    cbNeighboringSeat.Checked = true;                   
                    break;
                case 4:
                    cbTableRetal.Checked = true;                  
                    break;
                case 5:
                    cbLaptopRental.Checked = true;                    
                    break;
                case 6:
                    cbLoungeAccess.Checked = true;                   
                    break;
                case 7:
                    cbSoftDrink.Checked = true;                  
                    break;
                case 8:
                    cbHeadPhone.Checked = true;                    
                    break;
                case 9:
                    cbExBag.Checked = true;                   
                    break;
                case 10:
                    cbCheckin.Checked = true;                   
                    break;
                case 11:
                    cbWifi50.Checked = true;                  
                    break;
                case 12:
                    cbWifi250.Checked = true;                    
                    break;                              
                default:
                    break;
            }           
        }

        private void cbLoungeAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoungeAccess.Checked)
            {
                itemSelected += 25;
            }
            else
            {
                itemSelected -= 25;
            }
            UpdateTotal();
        }

        private void cbWifi250_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWifi250.Checked)
            {
                itemSelected += 25;
            }
            else
            {
                itemSelected -= 25;
            }
            UpdateTotal();
        }

        private void cbExtraBag_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExBlanket.Checked)
            {
                itemSelected += 10;
            }
            else
            {
                itemSelected -= 10;
            }
            UpdateTotal();
        }

        private void cbLaptopRental_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLaptopRental.Checked)
            {
                itemSelected += 15;
            }
            else
            {
                itemSelected -= 15;
            }
            UpdateTotal();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CheckBox[] checkboxes = {cbExBlanket, cbNextSeat, cbNeighboringSeat, cbTableRetal, 
                cbLaptopRental, cbLoungeAccess, cbSoftDrink, cbHeadPhone, cbExBag, 
                cbCheckin, cbWifi50, cbWifi250};
            int[] prices = { 10, 30, 50, 12, 15, 25, 0, 5, 15, 10, 0, 25 };
            for (int i = 0; i < checkboxes.Length; i++)
            {
                CheckBox checkbox = checkboxes[i];
                int amenityID = i + 1;
                int price = prices[i];

                if (checkbox.Checked)
                {
                    if (checkAmanitiesExist(amenitiesService, amenityID))
                    {
                        DAO.AddAmenitiesToTicket(amenityID, ticketID, price);
                    }
                }
                else
                {
                    if (!checkAmanitiesExist(amenitiesService, amenityID))
                    {
                        DAO.DeleteAmenitiesToTicket(amenityID, ticketID);
                    }
                }
            }
            MessageBox.Show("Save success");            
            ResetCheckBox();
            txtSoThamChieu.Text = "";
            cbbFlight.DataSource = null;
        }      
        
        private bool checkAmanitiesExist(List<int> amenitiesService, int amenityId)
        {
            foreach (var item in amenitiesService)
            {
                if (item == amenityId)
                {
                    return false;
                }
            }
            return true;
        }

        private void cbNeighboringSeat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNeighboringSeat.Checked)
            {
                itemSelected += 50;
            }
            else
            {
                itemSelected -= 50;
            }
            UpdateTotal();
        }

        private void cbNextSeat_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbNextSeat.Checked)
            {
                itemSelected += 30;
            }
            else
            {
                itemSelected -= 30;
            }
            UpdateTotal();
        }

        private void cbTableRetal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTableRetal.Checked)
            {
                itemSelected += 12;
            }
            else
            {
                itemSelected -= 12;
            }
            UpdateTotal();
        }

        private void cbSoftDrink_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbHeadPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHeadPhone.Checked)
            {
                itemSelected += 5;
            }
            else
            {
                itemSelected -= 5;
            }
            UpdateTotal();
        }

        private void cbExBag_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExBag.Checked)
            {
                itemSelected += 15;
            }
            else
            {
                itemSelected -= 15;
            }
            UpdateTotal();
        }

        private void cbCheckin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheckin.Checked)
            {
                itemSelected += 10;
            }
            else
            {
                itemSelected -= 10;
            }
            UpdateTotal();
        }

        private void lbTotalPrice_Click(object sender, EventArgs e)
        {

        }
        private void UpdateTotal()
        {
            taxes = itemSelected * 0.05;
            total = itemSelected + taxes - lastTotal;

            lbItemSelected.Text = itemSelected.ToString();
            lbTaxes.Text = taxes.ToString();
            lbTotal.Text = total.ToString();

            if (total < 0)
            {
                lbTotal.Text += " (refunds)";
            }
        }
        private void ResetCheckBox()
        {
            lbCabinClass.Text = "";
            lbFullName.Text = "";
            lbPassport.Text = "";
            cbExBag.Enabled = false;
            cbCheckin.Enabled = false;
            cbExBlanket.Enabled = false;
            cbHeadPhone.Enabled = false;
            cbNextSeat.Enabled = false;
            cbNeighboringSeat.Enabled = false;
            cbTableRetal.Enabled = false;
            cbWifi250.Enabled = false;
            cbLaptopRental.Enabled = false;
            cbLoungeAccess.Enabled = false;
            cbWifi50.Enabled = false;
            cbSoftDrink.Enabled = false;
            cbExBag.Checked = false;
            cbCheckin.Checked = false;
            cbExBlanket.Checked = false;
            cbHeadPhone.Checked = false;
            cbNextSeat.Checked = false;
            cbNeighboringSeat.Checked = false;
            cbTableRetal.Checked = false;
            cbWifi250.Checked = false;
            cbLaptopRental.Checked = false;
            cbLoungeAccess.Checked = false;
            cbWifi50.Checked = false;
            cbSoftDrink.Checked = false;
            lbItemSelected.Text = 0 + "";
            lbTaxes.Text = 0 + "";
            lbTotal.Text = 0 + "";
            itemSelected = 0;
            taxes = 0;
            total = 0;
        }

        private void AmenitiesFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to exit", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
