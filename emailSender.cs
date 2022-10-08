using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPED
{
    public static class emailSender
    {
        public static bool Send(string emailAdresses, string subject, string body)
        {
            // Open SMTP client for Office 365.
            using (SmtpClient client = GetSmtpClient())
            {
                #region Create mail message
                var to = emailAdresses.Split(';');
                // Define email message.
                using (MailMessage message = new MailMessage())
                {
                    // Set from address.
                    message.From = new MailAddress(((NetworkCredential)client.Credentials).UserName);
                    foreach (string address in to)
                    {
                        message.To.Add(address);
                    }


                    message.CC.Add("michalprzyszlak@effectphotonics.com");

                    // Set subject and body.
                    message.Subject = subject;
                    message.IsBodyHtml = true;
                    message.Body = body;

                    #region Create attachment

                    
                    // Send message.
                    try
                    {
                        client.Send(message);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to send email for this order " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    #endregion
                }
                #endregion
            }

        }



        #region GetSmtpClient

        /// <summary>
        /// Get SMTP client.
        /// </summary>
        /// <returns>SMTP client.</returns>
        /// <remarks>The SMTP client should be disposed after use.</remarks>
        private static SmtpClient GetSmtpClient()
        {
            // Create SMTP client...
            SmtpClient client = new SmtpClient("smtp.live.com", 587);

            // Setup SMTP client.
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            #region client.Credentials = new NetworkCredential(no-reply@effectphotonics.com, ...)
            #region Confidential
            #region Confidential
            #region Confidential
            client.Credentials = new NetworkCredential("no-reply@effectphotonics.com", "Te4QUnbP#8");
            #endregion
            #endregion
            #endregion
            #endregion
            client.Timeout = 5000;

            return client;
        }
        #endregion
    }
}
