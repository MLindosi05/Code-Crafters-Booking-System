using Code_Crafters_Booking_System;
using Code_Crafters_Interface_Prototype_1.codeCraftersDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class BookingForm : Form
    {
        decimal totalBookingRoomAmount = 0;
        decimal totalBookingRestaurantTableAmount = 0;


        public BookingForm()
        {
            InitializeComponent();

            this.Load += BookingForm_Load;


            pnlBooking.Dock = DockStyle.Fill;
            pnlBooking.AutoScroll = true;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            taClient.Fill(codeCraftersDS.Client);
            taBranch.Fill(codeCraftersDS.Branch);
            taHotelRoom.Fill(codeCraftersDS.Hotel_Room);
            taRestaurantTable.Fill(codeCraftersDS.Restuarant_Table);
            taRatePlan.Fill(codeCraftersDS.Rate_Plan);

            
        }

        private void ClearControls()
        {
            
        }

        private void CalculateTotalAmount()
        {
           
        }



        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            //try
            //{
              

            //    if (true)
            //    {
            //        if (true) { 

            //        if (true)
            //        {
            //            MessageBox.Show("Sorry, this room is already booked for the selected dates/times.",
            //                            "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }

            //    if (true)
            //    {
                    

            //        if (true)
            //        {
            //            MessageBox.Show("Sorry, this restaurant table is already reserved for the selected timeframe.",
            //                            "Table Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }

       
         
              

                //MessageBox.Show(
                //    "BOOKING SUCCESSFULLY CREATED\n\n" +
                //    "Booking Reference : " 
                //    "\nClient : " 
                //    "\nBooking Type : " 
                //    "\nCheck-In : "
                //    "\nStatus : Pending",
                //    "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //DataRowView selectedClientRow = (DataRowView)cmbClient.SelectedItem;
                //if (selectedClientRow != null && selectedClientRow.Row.Table.Columns.Contains("Email_Address"))
                //{
                //    string clientEmail = selectedClientRow["Email_Address"].ToString();
                //    string clientName = selectedClientRow["First_Name"].ToString();

                //    if (!string.IsNullOrEmpty(clientEmail))
                //    {
                //        string emailSubject = $"The Regal Inn - Booking Received! Ref: #{bookingID}";
                //        string emailBody = $@"
                //        <div style='font-family: Arial, sans-serif; max-width: 600px; border: 1px solid #dcdcdc; padding: 20px;'>
                //            <h2 style='color: #4A154B;'>Hello {clientName},</h2>
                //            <p>Your booking request has been successfully created and is currently <b>Pending Payment</b>.</p>
                //            <hr style='border: 0; border-top: 1px solid #eee;' />
                //            <p><b>Booking Details:</b></p>
                //            <ul>
                //                <li><b>Booking Reference:</b> #{bookingID}</li>
                //                <li><b>Type:</b> {bookingType}</li>
                //                <li><b>Check-In:</b> {checkInDate.ToString("dd MMM yyyy HH:mm")}</li>
                //                <li><b>Total Amount:</b> R {bookingAmount:0.00}</li>
                //            </ul>
                //            <hr style='border: 0; border-top: 1px solid #eee;' />
                //            <p style='font-size: 12px; color: #888;'>This is an automated system confirmation notification. Please do not reply directly to this message.</p>
                //        </div>";

                //        EmailService.SendEmail(clientEmail, emailSubject, emailBody);
                //    }
                //}

        //        ClearControls();

        //        PaymentForm paymentForm = new PaymentForm(bookingID, bookingAmount, clientID);
        //        paymentForm.Show();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        }
       
        private void txtHotelRoomAvailable_TextChanged(object sender, EventArgs e)
        {
            taHotelRoom.FillByHotelRoomID(codeCraftersDS.Hotel_Room, Convert.ToInt32(txtHotelRoomAvailable.Text));

        }

        private void txtRestaurantTableAvailable_TextChanged(object sender, EventArgs e)
        {
            taRestaurantTable.FillByRestaurantTableID(codeCraftersDS.Restuarant_Table, Convert.ToInt32(txtRestaurantTableAvailable.Text));
        }

        private void dgvHotelRoomAvailable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            totalBookingRoomAmount = 0;

            int roomID = Convert.ToInt32(dgvHotelRoomAvailable.CurrentRow.Cells[0]);
            int roomNumber = Convert.ToInt32(dgvHotelRoomAvailable.CurrentRow.Cells[3].Value);
            decimal roomPrice = Convert.ToDecimal(dgvHotelRoomAvailable.CurrentRow.Cells[5].Value);

         

            codeCraftersDS.Invoice.Rows.Add(roomID, roomNumber, roomPrice);
            dgvInvoice.DataSource = codeCraftersDS.Invoice;

            for (int i = 0; i < dgvHotelRoomAvailable.Rows.Count - 1; i++)
            {
                totalBookingRoomAmount += Convert.ToDecimal(dgvHotelRoomAvailable.Rows[i].Cells[5].Value);
            }
            txtTotalAmount.Text += totalBookingRoomAmount.ToString("C2");
        }

        private void dgvRestaurantTableAvailable_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}