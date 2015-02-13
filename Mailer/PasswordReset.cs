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
    public partial class PasswordReset : Form
    {
        string tempUser, temppw, tempemail;
        bool success = false;
        public PasswordReset()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            StepOne();
        }
        private void StepOne()
        {
            label2.Hide();
            comboBox1.Hide();
            sendbtn.Hide();
            textBox2.Hide();
        }

        private void StepTwo()
        {
            if (textBox1.Text!="")
            {
                tempUser = textBox1.Text;
                List<UserMail> list = Data.db.RetrieveEmails(tempUser);
                textBox1.Text = "";
                if (list == null)
                {
                    errormessagetb.Text = "Username does not exist";
                    StepOne();
                }
                else
                {
                    comboBox1.Items.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        comboBox1.Items.Add(list[i].email);
                    }
                    comboBox1.Text = list[0].email;
                    label2.Show();
                    comboBox1.Show();
                    sendbtn.Show();
                }
            }
            
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            StepTwo();
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox1.Text != null)
            {
               temppw = Data.db.TempPassword(tempUser, comboBox1.Text);
               if (temppw == null)
               {
                   textBox2.ForeColor = System.Drawing.SystemColors.Control;
                   textBox2.ForeColor = System.Drawing.Color.Red;
                   textBox2.Text = "Error sending email, try again";
                   textBox2.Show();
               }
               else
               {
                   tempemail = comboBox1.Text;
                   sendbtn.Enabled = false;
                   backgroundWorker1.RunWorkerAsync();
               }
            
            }

        }

        private void Sent()
        {
            textBox2.ForeColor = System.Drawing.SystemColors.Control;
            textBox2.ForeColor = System.Drawing.Color.Black;
            textBox2.Text = "Email has been sent";
            textBox2.Show();
        }
        private void NotSent()
        {
            textBox2.ForeColor = System.Drawing.SystemColors.Control;
            textBox2.ForeColor = System.Drawing.Color.Red;
            textBox2.Text = "Error sending email, try again";
            textBox2.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                UserMail dreamstreet = new UserMail("dreamstreetmailer@gmail.com", "ewucscd350");
                string body = "Your account password has been reset to the following:\n\n" + temppw + "\n\nYou may change your password from the 'Account' page once logged in.\n\n\n\n\nThank you,\n\nDream Street";
                Mail tempmail = new Mail(dreamstreet, "Dream Street Mailer", "password reset", body, new List<string> { });
                tempmail.AddRecip(new List<string> { tempemail });

                success = tempmail.Send(worker, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (success)
            {
                successlabel.Text = "An email containing a temporary password has been sent to your account at\n\n" + tempemail + "\n\nPlease change your password upon login.";
                panel2.Show();
            }
            sendbtn.Enabled = true;

        }

        private void finishbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
