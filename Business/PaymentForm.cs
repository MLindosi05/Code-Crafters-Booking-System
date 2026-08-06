using Code_Crafters_Interface_Prototype_1;
using Code_Crafters_Interface_Prototype_1.codeCraftersDSTWOTableAdapters;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Code_Crafters_Interface_Prototype_1.Common;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class PaymentForm : Form
    {
        private int _bookingID;
        private codeCraftersDSTWO _dataSet;
        private BookingTableAdapter _taBooking;
        private string _selectedPaymentMethod = "Card";

        public PaymentForm()
        {
            InitializeComponent();
            WireUpPaymentEvents();
        }

        public PaymentForm(int bookingID, codeCraftersDSTWO dataSet, BookingTableAdapter taBooking)
        {
            InitializeComponent();
            _bookingID = bookingID;
            _dataSet = dataSet;
            _taBooking = taBooking;

            WireUpPaymentEvents();
        }

        private void WireUpPaymentEvents()
        {
            this.btnCash.Click += (s, e) => SelectPaymentMethod("Cash", btnCash);
            this.btnCard.Click += (s, e) => SelectPaymentMethod("Card", btnCard);
            this.btnEFT.Click += (s, e) => SelectPaymentMethod("EFT", btnEFT);

            this.numAmountPaid.ValueChanged += new EventHandler(this.numAmountPaid_ValueChanged);

            // FIXED: Wire up missing action button event handlers so clicks execute successfully
            this.btnProcessPayment.Click += new System.EventHandler(this.btnProcessPayment_Click_1);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            dtpPaymentDate.Format = DateTimePickerFormat.Custom;
            dtpPaymentDate.CustomFormat = "yyyy/MM/dd";
            dtpPaymentDate.Value = DateTime.Now;
            SelectPaymentMethod("Card", btnCard);

            if (_dataSet != null)
            {
                LoadBookingSummaryDetails();
            }
        }

        #region Load & Populate Booking Data

        private void LoadBookingSummaryDetails()
        {
            try
            {
                if (_dataSet == null || _dataSet.Booking == null) return;

                DataRow bookingRow = _dataSet.Booking.FindByBooking_ID(_bookingID);

                if (bookingRow == null)
                {
                    MessageBox.Show("Booking record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                int clientID = Convert.ToInt32(bookingRow["Client_ID"]);
                DataRow clientRow = _dataSet.Client.FindByClient_ID(clientID);

                txtBookingReference.Text = $"BKG{_bookingID:D4}";

                if (clientRow != null)
                {
                    txtGuestName.Text = $"{clientRow["First_Name"]} {clientRow["Last_Name"]}".Trim();
                    txtEmailAddress.Text = clientRow["Email_Address"]?.ToString() ?? "N/A";
                    txtPhoneNo.Text = clientRow["Phone_Number"]?.ToString() ?? "N/A";
                }

                DateTime checkIn = Convert.ToDateTime(bookingRow["Checkin_Date"]);
                DateTime checkOut = Convert.ToDateTime(bookingRow["Checkout_Date"]);
                int nights = (checkOut.Date - checkIn.Date).Days;

                string bookingType = bookingRow.Table.Columns.Contains("Booking_Type") ? bookingRow["Booking_Type"].ToString() : "";

                txtCheckIn.Text = checkIn.ToString("yyyy/MM/dd");
                txtCheckOut.Text = checkOut.ToString("yyyy/MM/dd");

                if (bookingType == "Table Booking")
                {
                    txtNoOfNights.Text = "0";
                }
                else
                {
                    txtNoOfNights.Text = (nights > 0 ? nights : 1).ToString();
                }

                txtNoOfGuests.Text = bookingRow.Table.Columns.Contains("Number_Adults") && bookingRow["Number_Adults"] != DBNull.Value ? bookingRow["Number_Adults"].ToString() : "2";

                DataRow roomAssign = _dataSet.Room_Assignment.AsEnumerable()
                    .FirstOrDefault(ra => ra.Field<int>("Booking_ID") == _bookingID);

                DataRow tableAlloc = _dataSet.Table_Allocation.AsEnumerable()
                    .FirstOrDefault(ta => ta.Field<int>("Booking_ID") == _bookingID);

                DataRow actualRoom = roomAssign != null ? _dataSet.Hotel_Room.FindByHotel_Room_ID(roomAssign.Field<int>("Hotel_Room_ID")) : null;
                DataRow actualTable = tableAlloc != null ? _dataSet.Restuarant_Table.FindByRestaurantTableID(tableAlloc.Field<int>("Restuarant_Table_ID")) : null;

                string roomNum = (actualRoom != null && actualRoom.Table.Columns.Contains("hotel_room_number")) ? actualRoom["hotel_room_number"].ToString() : "";
                string roomType = (actualRoom != null && actualRoom.Table.Columns.Contains("hotel_room_type")) ? actualRoom["hotel_room_type"].ToString() : "";

                string tableNum = (actualTable != null && actualTable.Table.Columns.Contains("RestuarantTableNum")) ? actualTable["RestuarantTableNum"].ToString() : "";
                string tableArea = (actualTable != null && actualTable.Table.Columns.Contains("TableFeatures")) ? actualTable["TableFeatures"].ToString() : "";

                if (bookingType == "Room & Table")
                {
                    txtRoomTable.Text = $"{roomNum} / {tableNum}";
                    txtCategoryArea.Text = $"{roomType} / {tableArea}";
                }
                else if (bookingType == "Room Booking")
                {
                    txtRoomTable.Text = roomNum;
                    txtCategoryArea.Text = roomType;
                }
                else if (bookingType == "Table Booking")
                {
                    txtRoomTable.Text = tableNum;
                    txtCategoryArea.Text = tableArea;
                }
                else
                {
                    txtRoomTable.Text = roomNum != "" ? roomNum : tableNum;
                    txtCategoryArea.Text = roomType != "" ? roomType : tableArea;
                }

                decimal totalAmount = Convert.ToDecimal(bookingRow["Booking_Total_Amount"]);
                txtTotalPrice.Text = $"R {totalAmount:N2}";
                txtTotalAmount.Text = $"R {totalAmount:N2}";

                numAmountPaid.Maximum = totalAmount * 2;
                numAmountPaid.Value = totalAmount;

                CalculateBalanceDue();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment summary: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Payment UI Interactivity

        private void SelectPaymentMethod(string method, Button selectedBtn)
        {
            _selectedPaymentMethod = method;

            btnCash.BackColor = Color.White;
            btnCard.BackColor = Color.White;
            btnEFT.BackColor = Color.White;

            btnCash.ForeColor = Color.Black;
            btnCard.ForeColor = Color.Black;
            btnEFT.ForeColor = Color.Black;

            selectedBtn.BackColor = Color.FromArgb(41, 128, 185);
            selectedBtn.ForeColor = Color.White;
        }

        private void numAmountPaid_ValueChanged(object sender, EventArgs e)
        {
            CalculateBalanceDue();
        }

        private void CalculateBalanceDue()
        {
            if (decimal.TryParse(txtTotalAmount.Text.Replace("R", "").Trim(), out decimal total))
            {
                decimal paid = numAmountPaid.Value;
                decimal balance = total - paid;

                txtBalanceDue.Text = balance <= 0 ? "R 0.00" : $"R {balance:N2}";
                txtBalanceDue.ForeColor = balance <= 0 ? Color.Green : Color.Red;
            }
        }

        #endregion

        #region Process Payment & Database Save

        private void btnProcessPayment_Click_1(object sender, EventArgs e)
        {
            if (numAmountPaid.Value <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_dataSet != null)
                {
                    DataRow bookingRow = _dataSet.Booking.FindByBooking_ID(_bookingID);

                    if (bookingRow != null)
                    {
                        // Only set to Confirmed if full balance or valid deposit is paid
                        decimal balanceDue = 0;
                        if (decimal.TryParse(txtBalanceDue.Text.Replace("R", "").Trim(), out decimal bal))
                            balanceDue = bal;

                        bookingRow["Booking_Status"] = balanceDue <= 0 ? "Confirmed" : "Deposit Paid";

                        if (_taBooking != null)
                        {
                            _taBooking.Update(_dataSet.Booking);
                        }
                    }
                }

                MessageBox.Show($"Payment of R {numAmountPaid.Value:N2} processed successfully!\nPayment Method: {_selectedPaymentMethod}",
                                "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        catch(Exception ex)
        {
                MessageBox.Show("Error processing payment: " + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            numAmountPaid.Value = 0;
            txtReceiptReference.Clear();
            txtPaymentNotes.Clear();
            dtpPaymentDate.Value = DateTime.Now;
            SelectPaymentMethod("Card", btnCard);
        }

        #endregion
    }
}