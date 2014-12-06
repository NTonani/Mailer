using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace HolidayMailerCSCD350
{
    class Data
    {
        public static Database db;
        public static List<Contact> cont;
        public static Mail mail;

        public static void OrderBy(string order)
        {
            if (order == "Fname")
                cont = cont.OrderBy(x => x.fname).ToList();
            else if (order == "Lname")
                cont = cont.OrderBy(x => x.lname).ToList();
            else if (order == "Email")
                cont = cont.OrderBy(x => x.email).ToList();
            else if (order == "DOB")
                cont = cont.OrderBy(x => x.DOB).ToList();
            else if (order == "Previous")
                cont = cont.OrderBy(x => x.prev).ToList();
            else if (order == "Relationship")
                cont = cont.OrderBy(x => x.rel).ToList();
        }

        public static List<Contact> Search(string content)
        {
            List<Contact> temp = new List<Contact> {};
            for (int i = 0; i < cont.Count; i++)
            {
                if (cont[i].Search(content))
                    temp.Add(cont[i]);
            }

            return temp;
        }
    }
}
