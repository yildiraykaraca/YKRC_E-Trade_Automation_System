using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Net;

namespace Abc.MvcWebUI.Models
{
    public void SendEmail(string toAdress, string fromAdress,
                          string subject, string message)
    {

        try

        {
            using (var mail = new MailMessage())
            {
                const string email = "Eposta Adresi Gelecek";
                const string password = "Şifre Gelecek";

                var loginInfo = new NetworkCredential(email, password);

                mail.From = new MailAddress(fromAdress);
                // mail.To.Add(new MailAddress)(toAdress));
                mail.Subject = subject;
                mail.Body = message;
                mail.IsBodyHtml = true;

                try
                {
                    using (var smtpClient = new SmtpClient("smtp.mail.gmail.com", 465))
                    {
                        smtpClient.EnableSsl = true;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = loginInfo;
                        smtpClient.Send(mail);

                    }
                }
                finally
                {
                    //dispose the client
                    mail.Dispose();
                }
            }
        }
        catch (SmtpFailedRecipientsException ex)
        {
            foreach (SmtpFailedRecipientsException t in ex.InnerExceptions)
            {
                var status = t.StatusCode;
                if (status == SmtpStatusCode.MailboxBusy || status == SmtpStatusCode.MailboxUnavailable)
                {
                    FileWebResponse.Equals
                }
            }
        }
    }