using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.ComponentModel;

namespace HolidayMailerCSCD350
{
    class Mail
    {
        private string f, t, name, subject, body;
        private List<String> attachedfiles;
        private MailAddress from, to;
        private MailMessage message;
        private SmtpClient client;

        public Mail(string from, string name, string subject, string body, List<String> attachedfiles)
        {
            this.t = "";
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
            t += recip;
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

        public string Send(string pswrd, BackgroundWorker worker, DoWorkEventArgs e)
        {
            //REMEMBER GMAIL USERS MUST ENABLE LESSSECUREAPPS https://www.google.com/settings/security/lesssecureapps
            try
            {
                using (BackgroundWorker b = new BackgroundWorker())
                {
                    if (t != "")
                    {
                        to = new MailAddress(t);
                        message = new MailMessage(from, to);
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
                        return null;
                    }
                    return "empty?";
                }
            }
            catch (Exception er)
            {
                return er.ToString();
            }

        }
    }
}
