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


namespace HolidayMailerCSCD350
{
    public partial class Form1 : Form
    {

        private SQLiteConnection connection;
        private SQLiteCommand command;
        private SQLiteDataReader dr; 
        private String str;
        private Database db;

        private List<Contact> cont;

      //  Database db;
        public Form1()
        {
            InitializeComponent();
            //connection = new SQLiteConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            db = new Database(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cont = db.ReadIn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                for(int i = 0 ;i<cont.Count();i++)
                {
                    outputtb.Text = outputtb.Text + "NEXT: "+ cont[i].ToString();
                }
                 */
               // INSERT


                dobtb.Text = db.Insert(lnametb.Text, fnametb.Text, emailtb.Text, Convert.ToInt32(prevcb.Checked).ToString(), reltb.Text, dobtb.Text);
                
            }
            catch (Exception error)
            {
                
                dobtb.Text = error.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Close(object sender, EventArgs e)
        {
            connection.Close();
        }
    }
}
