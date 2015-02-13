using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;
using System.Net.Mail;


namespace HolidayMailerCSCD350
{
    public partial class Form1 : Form
    {

        

      //  Database db;
        public Form1()
        {
            InitializeComponent();
            //connection = new SQLiteConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            //Data.db = new Database(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            //Data.cont = Data.db.ReadIn();
            //Data.mail = new Mail("dreamstreetmailer@yahoo.com", "Fk u");
        }

        private void ShowContacts(List<Contact> contacts)
        {
            outputtb.Text = "";
            for (int i = 0; i < contacts.Count; i++)
            {
                outputtb.Text += i.ToString() + ": " + contacts[i].ToString() + " \n";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               // dobtb.Text = Data.db.Insert(lnametb.Text, fnametb.Text, emailtb.Text, Convert.ToInt32(prevcb.Checked).ToString(), reltb.Text, dobtb.Text);
                //Data.cont.Add(new Contact(lnametb.Text, fnametb.Text, emailtb.Text, Convert.ToInt32(prevcb.Checked), reltb.Text, dobtb.Text));

            }
            catch (Exception error)
            { 
                dobtb.Text = error.ToString();
            }
        }

        private void Form1_Close(object sender, EventArgs e)
        {
            Data.db.Close();
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            ShowContacts(Data.cont);
        }

        private void sortRelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Data.OrderBy("Email");
            }
            catch (Exception err)
            {
                outputtb.Text = err.ToString();
            }
        }

        private void mailbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Data.mail.AddRecip(fnametb.Text);
               // string check = Data.mail.Send("ewucscd350");
               // outputtb.Text = check;
            }
            catch (Exception err)
            {
                outputtb.Text = err.ToString();
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
                ShowContacts(Data.Search(searchtb.Text));
        }
    }
}
