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
    class UserMail
    {
        public string email, pwd;
        public SmtpClient client;
        public bool success;

        public UserMail()
        {
        }

        public UserMail(string email, string pwd)
        {
            this.email = email;
            this.pwd = pwd;
            success = DetermineClient();
        }

        public UserMail(string email)
        {
            this.email = email;
            this.pwd = null;
            DetermineClient();
        }

        private bool DetermineClient()
        {
            try
            {
                //No office365, yahoo plus 
                if (email.Contains("@gmail"))
                    client = new SmtpClient("smtp.gmail.com", 587);
                else if (email.Contains("@outlook"))
                    client = new SmtpClient("smtp.live.com", 587);
                else if (email.Contains("@yahoo"))
                    client = new SmtpClient("smtp.mail.yahoo.com", 587);
                else if (email.Contains("@hotmail"))
                    client = new SmtpClient("smtp.live.com", 587);
                else if (email.Contains("@comcast"))
                    client = new SmtpClient("smtp.comcast.net", 587);
                else if (email.Contains("@verizon"))
                    client = new SmtpClient("outgoing.verizon.net", 587);
                else if (email.Contains("@mail"))
                    client = new SmtpClient("smtp.mail.com", 587);
                else
                {
                    success = false;
                    return false;
                }
                success = true;
                return true; ;
            }
            catch (Exception err)
            {
                success = false;
                return false;
            }
        }


        public override string ToString()
        {
            if (success)
                return email + " - PWD: " + pwd + " - CLIENT: " + client.Host.ToString() + "- " + client.Port.ToString() + " ";
            else
                return "Email not supported";
        }
    }
}
