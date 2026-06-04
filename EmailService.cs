using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Code_Crafters_Booking_System
{
    public static class EmailService
    {
        private const string SmtpHost = "smtp.gmail.com";

        // Port 587 is the universal standard for modern secure TLS submission.
        private const string SmtpPort = "587";

        private const string SenderEmail = "mlambomlindosi@gmail.com";
        private const string SenderPassword = "hzlmhoybzvbayoqd";

        public static void SendEmail(string recipientEmail, string subject, string bodyContent)
        {
            if (string.IsNullOrWhiteSpace(recipientEmail)) return;

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(SenderEmail, "The Regal Inn Hotels");
                mail.To.Add(recipientEmail.Trim());

                if (!recipientEmail.Trim().Equals(SenderEmail, StringComparison.OrdinalIgnoreCase))
                {
                    mail.CC.Add(SenderEmail);
                }

                mail.Subject = subject;
                mail.Body = bodyContent;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient(SmtpHost))
                {
                    smtp.Port = Convert.ToInt32(SmtpPort);
                    smtp.Credentials = new NetworkCredential(SenderEmail, SenderPassword);
                    smtp.EnableSsl = true;

                    // NETWORK BYPASS FIX FOR VPNs:
                    // Tells the operating system to send directly via the external interface 
                    // and drops local authentication credential caching which GlobalProtect interferes with.
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;

                    smtp.Send(mail);
                }
            }
            catch (Exception ex)
            {
                // We are using ex.ToString() here so you can read the complete inner technical reason!
                MessageBox.Show("Operational confirmation email failed to dispatch automatically:\n\n" + ex.ToString(),
                                "Mailing System Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}