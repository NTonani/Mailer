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
    public partial class AccountForm : Form
    {
        int j = -1;
        public AccountForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ActiveControl = emailaccntbox;
            ReadOnly(true);
            passwordbx.Hide();
            emailbox.Hide();
            addemailgb.Hide();
            Fill();
            FillEmails();

            
        }

        private void ReadOnly(bool t)
        {
            accountgb.Show();
            passwordbx.Hide();
            if (t)
            {
                emailaccntbox.Enabled = true;
                submitbtn.Hide();
                cancelbtn.Hide();
                fnametb.ReadOnly = true;
                lnametb.ReadOnly = true;
                unametb.ReadOnly = true;
                bdaytb.ReadOnly = true;

                fnametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                lnametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                unametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                bdaytb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else
            {
                emailaccntbox.Enabled = false;
                submitbtn.Show();
                cancelbtn.Show();
                fnametb.ReadOnly = false;
                lnametb.ReadOnly = false;
                bdaytb.ReadOnly = false;

                fnametb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lnametb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                bdaytb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Fill()
        {
            fnametb.Text = Data.user.fname;
            lnametb.Text = Data.user.lname;
            unametb.Text = Data.user.username;
            bdaytb.Text = Data.user.DOB;

        }

        private void FillEmails()
        {
            emaillb.Items.Clear();
            foreach (UserMail element in Data.user.accounts)
            {
                emaillb.Items.Add(element.email);
            }
        }
        private void Submit()
        {
            


            Data.user.fname = fnametb.Text;
            Data.user.lname = lnametb.Text;
            Data.user.DOB = bdaytb.Text;
            Data.user.pwd = newpwtb.Text;
            
            Data.db.UpdateUser(Data.user);
            
            ReadOnly(true);
            Fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadOnly(false);
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Fill();
            ReadOnly(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwordbx.Show();
            accountgb.Hide();
            emailaccntbox.Enabled = false;
            
        }

        private void submitpwbtn_Click(object sender, EventArgs e)
        {
            
            incurpwtb.Text = "";
            innewpwtb.Text = "";
            innewpw2tb.Text = "";
            if (newpwtb.Text == newpw2tb.Text && curpwtb.Text == Data.user.pwd)
                Submit();
            else
            {
                if (newpwtb.Text != newpw2tb.Text)
                {
                    innewpw2tb.Text = "Password does not match";
                }
                if(curpwtb.Text !=Data.user.pwd)
                {
                    incurpwtb.Text = "Incorrect password";
                }
            }
            curpwtb.Text = "";
            newpwtb.Text = "";
            newpw2tb.Text = "";
        }

        private void cancelpwbtn_Click(object sender, EventArgs e)
        {
            ReadOnly(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (emaillb.SelectedIndex != -1)
            {

                for (int i = 0; i < Data.user.accounts.Count(); i++)
                {
                    if (Data.user.accounts[i].email == emaillb.SelectedItem.ToString())
                    {
                        j = i;
                        em1tb.Text = emaillb.SelectedItem.ToString();
                        pw1tb.Text = Data.user.accounts[i].pwd;


                        accountgb.Enabled = false;
                        emailbox.Show();
                        addemailgb.Hide();
                        emailaccntbox.Hide();
                    }
                }
            }
        }

        private void cnclemailbtn_Click(object sender, EventArgs e)
        {
            emailbox.Hide();
            addemailgb.Hide();
            emailaccntbox.Show();
            accountgb.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            accountgb.Enabled = false;
            addemailgb.Show();
            emailbox.Hide();
            emailaccntbox.Hide();
        }

        private void submitemlbtn_Click(object sender, EventArgs e)
        {
            if (Data.ValidateUserEmail(em1tb.Text))
            {
                Data.user.accounts[j].email = em1tb.Text;
                Data.user.accounts[j].pwd = pw1tb.Text;
                if (!Data.db.UpdateUser(Data.user))
                    editemerrortb.Text = "Not able to update email";
                else
                {
                    
                    accountgb.Enabled = true;
                    FillEmails();
                    emailaccntbox.Show();
                    emailbox.Hide();
                    addemailgb.Hide();
                }
            }
            else
            {
                editemerrortb.Text = "Email not supported";
            }
        }

        private void addsubbtn_Click(object sender, EventArgs e)
        {
            if (Data.ValidateUserEmail(addemailtb.Text))
            {
                Data.user.accounts.Add(new UserMail(addemailtb.Text, addpwtb.Text));
                if (!Data.db.UpdateUser(Data.user))
                    addemerrortb.Text = Data.errorMessage;
                else
                {
                    accountgb.Enabled = true;
                    FillEmails();
                    emailaccntbox.Show();
                    emailbox.Hide();
                    addemailgb.Hide();
                }
            }
            else
            {
                addemerrortb.Text = "Email not supported";
            }
        }

        private void addcanbtn_Click(object sender, EventArgs e)
        {
            emailbox.Hide();
            addemailgb.Hide();
            emailaccntbox.Show();
            accountgb.Enabled = true;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


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
