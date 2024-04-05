using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using VnAirLines.Models;

namespace VnAirLines
{
    public partial class BookingConfirmFrm : Form
    {
        private BindingList<Passenger> passengers;
        string date, time, flightNumber;

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BookingConfirmFrm_Load(object sender, EventArgs e)
        {

        }

        public BookingConfirmFrm(BindingList<Passenger> passengers, string date, string time, string flightNumber, double totalPrice)
        {
            InitializeComponent();
            this.passengers = passengers;
            this.date = date;
            this.time = time;
            this.flightNumber = flightNumber;
            lbTotalPrice.Text = totalPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {       
                string idSchedule = DAO.GetIdSchedule(date, time, flightNumber);
                foreach (var p in passengers)
                {
                    DAO.BuyTicket(p, idSchedule);
                }
            }
            catch (Exception)
            {
            }
            finally 
            {
                Close();
            }
        }
    }
}
