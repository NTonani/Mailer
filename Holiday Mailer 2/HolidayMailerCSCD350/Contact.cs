using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace HolidayMailerCSCD350
{
    class Contact
    {
        public String lname, fname, email, rel, DOB;
        public int prev;
        public Contact(String lname, String fname, String email,int prev,String rel, String DOB)
        {
            this.lname = lname;
            this.fname = fname;
            this.email = email;
            this.prev = prev;
            this.rel = rel;
            this.DOB = DOB;
        }

        public bool Search(string cont)
        {
            if (this.lname != null && this.lname.Contains(cont))
                return true;
            else if (this.fname != null && this.fname.Contains(cont))
                return true;
            else if (this.email.Contains(cont))
                return true;
            else if (this.rel != null && this.rel.Contains(cont))
                return true;
            else if (this.DOB != null && this.DOB.Contains(cont))
                return true;
            else return false;
        }

        public override String ToString()
        {
            return this.fname + " " + this.lname + " " + this.email + " " + this.DOB + " \n\n";
        }
    }
}
