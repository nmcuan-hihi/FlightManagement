using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VnAirLines.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace VnAirLines
{
    public class DAO
    {
        static SqlConnection knoi = Connection.Connect();
        public static DataTable GetDataSanBay()
        {
            DataTable tbl = new DataTable();
            string sql = "SELECT * FROM Airports";
            SqlCommand cmd = new SqlCommand(sql, knoi);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(tbl);
            return tbl;
        }

        public static DataTable GetDataCabinType()
        {
            DataTable tbl = new DataTable();
            string sql = "SELECT * FROM CabinTypes";
            SqlCommand cmd = new SqlCommand(sql, knoi);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(tbl);
            return tbl;
        }

        public static DataTable GetDataChuyenBay(string iDFrom, string idTo, string date)
        {
            DataTable tbl = new DataTable();
           
            string sql = $"SELECT \r\n    (SELECT Airports.IATACode FROM Airports WHERE Airports.ID = R.DepartureAirportID) AS DepartureAirport,\r\n    (SELECT Airports.IATACode FROM Airports WHERE Airports.ID = R.ArrivalAirportID) AS ArrivalAirport,\r\n    S.Date,\r\n    S.Time,\r\n    S.FlightNumber,\r\n    S.EconomyPrice, 0 as NumberOfStop FROM \r\n    Routes R,\r\n    Schedules S\r\nWHERE \r\n    R.ID = S.RouteID \r\n    AND R.DepartureAirportID = '{iDFrom}' \r\n    AND R.ArrivalAirportID = '{idTo}' \r\n    AND S.Date BETWEEN DATEADD(DAY, -3, '{date}') AND DATEADD(DAY, 3, '{date}')";
            SqlCommand cmd = new SqlCommand(sql, knoi);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(tbl);
            return tbl;
        }
        public static DataTable GetDataChuyenBay(string iDFrom, string idTo, string date, string d1, string d2)
        {
            DataTable tbl = new DataTable();
           
            string sql = $"SELECT \r\n    (SELECT Airports.IATACode FROM Airports WHERE Airports.ID = R.DepartureAirportID) AS DepartureAirport,\r\n    (SELECT Airports.IATACode FROM Airports WHERE Airports.ID = R.ArrivalAirportID) AS ArrivalAirport,\r\n    S.Date,\r\n    S.Time,\r\n    S.FlightNumber,\r\n    S.EconomyPrice, 0 as NumberOfStop FROM \r\n    Routes R,\r\n    Schedules S\r\nWHERE \r\n    R.ID = S.RouteID \r\n    AND R.DepartureAirportID = '{iDFrom}' \r\n    AND R.ArrivalAirportID = '{idTo}' \r\n    AND S.Date BETWEEN DATEADD(DAY, -{d1}, '{date}') AND DATEADD(DAY, {d2}, '{date}')";
            SqlCommand cmd = new SqlCommand(sql, knoi);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(tbl);
            return tbl;
        }

       
        public static DataTable GetCountries()
        {
            DataTable tbl = new DataTable();
            string sql = $"select * from Countries";
            SqlCommand cmd = new SqlCommand(sql, knoi);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(tbl);
            return tbl;
        }

        public static string GetIdSchedule(string date, string time, string flightNumber)
        {
            string id = null;
            string day = date.Split('/')[1];
            string month = date.Split('/')[0];
            string year = date.Split('/')[2];
            date = $"{year}/{month}/{day}";
            //DAO.BuyTicket(passengers);
            SqlConnection conn = Connection.Connect();
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select ID from Schedules " +
                $"where Date = '{date}' and " +
                $"Time = '{time}' and " +
                $"FlightNumber = '{flightNumber}'";
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id = reader.GetString(0);

            }
            conn.Close();
            return id;
        }



        public static void BuyTicket(Passenger p, string idSchedule)
        {

            string sql = $"insert into Tickets(UserID,ScheduleID,CabinTypeID,FirstName,LastName,Phone,PassportNumber,PassportCountryID,BookingReference,Confirmed) " +
                $"values ({1},{idSchedule},{1},'{p.FirstName}','{p.LastName}','{p.Phone}','{p.PassportNumber}','{p.PassportCountry}', '{GenerateBookingReference()}',{1})";
            var conn = Connection.Connect();
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close(); 
        }
        private static string GenerateBookingReference()
        {
            Random random = new Random();

            // Độ dài của chuỗi ký tự bạn muốn tạo
            int length = 6;

            // Tạo một mảng char để chứa các ký tự
            char[] chars = new char[length];

            // Khai báo các ký tự bạn muốn sử dụng
            string possibleChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Sinh ngẫu nhiên các ký tự và thêm chúng vào mảng
            for (int i = 0; i < length; i++)
            {
                chars[i] = possibleChars[random.Next(possibleChars.Length)];
            }

            // Chuyển mảng char thành chuỗi ký tự
            return new string(chars);
        }
        public static DataTable GetDataFligthByBookingReferences(string bookingReferences)
        {
            DataTable tbl = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("FlightByBookingReferences", knoi);
                knoi.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookingReference", bookingReferences);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(tbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                knoi.Close();
            }
            return tbl;
        }

        public static List<string> GetPassengerDetails(int ticketID)
        {
            List<string> passengerInfo = new List<string>();
            try
            {
                SqlCommand cmd = new SqlCommand("PassengerDetails", knoi);
                knoi.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TicketID", ticketID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string passengerName = reader["PassengerName"].ToString();
                    string passportNumber = reader["PassportNumber"].ToString();
                    string cabinType = reader["CabinType"].ToString();
                    passengerInfo.Add(passengerName);
                    passengerInfo.Add(passportNumber);
                    passengerInfo.Add(cabinType);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                knoi.Close();
            }
            return passengerInfo;
        }
        public static List<int> GetAmanitiesService(int ticketID)
        {
            List<int> amanitiesService = new List<int>();
            try
            {
                SqlCommand cmd = new SqlCommand("GetAmenitiesService", knoi);
                knoi.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TicketID", ticketID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int service = int.Parse(reader["id"].ToString());
                    amanitiesService.Add(service);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                knoi.Close();
            }
            return amanitiesService;
        }
        public static int GetTicketIDByFlightListAndBookingReference(DateTime date, TimeSpan time, string departureAirportCode, string arrivalAirportCode, string bookingReference, int scheduleID)
        {
            int ticketID = -1;
            try
            {
                knoi.Open();
                SqlCommand cmd = new SqlCommand("GetTicketIDByFlightListAndBookingReference", knoi);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@Time", time);
                cmd.Parameters.AddWithValue("@DepartureAirportCode", departureAirportCode);
                cmd.Parameters.AddWithValue("@ArrivalAirportCode", arrivalAirportCode);
                cmd.Parameters.AddWithValue("@BookingReference", bookingReference);
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ticketID = Convert.ToInt32(reader["TicketID"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { knoi.Close(); }
            return ticketID;
        }

        public static void AddAmenitiesToTicket(int amenityID, int ticketID, decimal price)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("addAmenitiesTickets", knoi);
                knoi.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AmenityID", amenityID);
                cmd.Parameters.AddWithValue("@TicketID", ticketID);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                knoi.Close();
            }
        }

        public static float GetAmanitiesTotalPrice(int ticketID)
        {
            float totalPrice = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("getAmanitiesTotalPrice", knoi);
                knoi.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ticketID", ticketID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    totalPrice = Convert.ToSingle(reader["totalPrice"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                knoi.Close();
            }
            return totalPrice;
        }
        public static void DeleteAmenitiesToTicket(int amenityID, int ticketID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deleteAmenitiesTickets", knoi);
                knoi.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AmenityID", amenityID);
                cmd.Parameters.AddWithValue("@TicketID", ticketID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                knoi.Close();
            }
        }


    }
}
