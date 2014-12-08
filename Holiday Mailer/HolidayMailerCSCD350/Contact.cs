﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace HolidayMailerCSCD350
{
    class Contact
    {
        public string lname, fname, email, rel, DOB;
        public int prev;
        public Contact(string lname, string fname, string email,int prev,string rel, string DOB)
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
            if (this.lname.Contains(cont))
                return true;
            else if (this.fname.Contains(cont))
                return true;
            else if (this.email.Contains(cont))
                return true;
            else if (this.rel.Contains(cont))
                return true;
            else if (this.DOB.Contains(cont))
                return true;
            else return false;
        }

        public String ToString()
        {
            return this.fname + " " + this.lname + " " + this.email + " " + this.DOB + " \n\n";
        }
    }
}
