using System;
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

            connection.Open();

        }

        public List<Contact> ReadIn()
        {
            str = "SELECT * FROM Contacts where User=@u";

            List<Contact> temp = new List<Contact> { };
            command = new SQLiteCommand(str, connection);
            command.Parameters.AddWithValue("u", Data.user.username);
            dr = command.ExecuteReader();
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
            connection.Close();
            return temp;
        }

        //Inserting contact 
        public string Insert(Contact cont)
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
                connection.Close();
                return null;
            }
            catch (Exception er)
            {
                return er.ToString();
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
                command.Parameters.AddWithValue("u",user.username);
                command.Parameters.AddWithValue("l",user.lname);
                command.Parameters.AddWithValue("f",user.fname);
                command.Parameters.AddWithValue("dob",user.DOB);
                command.Parameters.AddWithValue("pwd",user.pwd);
                command.ExecuteNonQuery();
                foreach (UserMail element in user.accounts){
                    str = "INSERT into UserEmail VALUES (@u,@e,@p)";
                    command = new SQLiteCommand(str,connection);
                    command.Parameters.AddWithValue("u",user.username);
                    command.Parameters.AddWithValue("e",element.email);
                    command.Parameters.AddWithValue("p",element.pwd);
                    command.ExecuteNonQuery();
                }

                return true;


            }
            catch (Exception er)
            {
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
                            
                            tempuser = new User(username, fname, lname, dob, pw, tempmail);
                            connection.Close();
                            return tempuser;

                        }
                        else
                        {
                            connection.Close();
                            
                            return null;
                        }
                    }
                    
                }
                else
                {
                    connection.Close();
                    
                    return null;
                }
            }
            catch (Exception er)
            {
                return null;
            }
            
            return null; ;
        }
         

        /*
        public List<Contact> ReadIn(string order)
        {

                connection.Open();
                str = "SELECT * FROM Contacts ORDER BY " + order + " asc";
                List<Contact> temp = new List<Contact> { };
                command = new SQLiteCommand(str, connection);
                dr = command.ExecuteReader();
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
                connection.Close();
                return temp;
            

        }
        */
        
        /*
        public void select(string from, string values)
        {
            str = "SELECT " + from + " FROM @values";
            command = new SQLiteCommand(str, connection);
            command.Parameters.AddWithValue("@values", values);
        }

        public void select(string from, string values, string where)
        {
            str = "SELECT " + from + " FROM @values WHERE @where";
            command = new SQLiteCommand(str, connection);
            command.Parameters.AddWithValue("@values", values);
        }
        */
        public void Close()
        {
            connection.Close();
        }

    }
}
