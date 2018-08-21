using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestSMTPServer.Utils
{
    public static class MailUtility
    {
        /// <summary>
        /// Send emails in background
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="listAttachments"></param>
        /// <param name="to"></param>
        /// <param name="cc"></param>
        /// <param name="bcc"></param>
        /// <param name="priority"></param>
        /// <returns></returns>
        public static bool SentEmail(string subject, string body,
            List<System.Net.Mail.Attachment> listAttachments = null,
            List<string> to = null, List<string> cc = null, List<string> bcc = null,
            System.Net.Mail.MailPriority priority = System.Net.Mail.MailPriority.Normal)
        {

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress(Properties.Settings.Default.SmtpEmail, Properties.Settings.Default.SmtpDisplayName);

            //Adding the emails addresses
            if (to != null)
            {
                foreach (var destinatario in to)
                {
                    mail.To.Add(new System.Net.Mail.MailAddress(destinatario));
                }
            }
            if (cc != null)
            {
                foreach (var destinatario in cc)
                {
                    mail.CC.Add(new System.Net.Mail.MailAddress(destinatario));
                }
            }
            if (bcc != null)
            {
                foreach (var destinatario in bcc)
                {
                    mail.Bcc.Add(new System.Net.Mail.MailAddress(destinatario));
                }
            }


            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            mail.Priority = priority;
            System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient(Properties.Settings.Default.SmtpServer, Properties.Settings.Default.SmtpPort);
            smtpClient.UseDefaultCredentials = true;
            smtpClient.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.SmtpEmail, Properties.Settings.Default.SmtpPassword);
            smtpClient.EnableSsl = Properties.Settings.Default.SmtpSSL;

            if (listAttachments != null)
            {
                foreach (var x in listAttachments)
                {
                    mail.Attachments.Add(x);
                }
            }

            // Sent the message
            try
            {
                Console.WriteLine("Sending email...");
                smtpClient.Send(mail);
                Console.WriteLine("Email sent successfully");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sending error \n" + ex.StackTrace + " \n" + ex.InnerException.ToString());
                return false;
            }



        }
    }
}
