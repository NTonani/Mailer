using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HolidayMailerCSCD350
{
    public partial class LoginForm : Form
    {
        MailerForm mailer;
        NewAccountForm accountcreator;
        bool accboxselected = false;
        bool pwselected = false;

        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = label6;     
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool valid = ValidateLogin(accountTextBox.Text, pwTextBox.Text);
            if (valid)
            {
                mailer = new MailerForm();
                mailer.Show();
                this.Hide();
                if (accountcreator != null)
                {
                    accountcreator.Dispose();
                    accountcreator = null;
                }
            }
            else
            {
                MessageBox.Show("Invalid Account/Password");
            }
        }


        private void NewAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            accountcreator.Dispose();
            accountcreator = null;
        }

        private bool ValidateLogin(string account, string pw)
        {
            User temp = Data.db.ReadUser(account, pw);
            
            if (temp!=null)
            {
                Data.user = temp;
                return true;
            }
            return false;
             
        }

        private void newaccountButton_Click(object sender, EventArgs e)
        {
            if (accountcreator == null)
            {
                accountcreator = new NewAccountForm();
                accountcreator.FormClosing += new System.Windows.Forms.FormClosingEventHandler(NewAccountForm_FormClosing);
            }
            accountcreator.Show();
            accountcreator.Focus();
        }



        private void accountTextBox_Enter(object sender, EventArgs e)
        {
            if (!accboxselected)
            {
                accountTextBox.Clear();
                accountTextBox.ForeColor = Color.Black;
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
                pwTextBox.ForeColor = Color.Black;
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (mailer != null)
            {
                mailer.Dispose();
            }
            if (accountcreator != null)
            {
                accountcreator.Dispose();
            }
            this.Dispose();
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pwTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }


        /*
         * THIS CODE RESTORES THE DRAG TO MOVE THE FORM FUNCTION REMOVED WHEN THE FORM WAS SET TO BORDERLESS
         * 
         *
         */ 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }








    }
}
