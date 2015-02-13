using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace HolidayMailerCSCD350
{
    class Mail
    {
        private string name, subject, body;
        private UserMail user;
        private List<string> to;
        private List<string> attachedfiles;
        private MailAddress from;
        private MailMessage message;
        private SmtpClient client;

        public Mail(UserMail user, string name, string subject, string body, List<String> attachedfiles)
        {
            this.user = user;
            this.from = new MailAddress(user.email, name);
            this.name = name;
            client = user.client;

            this.subject = subject;
            this.body = body;
            this.attachedfiles = attachedfiles;
        }

        public void AddRecip(List<string> to)
        {
            this.to = to;
        }


        public bool Send(string pswrd, BackgroundWorker worker, DoWorkEventArgs e)
        {
            //REMEMBER GMAIL USERS MUST ENABLE LESSSECUREAPPS https://www.google.com/settings/security/lesssecureapps
            try
            {
                using (worker)
                {

                    message = new MailMessage();
                    message.From = from;

                    //written by Rhyous - stackoverflow.com/questions/5342375/c-sharp-regex-email-validation 
                    // going to move this to the mailerform 
                   // Regex regex = new Regex();

                    foreach (string address in to)
                    {
                        message.To.Add(address);      
                    }

                    message.Subject = subject;
                    message.Body = body;
                    for (int i = 0; i < attachedfiles.Count; i++)
                    {
                        message.Attachments.Add(new Attachment(attachedfiles[i]));
                    }

                    client.UseDefaultCredentials = false;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Credentials = new NetworkCredential(this.user.email, pswrd);
                    client.EnableSsl = true;

                    client.Send(message);

                    return true;
                }
            }
            catch (Exception err)
            {
                return false;
            }

        }

        public bool Send(BackgroundWorker worker, DoWorkEventArgs e)
        {
            //REMEMBER GMAIL USERS MUST ENABLE LESSSECUREAPPS https://www.google.com/settings/security/lesssecureapps
            try
            {
                using (worker)
                {

                    message = new MailMessage();
                    message.From = from;

                    //written by Rhyous - stackoverflow.com/questions/5342375/c-sharp-regex-email-validation 
                    // going to move this to the mailerform 
                    // Regex regex = new Regex();

                    foreach (string address in to)
                    {
                        message.To.Add(address);
                    }

                    message.Subject = subject;
                    message.Body = body;
                    for (int i = 0; i < attachedfiles.Count; i++)
                    {
                        message.Attachments.Add(new Attachment(attachedfiles[i]));
                    }

                    client.UseDefaultCredentials = false;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Credentials = new NetworkCredential(this.user.email, user.pwd);
                    client.EnableSsl = true;

                    client.Send(message);

                    return true;
                }
            }
            catch (Exception err)
            {
                return false;
            }

        }
    }
}
