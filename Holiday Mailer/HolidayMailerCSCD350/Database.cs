using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

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
            str = "SELECT * FROM Contacts";
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

            return temp;
        }

        
        public string Insert(string l, string f, string em, string prev, string rel, string dob)
        {
            try
            {
                str = "INSERT INTO Contacts VALUES (@l,@f,@em,@prev,@rel,@dob)";
                command = new SQLiteCommand(str, connection);
                command.Parameters.AddWithValue("l", l);
                command.Parameters.AddWithValue("f", f);
                command.Parameters.AddWithValue("em", em);
                command.Parameters.AddWithValue("prev", prev);
                command.Parameters.AddWithValue("rel", rel);
                command.Parameters.AddWithValue("dob", dob);
                command.ExecuteNonQuery();
                return null;
            }
            catch (Exception er)
            {
                return er.ToString();
            }
        }
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
        public void close()
        {
            connection.Close();
        }

    }
}
