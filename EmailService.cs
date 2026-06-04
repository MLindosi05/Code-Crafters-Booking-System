using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Code_Crafters_Booking_System
{
    public static class EmailService
    {
        private const string SmtpHost = "smtp.gmail.com";
        private const string SmtpPort = "587";

        // This account functions as both the Authenticated Sender and the Master Monitor
        private const string SenderEmail = "mlambomlindosi@gmail.com";
        private const string SenderPassword = "hzlmhoybzvbayoqd";

        /// <summary>
        /// Dispatches a styled email message to the client and automatically CCs the master account.
        /// </summary>
        public static void SendEmail(string recipientEmail, string subject, string bodyContent)
        {
            // Safeguard: If the client email wasn't found in the database, don't execute
            if (string.IsNullOrWhiteSpace(recipientEmail))
            {
                return;
            }

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(SenderEmail, "The Regal Inn Hotels");

                // 1. Send to the client record found in the database
                mail.To.Add(recipientEmail.Trim());

                // 2. Automatically Carbon Copy (CC) your hardcoded business email
                // This ensures you track every single login, booking update, and payment action.
                if (!recipientEmail.Trim().Equals(SenderEmail, StringComparison.OrdinalIgnoreCase))
                {
                    mail.CC.Add(SenderEmail);
                }

                mail.Subject = subject;
                mail.Body = bodyContent;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient(SmtpHost);
                smtp.Port = Convert.ToInt32(SmtpPort);
                smtp.Credentials = new NetworkCredential(SenderEmail, SenderPassword);
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operational confirmation email failed to dispatch automatically:\n\n" + ex.Message,
                                "Mailing System Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}