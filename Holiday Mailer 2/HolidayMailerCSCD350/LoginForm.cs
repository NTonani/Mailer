using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolidayMailerCSCD350
{
    public partial class LoginForm : Form
    {
        MailerForm mailer = new MailerForm();
        NewAccountForm accountcreator = new NewAccountForm();
        bool accboxselected = false;
        bool pwselected = false;

        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = label6;     
            mailer.FormClosing += new System.Windows.Forms.FormClosingEventHandler(MailerForm_FormClosing);
            accountcreator.FormClosing += new System.Windows.Forms.FormClosingEventHandler(NewAccountForm_FormClosing);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool valid = ValidateLogin(accountTextBox.Text, pwTextBox.Text);
            if (valid)
            {
                mailer.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Account/Password");
            }
        }


        private void MailerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            mailer.Hide(); 
            this.Show();
        }

        private void NewAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            accountcreator.Hide(); 
            this.Show();
        }

        private bool ValidateLogin(string account, string pw)
        {
            if (account.ToLower().Equals("ramensnat") && pw.Equals("Iamanidiot"))
            {
                return true;
            }
            return true;
        }

        private void newaccountButton_Click(object sender, EventArgs e)
        {
            accountcreator.Show();
            this.Hide();
        }



        private void accountTextBox_Enter(object sender, EventArgs e)
        {
            if (!accboxselected)
            {
                accountTextBox.Clear();
                accountTextBox.ForeColor = Color.White;
                accboxselected = true;
            }

        }

        private void accountTextBox_Leave(object sender, EventArgs e)
        {
            if (accountTextBox.Text.Equals(""))
            {
                accountTextBox.Text = "Account";
                accountTextBox.ForeColor = Color.DarkGray;
                accboxselected = false;
            }
        }

        private void pwTextBox_Enter(object sender, EventArgs e)
        {
            if (!pwselected)
            {
                pwTextBox.Clear();
                pwTextBox.ForeColor = Color.White;
                pwTextBox.PasswordChar = '●';
                pwselected = true;
            }

        }
        private void pwTextBox_Leave(object sender, EventArgs e)
        {
            if (pwTextBox.Text.Equals(""))
            {
                pwTextBox.Text = "Password";
                pwTextBox.ForeColor = Color.DarkGray;
                pwTextBox.PasswordChar = '\0';
                pwselected = false;
            }
        }



    }
}
