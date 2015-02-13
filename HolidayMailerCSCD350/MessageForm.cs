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
    public partial class MessageForm : Form
    {
        public MessageForm(string message, bool yn, Point startloc)
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            if (yn)
            {
                this.ActiveControl = messageLabel;
            }
            else
            {
                this.ActiveControl = okButton;
            }

            this.Location = new Point(startloc.X, startloc.Y);

            if (yn)
            {
                okButton.Hide();
            }
            else
            {
                yesButton.Hide();
                noButton.Hide();
            }

            messageLabel.Text = message;

            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            yesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            noButton.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
