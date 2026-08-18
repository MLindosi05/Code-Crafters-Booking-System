using System;
using Code_Crafters_Booking_System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Code_Crafters_Interface_Prototype_1.Business
{
    public partial class BookingSummaryForm : Form
    {
        private int _bookingID;
        string connectionString = "Server=146.230.177.46;Database=GroupPmb2;User Id=GroupPmb2;Password=gg5dc2;TrustServerCertificate=True;";
        private codeCraftersDSTWO codeCraftersDSTWOInstance = new codeCraftersDSTWO();
        private PrintDocument printDocument = new PrintDocument();

        public BookingSummaryForm()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        public BookingSummaryForm(int bookingID)
        {
            InitializeComponent();
            _bookingID = bookingID;
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void BookingSummaryForm_Load(object sender, EventArgs e)
        {
            LoadBookingDetails();
        }

        private void LoadBookingDetails()
        {
            try
            {
                if (_bookingID > 0)
                {
                    if (taBooking != null) taBooking.Fill(codeCraftersDSTWOInstance.Booking);
                    if (taClient != null) taClient.Fill(codeCraftersDSTWOInstance.Client);

                    var bookingRow = codeCraftersDSTWOInstance.Booking.AsEnumerable()
                        .FirstOrDefault(b => b.Field<int>("Booking_ID") == _bookingID);

                    if (bookingRow != null)
                    {
                        lblBookingRefValue.Text = "BKR" + bookingRow.Booking_ID.ToString("D5");
                        lblRoomTypeValue.Text = bookingRow.Booking_Type;
                        lblCheckInValue.Text = bookingRow.Checkin_Date.ToString("yyyy/MM/dd") + " 15:00 PM";
                        lblCheckOutValue.Text = bookingRow.Checkout_Date.ToString("yyyy/MM/dd") + " 11:00 AM";
                        lblTotalAmountValue.Text = "R " + bookingRow.Booking_Total_Amount.ToString("N2");

                        int clientID = bookingRow.Field<int>("Client_ID");
                        var clientRow = codeCraftersDSTWOInstance.Client.AsEnumerable()
                            .FirstOrDefault(c => c.Field<int>("Client_ID") == clientID);

                        if (clientRow != null)
                        {
                            lblGuestNameValue.Text = clientRow.First_Name + " " + clientRow.Last_Name;
                            lblGuestEmailValue.Text = clientRow.Email_Address;
                        }
                        else
                        {
                            lblGuestNameValue.Text = "Walk-in Guest";
                            lblGuestEmailValue.Text = "N/A";
                        }

                        int adults = bookingRow.Field<int>("Number_Adults");
                        int children = bookingRow.Field<int>("Number_Children");
                        lblNumOfGuestsValue.Text = (adults + children).ToString() + $" ({adults} Adults, {children} Children)";

                        string branchID = bookingRow.Field<string>("Branch_ID");
                        string roomType = bookingRow.Booking_Type;
                        lblRoomNoValue.Text = GetAssignedRoomNumber(branchID, roomType);

                        // Fetch and display both table area features and the table number
                        lblTableAreaValue.Text = GetAssignedTableDetails(_bookingID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking summary: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetAssignedTableDetails(int bookingID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT rt.RestuarantTableNum, rt.TableFeatures 
                                     FROM Table_Allocation ta
                                     INNER JOIN Restuarant_Table rt ON ta.Restuarant_Table_ID = rt.RestaurantTableID
                                     WHERE ta.Booking_ID = @BookingID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", bookingID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string tableNum = reader["RestuarantTableNum"]?.ToString() ?? "";
                                string tableFeatures = reader["TableFeatures"]?.ToString() ?? "";

                                if (!string.IsNullOrEmpty(tableNum))
                                {
                                    return $"Table {tableNum} ({tableFeatures})";
                                }
                                else if (!string.IsNullOrEmpty(tableFeatures))
                                {
                                    return tableFeatures;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Fallback if any error occurs
            }

            return "N/A";
        }

        private string GetAssignedRoomNumber(string branchID, string roomType)
        {
            try
            {
                if (!string.IsNullOrEmpty(roomType) && roomType.Contains("("))
                {
                    int startIndex = roomType.LastIndexOf("Room");
                    if (startIndex != -1)
                    {
                        string cleanStr = roomType.Substring(startIndex + 4).Replace("(", "").Replace(")", "").Trim();
                        if (int.TryParse(cleanStr, out int roomNo))
                        {
                            return roomNo.ToString();
                        }
                    }
                }
            }
            catch
            {
                // Fallback
            }

            return "Not Assigned";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PaymentForm(_bookingID).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new BookingManagement().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BookingManagement().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);
                previewDialog.Document = printDocument;
                previewDialog.Width = 900;
                previewDialog.Height = 700;
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting up print preview: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // Fonts
            Font hotelTitleFont = new Font("Arial", 20, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 10, FontStyle.Italic);
            Font sectionHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 10, FontStyle.Regular);
            Font boldRegularFont = new Font("Arial", 10, FontStyle.Bold);
            Font totalFont = new Font("Arial", 14, FontStyle.Bold);

            Brush brush = Brushes.Black;
            Pen darkPen = new Pen(Color.Black, 1.5f);
            Pen lightPen = new Pen(Color.Gray, 1f);

            float leftMargin = 50;
            float rightMargin = 550;
            float yPos = 50;

            // --- HOTEL HEADER ---
            g.DrawString("REGAL INN HOTEL", hotelTitleFont, brush, leftMargin, yPos);
            yPos += 30;
            g.DrawString("Pietermaritzburg, KwaZulu-Natal | Tel: +27 (0)33 555 0192", subHeaderFont, brush, leftMargin, yPos);
            yPos += 20;
            g.DrawString("Email: reservations@regalinn.co.za | Web: www.regalinn.co.za", subHeaderFont, brush, leftMargin, yPos);
            yPos += 25;

            g.DrawLine(darkPen, leftMargin, yPos, rightMargin + 200, yPos);
            yPos += 20;

            // --- RECEIPT TITLE & INVOICE META ---
            g.DrawString("OFFICIAL GUEST FOLIO / RECEIPT", sectionHeaderFont, brush, leftMargin, yPos);

            string dateStr = "Date: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            g.DrawString(dateStr, regularFont, brush, rightMargin + 30, yPos);
            yPos += 30;

            // --- GUEST & BOOKING DETAILS BOX ---
            g.DrawRectangle(lightPen, leftMargin, yPos, rightMargin + 200, 115);
            float boxY = yPos + 15;

            // Adjusted column split for better spacing
            float col1LabelX = leftMargin + 15;
            float col1ValueX = leftMargin + 160;
            float col2LabelX = leftMargin + 380;
            float col2ValueX = leftMargin + 500;

            g.DrawString("Booking Ref:", boldRegularFont, brush, col1LabelX, boxY);
            g.DrawString(lblBookingRefValue.Text, regularFont, brush, col1ValueX, boxY);

            g.DrawString("Guest Name:", boldRegularFont, brush, col2LabelX, boxY);
            g.DrawString(lblGuestNameValue.Text, regularFont, brush, col2ValueX, boxY);
            boxY += 25;

            g.DrawString("Guest Email:", boldRegularFont, brush, col1LabelX, boxY);
            g.DrawString(lblGuestEmailValue.Text, regularFont, brush, col1ValueX, boxY);

            g.DrawString("Guests:", boldRegularFont, brush, col2LabelX, boxY);
            g.DrawString(lblNumOfGuestsValue.Text, regularFont, brush, col2ValueX, boxY);
            boxY += 25;

            g.DrawString("Check-In:", boldRegularFont, brush, col1LabelX, boxY);
            g.DrawString(lblCheckInValue.Text, regularFont, brush, col1ValueX, boxY);

            g.DrawString("Check-Out:", boldRegularFont, brush, col2LabelX, boxY);
            g.DrawString(lblCheckOutValue.Text, regularFont, brush, col2ValueX, boxY);

            yPos += 135;

            // --- ACCOMMODATION & AMENITIES TABLE BREAKDOWN ---
            float tableCol2X = leftMargin + 380;

            g.DrawString("DESCRIPTION", boldRegularFont, brush, leftMargin, yPos);
            g.DrawString("DETAILS / ASSIGNMENT", boldRegularFont, brush, tableCol2X, yPos);
            yPos += 15;
            g.DrawLine(darkPen, leftMargin, yPos, rightMargin + 200, yPos);
            yPos += 20;

            // Room Details Row
            g.DrawString("Accommodation (" + lblRoomTypeValue.Text + ")", regularFont, brush, leftMargin, yPos);
            g.DrawString("Room No: " + lblRoomNoValue.Text, regularFont, brush, tableCol2X, yPos);
            yPos += 25;

            // Restaurant Table Row
            g.DrawString("Restaurant Table Allocation", regularFont, brush, leftMargin, yPos);
            g.DrawString(lblTableAreaValue.Text, regularFont, brush, tableCol2X, yPos);
            yPos += 30;

            g.DrawLine(lightPen, leftMargin, yPos, rightMargin + 200, yPos);
            yPos += 25;

            // --- TOTAL AMOUNT SECTION ---
            g.DrawString("TOTAL BALANCE DUE:", totalFont, brush, leftMargin, yPos);
            g.DrawString(lblTotalAmountValue.Text, totalFont, brush, tableCol2X, yPos);
            yPos += 50;

            // --- FOOTER TERMS ---
            Font footerFont = new Font("Arial", 9, FontStyle.Italic);
            g.DrawString("Terms & Conditions: Check-in time is 15:00 PM, Check-out time is 11:00 AM.", footerFont, brush, leftMargin, yPos);
            yPos += 18;
            g.DrawString("Thank you for choosing Regal Inn. We look forward to hosting you!", footerFont, brush, leftMargin, yPos);
        }
    }
}