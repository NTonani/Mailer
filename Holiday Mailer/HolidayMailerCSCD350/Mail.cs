using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace HolidayMailerCSCD350
{
    class Mail
    {
        private string f, t, name;
        private MailAddress from, to;
        private MailMessage message;
        private SmtpClient client;

        public Mail(string from, string name)
        {
            this.t = "";
            this.from = new MailAddress(from,name);
            this.name = name;
            this.f = from;
            DetermineSMTP();
            
        }

        public void AddRecip(string recip)
        {
            t += recip;
        }

        private int DetermineSMTP()
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
                    return 1;
                return 0;
            }
            catch (Exception er)
            {
                return 1;
            }
        }

        public string Send(string pswrd)
        {
            //REMEMBER GMAIL USERS MUST ENABLE LESSSECUREAPPS https://www.google.com/settings/security/lesssecureapps
            try
            {
                if (t != "")
                {
                    to = new MailAddress(t);
                    message = new MailMessage(from, to);
                    message.Subject = "Mailer Test";
                    message.Body = "It's beautiful in here";

                    client.UseDefaultCredentials = false;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Credentials = new NetworkCredential(f, pswrd);
                    client.EnableSsl = true;
                    client.Send(message);
                    return null;
                }
                return "empty?";
            }
            catch (Exception er)
            {
                return er.ToString();
            }

        }
    }
}
