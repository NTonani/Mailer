using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayMailerCSCD350
{
    class Contact
    {
        private String lname, fname, email, rel, DOB;
        int prev;
        public Contact(String lname, String fname, String email,int prev,String rel, String DOB)
        {
            this.lname = lname;
            this.fname = fname;
            this.email = email;
            this.prev = prev;
            this.rel = rel;
            this.DOB = DOB;
        }
        
        public String ToString()
        {
            //Will have to figure out how to avoid NULL references in the unneeded db columns (IE relationship)
            return this.lname + ", " + this.fname + " " + this.email + "\n";
        }
    }
}
