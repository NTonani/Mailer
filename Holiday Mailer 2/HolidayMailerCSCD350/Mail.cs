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
        private string f, recipients, name, subject, body;
        private List<string> attachedfiles;
        private MailAddress from;
        private MailMessage message;
        private SmtpClient client;

        public Mail(string from, string name, string subject, string body, List<String> attachedfiles)
        {
            this.from = new MailAddress(from,name);
            this.name = name;
            this.f = from;

            this.subject = subject;
            this.body = body;
            this.attachedfiles = attachedfiles;
            DetermineSMTP();
        }

        public void AddRecip(string recip)
        {
            this.recipients = recip;
        }

        private bool DetermineSMTP()
        {
            try
            {
                //DIDN'T DO office365, yahoo plus, at&t, 
                if (f.Contains("@gmail"))
                    client = new SmtpClient("smtp.gmail.com", 587);
                else if (f.Contains("@outlook"))
                    client = new SmtpClient("smtp.live.com", 587);
                else if (f.Contains("@yahoo"))
                    client = new SmtpClient("smtp.mail.yahoo.com", 587);
                else if (f.Contains("@hotmail"))
                    client = new SmtpClient("smtp.live.com", 587);
                else if (f.Contains("@comcast"))
                    client = new SmtpClient("smtp.comcast.net", 587);
                else if (f.Contains("@verizon"))
                    client = new SmtpClient("outgoing.verizon.net", 587);
                else if (f.Contains("@mail"))
                    client = new SmtpClient("smtp.mail.com", 587);
                else
                    return false;
                return true; ;
            }
            catch (Exception err)
            {
                return false;
            }
        }

        public bool ValidateEmail(string address)
        {
            if (Regex.IsMatch(address, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
        }

        public bool Send(string pswrd, BackgroundWorker worker, DoWorkEventArgs e)
        {
            //REMEMBER GMAIL USERS MUST ENABLE LESSSECUREAPPS https://www.google.com/settings/security/lesssecureapps
            try
            {
                using (BackgroundWorker b = new BackgroundWorker())
                {

                    message = new MailMessage();
                    message.From = from;

                    //written by Rhyous - stackoverflow.com/questions/5342375/c-sharp-regex-email-validation 
                    // going to move this to the mailerform 
                   // Regex regex = new Regex();

                    foreach (string address in recipients.Split(','))
                    {
                      //  Match match = regex.Match(address);
                        if (ValidateEmail(address.Trim()))
                        {
                            message.To.Add(address);
                        }
                    }

                    message.Subject = subject;
                    message.Body = body;
                    for (int i = 0; i < attachedfiles.Count; i++)
                    {
                        message.Attachments.Add(new Attachment(attachedfiles[i]));
                    }

                    client.UseDefaultCredentials = false;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Credentials = new NetworkCredential(f, pswrd);
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
