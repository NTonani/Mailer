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
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
            richTextBox1.Text = "Valve® Corporation and Valve S.A.R.L (collectively, “Valve”) respect the privacy of its online visitors and users of its products and services. Valve recognizes the importance of protecting information collected from users and has adopted this privacy policy to inform users about how Valve gathers, stores, and uses information derived from their use of Valve products, services and online sites. ";
        }

        private void p1agreeButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void p2nextButton_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Show();
        }

        private void p3nextButton_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }
    }
}
