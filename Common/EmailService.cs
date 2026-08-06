using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Code_Crafters_Booking_System
{
    public static class EmailService
    {
        private const string SmtpHost = "smtp.gmail.com";
        private const int SmtpPort = 587;

        private const string SenderEmail = "mlambomlindosi@gmail.com";

        private const string SenderPassword = "dugyoobzyknoyvap";

        public static void SendEmail(string recipientEmail, string subject, string bodyContent)
        {
            if (string.IsNullOrWhiteSpace(recipientEmail))
                return;

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(SenderEmail, "The Regal Inn Hotels");

                    mail.To.Add(recipientEmail.Trim());

                    if (!recipientEmail.Trim().Equals(SenderEmail, StringComparison.OrdinalIgnoreCase))
                    {
                        mail.CC.Add(SenderEmail);
                    }

                    mail.Subject = subject;
                    mail.Body = bodyContent;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(SmtpHost, SmtpPort))
                    {
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;

                        smtp.Credentials = new NetworkCredential(
                            SenderEmail,
                            SenderPassword.Trim()
                        );

                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                        smtp.Send(mail);
                    }
                }

            }
            catch (SmtpException ex)
            {
                MessageBox.Show(
                    $"SMTP ERROR\n\n" +
                    $"Status Code: {ex.StatusCode}\n\n" +
                    $"Message:\n{ex.Message}\n\n" +
                    $"Details:\n{ex}",
                    "SMTP Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"GENERAL ERROR\n\n{ex}",
                    "Email Service Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}