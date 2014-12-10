using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayMailerCSCD350
{
    class User
    {
        public string username, fname, lname, DOB, pwd;
        public List<UserMail> accounts;

        public User(string username, string fname, string lname, string DOB, string pwd, List<UserMail> accounts)
        {
            this.username = username;
            this.fname = fname;
            this.lname = lname;
            this.DOB = DOB;
            this.pwd = pwd;
            this.accounts = accounts;
        }
        public override string ToString()
        {
            string ret = " ";
            foreach (UserMail element in accounts)
            {
                ret += element.ToString();
            }
            return ret;
        }
    }
}
