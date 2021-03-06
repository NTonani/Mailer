﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Net.Mail;

namespace HolidayMailerCSCD350
{
    class Database
    {
        private String connectionString;
        private SQLiteConnection connection;
        private SQLiteCommand command;
        private SQLiteDataReader dr;
        private String str;

        public Database(String connectionString)
        {
            this.connectionString = connectionString;
            this.connection = new SQLiteConnection(this.connectionString);
            this.str = "";
        }
        public List<Contact> ReadIn()
        {

            connection.Open();
            str = "SELECT * FROM Contacts where User=@u";

            List<Contact> temp = new List<Contact> { };
            command = new SQLiteCommand(str, connection);
            command.Parameters.AddWithValue("u", Data.user.username);
            dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    String lname = dr["Lname"].ToString();
                    String fname = dr["Fname"].ToString();
                    String email = dr["Email"].ToString();
                    int prev;
                    if (dr["Previous"] != DBNull.Value)
                        prev = Convert.ToInt32(dr["Previous"]);
                    else
                        prev = 0;
                    String rel;
                    if (dr["Relationship"] != DBNull.Value)
                        rel = dr["Relationship"].ToString();
                    else
                        rel = null;
                    String DOB;
                    if (dr["DOB"] != DBNull.Value)
                        DOB = dr["DOB"].ToString();
                    else
                        DOB = null;
                    temp.Add(new Contact(lname, fname, email, prev, rel, DOB));
                }
            }
            Reset();
            return temp;
        }


        public void Reset()
        {
            command.Cancel();
            if (dr!=null && !dr.IsClosed)
            {
                dr.Close();
            }

            connection.Close();
            GC.Collect();
        }

        public bool UpdateContact(Contact cont, string oldem)
        {
            try
            {
                connection.Open();     
                str = "UPDATE Contacts SET Lname=@l, Fname=@f, Email=@em, Previous=@prev, Relationship=@rel, DOB=@d WHERE User=@u AND Email=@oe";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("l", cont.lname);
                command.Parameters.AddWithValue("f", cont.fname);
                command.Parameters.AddWithValue("em", cont.email);
                command.Parameters.AddWithValue("prev", cont.prev);
                command.Parameters.AddWithValue("rel", cont.rel);
                command.Parameters.AddWithValue("d", cont.DOB);
                command.Parameters.AddWithValue("u", Data.user.username);
                command.Parameters.AddWithValue("oe", oldem);
                command.ExecuteNonQuery();

                Reset();
                return true;

            }
            catch (Exception er)
            {
                Data.errorMessage = er.ToString();
                Reset();
                return false;
            }
        }

        public bool Insert(Contact cont)
        {
            try
            {
                connection.Open();
                str = "INSERT INTO Contacts VALUES (@l,@f,@em,@prev,@rel,@dob,@user)";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("l", cont.lname);
                command.Parameters.AddWithValue("f", cont.fname);
                command.Parameters.AddWithValue("em", cont.email);
                command.Parameters.AddWithValue("prev", cont.prev);
                command.Parameters.AddWithValue("rel", cont.rel);
                command.Parameters.AddWithValue("dob", cont.DOB);
                command.Parameters.AddWithValue("user", Data.user.username);
                command.ExecuteNonQuery();
                Reset();
                return true; ;
            }
            catch (Exception er)
            {
                Reset();
                return false;
            }
        }

        //Adding new user from account creation
        public bool AddUser(User user)
        {
            try
            {
                connection.Open();
                str = "Insert into User VALUES (@u,@l,@f,@dob,@pwd)";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("u", user.username);
                command.Parameters.AddWithValue("l", user.lname);
                command.Parameters.AddWithValue("f", user.fname);
                command.Parameters.AddWithValue("dob", user.DOB);
                command.Parameters.AddWithValue("pwd", user.pwd);
                command.ExecuteNonQuery();
                foreach (UserMail element in user.accounts)
                {
                    str = "INSERT into UserEmail VALUES (@u,@e,@p)";
                    command = new SQLiteCommand(str, connection);
                    command.Parameters.AddWithValue("u", user.username);
                    command.Parameters.AddWithValue("e", element.email);
                    command.Parameters.AddWithValue("p", element.pwd);
                    command.ExecuteNonQuery();
                }
                Reset();
                return true;


            }
            catch (Exception er)
            {
                Reset();
                return false;
            }
        }



        public User ReadUser(string username, string password)
        {

            try
            {
                User tempuser;
                List<UserMail> tempmail = new List<UserMail> { };
                connection.Open();
                str = "Select * from User where upper(Username) = @u AND Password = @p";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("u", username.ToUpper());
                command.Parameters.AddWithValue("p", password);
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        string lname = dr["Lname"].ToString();
                        string fname = dr["Fname"].ToString();
                        string dob = dr["DOB"].ToString();
                        string pw = dr["Password"].ToString();
                        str = "Select * from UserEmail where upper(Username) = @u";
                        command = new SQLiteCommand(str, connection);
                        command.Parameters.AddWithValue("u", username.ToUpper());
                        dr = command.ExecuteReader();
                        if (dr.HasRows)
                        {

                            while (dr.Read())
                            {
                                tempmail.Add(new UserMail(dr["Email"].ToString(), dr["Password"].ToString()));
                            }

                            dr.Close();
                            tempuser = new User(username, fname, lname, dob, pw, tempmail);
                            Reset();

                            return tempuser;

                        }
                        else
                        {
                            Reset();
                            return null;
                        }
                    }

                }
                else
                {
                    Reset();
                    return null;
                }
            }
            catch (Exception er)
            {
                Reset();
                return null;
            }

            Reset();
            return null;
        }

        public bool UpdateUser(User user)
        {
            try
            {
                connection.Open();
                str = "UPDATE User SET Lname = @l, Fname = @f, DOB = @d, Password = @p WHERE Username=@u";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("l", user.lname);
                command.Parameters.AddWithValue("f", user.fname);
                command.Parameters.AddWithValue("d", user.DOB);
                command.Parameters.AddWithValue("p", user.pwd);
                command.Parameters.AddWithValue("u", user.username);
                command.ExecuteNonQuery();

                Reset();
                return true;

            }
            catch (Exception er)
            {
                Data.errorMessage = er.ToString();
                Reset();
                return false;
            }
        }


        public void UpdateUserEmail(User user)
        {

            foreach (UserMail element in user.accounts)
            {
                RunUserMail(element);

            }
        }

        public bool RunUserMail(UserMail usermail)
        {
            try
            {
                connection.Open();
                str = "INSERT into UserEmail VALUES (@u,@e,@p)";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("u", Data.user.username);
                command.Parameters.AddWithValue("e", usermail.email);
                command.Parameters.AddWithValue("p", usermail.pwd);
                command.ExecuteNonQuery();
                Reset();
                return true;
            }
            catch (Exception e)
            {
                Data.errorMessage = e.ToString();
                return false;
            }
        }

        public bool UpdateMailPassword(UserMail usermail)
        {
            try
            {
                connection.Open();
                str = "UPDATE UserEmail SET Password=@p WHERE Username=@u AND Email=@e";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("p", usermail.pwd);
                command.Parameters.AddWithValue("u", Data.user.username);
                command.Parameters.AddWithValue("e", usermail.email);
                command.ExecuteNonQuery();
                Reset();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool RemoveContact(Contact contact)
        {
            try
            {
                connection.Open();
                str = "DELETE from Contacts where Email=@e AND User=@u";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("e", contact.email);
                command.Parameters.AddWithValue("u", Data.user.username);
                command.ExecuteNonQuery();
                Reset();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool RemoveUserEmail(UserMail usermail)
        {
            try
            {
                connection.Open();
                str = "DELETE from UserEmail where Username=@u AND Email=@e";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("e", usermail.email);
                command.Parameters.AddWithValue("u", Data.user.username);
                command.ExecuteNonQuery();
                Reset();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void Close()
        {
            connection.Close();
        }

        public bool CheckUsername(string username)
        {
            try
            {
                connection.Open();
                str = "SELECT COUNT(Username) from User WHERE upper(Username)=@u";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("u", username.ToUpper());
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    Reset();
                    return false;
                }
                else
                {
                    Reset();
                    return true;
                }

            }
            catch (Exception e)
            {
                Reset();
                return false;
            }
        }

        public List<UserMail> RetrieveEmails(string user)
        {
            List<UserMail> list = new List<UserMail> { };
            try
            {
                connection.Open();
                str = "SELECT Email from UserEmail where Username=@u";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("u", user);
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(new UserMail(dr["Email"].ToString()));
                    }
                    Reset();
                    return list;
                }
                else
                {
                    Reset();
                    return null;
                }
            }
            catch (Exception e)
            {
                Reset();
                return null;
            }
        }
        public bool ReadWrite()
        {
            try
            {
                connection.Open();
                str = "ALTER DATABASE Data SET READ_WRITE WITH NO_WAIT";
                command = new SQLiteCommand(str, connection);
                command.ExecuteNonQuery();
                Reset();
                return true;
            }
            catch (Exception e)
            {
                Reset();
                    return false;

            }
        }
        public string TempPassword(string user, string email)
        {


            try
            {
                connection.Open();
                string temp = GeneratePassword();
                str = "UPDATE User SET Password = @p WHERE Username=@u";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("p", temp);
                command.Parameters.AddWithValue("u", user);
                command.ExecuteNonQuery();
                Reset();
                return temp;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private string GeneratePassword()
        {
            string strPwdchar = "abcdefghijklmnopqrstuvwxyz0123456789#+@&$ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string strPwd = "";
            Random rnd = new Random();
            for (int i = 0; i <= 7; i++)
            {
                int iRandom = rnd.Next(0, strPwdchar.Length - 1);
                strPwd += strPwdchar.Substring(iRandom, 1);
            }
            return strPwd;
        }

    }
}
