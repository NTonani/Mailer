using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace HolidayMailerCSCD350
{
    class Data
    {

        public static Database db = new Database(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        public static List<Contact> cont;
        public static Mail mail;
        public static User user;
        public static string errorMessage;

        public static void OrderBy(string order)
        {
            if (order == "Fname")
            {
                cont = cont.OrderBy(x => x.fname).ToList();
            }
            else if (order == "Lname")
            {
                cont = cont.OrderBy(x => x.lname).ToList();
            }
            else if (order == "Email")
            {
                cont = cont.OrderBy(x => x.email).ToList();
            }
            else if (order == "DOB")
            {
                cont = cont.OrderBy(x => x.DOB).ToList();
            }
            else if (order == "Previous")
            {
                cont = cont.OrderBy(x => x.prev).ToList();
            }
            else if (order == "Relationship")
            {
                cont = cont.OrderBy(x => x.rel).ToList();
            }
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

        public static void Clear()
        {
            cont = null;
            mail = null;
            user = null;
        }

        public static bool CheckAlphanumeric(string input)
        {
            try
            {
                if (!Regex.IsMatch(input, "^[a-zA-Z0-9_]*$"))
                {
                    return false;
                }
                return true;
            }
            catch (Exception E)
            {
                return false;
            }
        }


        public static bool ValidateDate(string date)
        {
            try
            {
                if (date != "")
                {
                    string test = DateTime.Parse(date).ToString();
                    return true;
                }
                else
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool ValidateEmail(string address)
        {
            if (Regex.IsMatch(address, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;
        }

        public static bool ValidateUserEmail(string address)
        {
            if (Regex.IsMatch(address, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", RegexOptions.IgnoreCase))
            {
                UserMail temp = new UserMail(address);
                if(temp.success)
                    return true;
                else 
                    return false;
            }
            return false;
        }
    }
}
