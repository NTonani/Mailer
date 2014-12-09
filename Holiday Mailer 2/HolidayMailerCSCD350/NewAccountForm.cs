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
    public partial class NewAccountForm : Form
    {

        bool fnselected = false;
        bool lnselected = false;

        public NewAccountForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            p1Label1.Text = "Dream Street accounts are currently stored only with the client that creates them, and will not be accessible on other Holiday Mailer clients.\n\nBlah";

            p2Label1.Text = "Enter an Account Name and Password.\nPassword must contain at least 7 characters ";
            p2pwBox1.PasswordChar = '●';
            p2pwBox2.PasswordChar = '●';


            p3Label1.Text = "Enter a default Email Address, more can be added later.";
            p3pwBox.PasswordChar = '●';

            p4Label.Text = "Your Account has been created successfully!\n";

        }

        private void p1agreeButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void p2backButton_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void p2nextButton_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Show();
        }

        private void p3backButton_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel3.Hide();
        }

        private void p3createButton_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel4.Show();
        }

        private void p4finishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fnBox_Enter(object sender, EventArgs e)
        {
            if (!fnselected)
            {
                fnBox.Clear();
                fnBox.ForeColor = Color.Black;
                fnselected = true;
            }

        }

        private void fnBox_Leave(object sender, EventArgs e)
        {
            if (fnBox.Text.Equals(""))
            {
                fnBox.Text = "First";
                fnBox.ForeColor = Color.DarkGray;
                fnselected = false;
            }
        }

        private void lnBox_Enter(object sender, EventArgs e)
        {
            if (!lnselected)
            {
                lnBox.Clear();
                lnBox.ForeColor = Color.Black;
                lnselected = true;
            }

        }

        private void lnBox_Leave(object sender, EventArgs e)
        {
            if (lnBox.Text.Equals(""))
            {
                lnBox.Text = "Last";
                lnBox.ForeColor = Color.DarkGray;
                lnselected = false;
            }
        }

        private void p2pwBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void p2pwBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private bool CheckPW(string input)
        {


            return true;
        }

        private bool PwMatch()
        {

            return false;
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

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }




    }
}
