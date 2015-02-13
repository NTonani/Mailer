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
        PasswordReset reset;

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
                if (!loginCheckbox.Checked)
                {
                    accountTextBox.Text = "Account";
                    accountTextBox.ForeColor = Color.DarkGray;
                    accboxselected = false;

                    pwTextBox.Text = "Password";
                    pwTextBox.ForeColor = Color.DarkGray;
                    pwTextBox.PasswordChar = '\0';
                    pwselected = false;
                }
                this.Hide();
                mailer = new MailerForm();
                mailer.FormClosing += new System.Windows.Forms.FormClosingEventHandler(MailForm_FormClosing);
                mailer.ShowDialog();
                if (accountcreator != null)
                {
                    accountcreator.Dispose();
                    accountcreator = null;
                }
            }
            else
            {
                DialogResult result = new MessageForm("Invalid Account/Password", false, new Point(this.Location.X+12, this.Location.Y + 100)).ShowDialog();
            }
        }


        private void MailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            bool logout = mailer.logout;
            mailer.Dispose();
            mailer = null;
            
            if (!logout)
            {
                Application.Exit();
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

        private void forgotButton_Click(object sender, EventArgs e)
        {
            reset = new PasswordReset();
            reset.ShowDialog();
        }

        private void accountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

    }
}
