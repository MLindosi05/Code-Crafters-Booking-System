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

        private const string SenderEmail = "mlambomlindosi@gmail.com";
        private const string SenderPassword = "hzlmhoybzvbayoqd\r\n"; 

        /// <summary>
        /// Dispatches a styled email message asynchronously in the background.
        /// </summary>
        public static void SendEmail(string recipientEmail, string subject, string bodyContent)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(SenderEmail, "The Regal Inn Hotels");
                mail.To.Add(recipientEmail);
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