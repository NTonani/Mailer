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
    public partial class MailerForm : Form
    {
        AccountForm account;

        List<string> attachedfiles = new List<string>();
        ImageList attachmentImageList = new ImageList();

        List<Contact> selected = new List<Contact>();
        List<string> accountemails = new List<string>();
        string defaultemail;


        List<string> contactlist = new List<string>();
        string[] mailreqs = new string[5];
        UserMail use;
        List<string> tolist = new List<string>();

        public MailerForm()
        {
            InitializeComponent();
            this.FormClosing += OnFormClosing;
            //SetTheme();
        }

        public void LoadUp()
        {
            

            accountpwBox.PasswordChar = '●';

            progressBar.MarqueeAnimationSpeed = 1;


            Data.cont = Data.db.ReadIn();

            foreach (Contact c in Data.cont)
            {
                contactlist.Add(c.email);
            }

            string[] cs = contactlist.ToArray();
            var source = new AutoCompleteStringCollection();
            source.AddRange(cs);

            toTextBox.AutoCompleteCustomSource = source;
            toTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            attachmentImageList.ImageSize = new Size(40, 40);
            attachView.LargeImageList = attachmentImageList;
            attachView.View = View.LargeIcon;




            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(MailerForm_DragEnter);
            this.DragDrop += new DragEventHandler(MailerForm_DragDrop);

            ShowContacts(Data.cont);

            bodyTextBox.AllowDrop = true;
            bodyTextBox.DragDrop += new DragEventHandler(bodyTextBox_DragDrop);

            accountviewBox.DropDownStyle = ComboBoxStyle.DropDownList;

            contactView.Columns.Add("name", 100);
            contactView.Columns.Add("email", 150);

            for (int i = 0; i < Data.user.accounts.Count; i++)
            {
                accountviewBox.Items.Add(Data.user.accounts[i].email);

            }

            accountviewBox.Text = Data.user.accounts[0].email;
        }

        private void SetAccount()
        {

        }

        
        private void SetTheme(bool dark)
        {
            if (dark)
            {
                sc.Panel1.BackColor = Color.FromArgb(64, 64, 64);
                sc.Panel2.BackColor = Color.FromArgb(64, 64, 64);
                contactView.BackColor = Color.FromArgb(64, 64, 64);
                contactPage.BackColor = Color.FromArgb(64, 64, 64);
                this.BackColor = Color.FromArgb(64, 64, 64);
                bodyTextBox.BackColor = Color.FromArgb(64, 64, 64);

                sc.Panel1.ForeColor = Color.White;
                sc.Panel2.ForeColor = Color.White;
                contactView.ForeColor = Color.White;
                contactPage.ForeColor = Color.White;
                this.ForeColor = Color.White;
                bodyTextBox.ForeColor = Color.White;
            }
            else
            {

            }
        }

        private void ShowContacts(List<Contact> contacts)
        {
            contactView.Items.Clear();
            ListViewGroup group1 = new ListViewGroup("Group 01");
            ListViewGroup group2 = new ListViewGroup("Group 02");
            contactView.Groups.AddRange(new ListViewGroup[] { group1, group2 });
            for (int i = 0; i < contacts.Count; i++)
            {
                String[] row = { contacts[i].fname + " " + contacts[i].lname, contacts[i].email };
                var listViewItem = new ListViewItem(row);
                listViewItem.Group = group1;

                contactView.Items.Add(listViewItem);
                //    outputtb.Text += i.ToString() + ": " + contacts[i].ToString() + " \n";
            }
        }


        private void contactView_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected.Clear();
            bodyTextBox.Clear();

            ListView.SelectedIndexCollection indexes = this.contactView.SelectedIndices;

            foreach (int index in indexes)
            {
                selected.Add(Data.Search(searchBox.Text)[index]);
            }

            /*
            label2.Text = contactView.SelectedItems[0].SubItems[0].Text.ToString();
            label3.Text = contactView.SelectedItems[0].SubItems[1].Text.ToString();
            */
            for (int i = 0; i < selected.Count; i++)
            {
                bodyTextBox.Text += selected[i].fname + " " + selected[i].lname + "\n";
            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountviewBox.Items.Clear();
            Data.Clear();
            this.Hide();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            bodyTextBox.Clear();
            ShowContacts(Data.Search(searchBox.Text));
        }



        private void MailerForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Data.db.Close();
        }



        /*
         * DRAG DROP CODE
         */
        private void MailerForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }


        private void MailerForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            MessageBox.Show("Hi");

        }

        void bodyTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            MessageBox.Show("Hi");
        }

        private void sc_Panel2_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("Hi");

        }



        /*
         * CONTACTS
         */

        private void addToMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailToTextFormat(toTextBox.Text.Length);

            int selectionIndex = toTextBox.Text.Length;
            int prevIndex = toTextBox.SelectionStart;

            string insertText = "";

            for (int i = 0; i < selected.Count; i++)
            {
                insertText += selected[i].email + ", ";
            }

            toTextBox.Text = toTextBox.Text.Insert(selectionIndex, insertText);
            toTextBox.SelectionStart = prevIndex;

            this.ActiveControl = toTextBox;
        }


        private void contactView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (contactView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    if (this.contactView.SelectedIndices.Count == 1)
                    {
                        editcontactToolStripMenuItem.Visible = true;
                        removeContactToolStripMenuItem.Text = "Remove Contact";
                    }
                    else
                    {
                        editcontactToolStripMenuItem.Visible = false;
                        removeContactToolStripMenuItem.Text = "Remove Contacts";
                    }
                    contactContext.Show(Cursor.Position);
                }
            }
        }

        private void editcontactToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to remove ?");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountviewBox.Items.Clear();
            Data.Clear();
            Application.Exit();
        }



        /*
         * SEND EMAIL BACKGROUND THREAD
         */
        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (toTextBox.Text == null || toTextBox.Text.Equals(""))
                {
                    return;
                }

                mailreqs[0] = toTextBox.Text;
                mailreqs[1] = subjectTextBox.Text;
                mailreqs[2] = bodyTextBox.Text;
                mailreqs[3] = accountviewBox.Text;
                mailreqs[4] = accountpwBox.Text;
                use = new UserMail();
                foreach (UserMail element in Data.user.accounts)
                {
                    if (accountviewBox.Text == element.email)
                    {
                        use = element;
                        break;

                    }
                }
               

                progressBar.Visible = true;
                sendButton.Enabled = false;

                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception err)
            {

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


            BackgroundWorker worker = sender as BackgroundWorker;
            
            Data.mail = new Mail(use, Data.user.lname + ", " +Data.user.fname, mailreqs[1], mailreqs[2],mailreqs[4], attachedfiles);

            Data.mail.AddRecip(mailreqs[0]);

            bool success = Data.mail.Send(worker, e);

            if (!success)
            {
                MessageBox.Show("Error sending email");
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Visible = false;
            sendButton.Enabled = true;
        }

        /*
         * ATTACHMENTS 
         */
        private void attachButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            attachView.BeginUpdate();

            foreach (String file in openFileDialog.FileNames)
            {
                ListViewItem item;

                Icon iconForFile = SystemIcons.WinLogo;

                System.IO.FileInfo fin = new System.IO.FileInfo(file);
                item = new ListViewItem(fin.Name, 1);
                iconForFile = Icon.ExtractAssociatedIcon(fin.FullName);
                attachedfiles.Add(fin.FullName);

                if (!attachmentImageList.Images.ContainsKey(fin.Extension))
                {
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(fin.FullName);
                    attachmentImageList.Images.Add(fin.Extension, iconForFile);
                }
                item.ImageKey = fin.Extension;
                attachView.Items.Add(item);
                //pictureBox1.Image = Bitmap.FromHicon(new Icon(openFileDialog.FileName, new Size(48, 48)).Handle);
                //pb.Location = new Point(500, 500);


            }

            attachView.Visible = true;
            attachView.EndUpdate();
        }

        private void attachView_VisibleChanged(object sender, EventArgs e)
        {
            if (attachView.Visible)
            {
                bodyTextBox.Location = new Point(bodyTextBox.Location.X, bodyTextBox.Location.Y + attachView.Height);
            }
            else
            {
                bodyTextBox.Location = new Point(bodyTextBox.Location.X, bodyTextBox.Location.Y - attachView.Height);
            }
        }

        private void attachView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (attachView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    attachContext.Show(Cursor.Position);
                }
            }
        }

        private void removeAttachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = this.attachView.SelectedIndices;
            int numremoved = 0;
            foreach (int index in indexes)
            {
                attachedfiles.RemoveAt(index - numremoved);
                numremoved++;
            }
            foreach (ListViewItem attachment in attachView.SelectedItems)
            {
                attachment.Remove();
            }
            if (attachView.Items.Count == 0)
            {
                attachView.Visible = false;
            }
        }


        //add bcc label that when clicked will open a new textbox for bcc input
        private void toLabel_Click(object sender, EventArgs e)
        {

        }

        //right click on toTextBox will open a context menu that shows all the current emails entered
        //will split the string, and use the list to populate the context menu, items can then be rclicked on and removed or selected

        //will do regex on the strings and see if an invalid email exists, and display that to the user or something
        private void toTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == ',')
            {
                MailToTextFormat(0);
                e.Handled = true;
            }
        }

        private void MailToTextFormat(int index)
        {
            int selectionIndex = toTextBox.SelectionStart;
            if (index != 0)
            {
                selectionIndex = index;
            }

            int prevIndex = selectionIndex - 1;
            if (prevIndex >= 0)
            {
                char prev = toTextBox.Text[prevIndex];
                if (prev != ' ' && prev != ',')
                {
                    string insertText = ", ";
                    toTextBox.Text = toTextBox.Text.Insert(selectionIndex, insertText);
                    toTextBox.SelectionStart = selectionIndex + insertText.Length;
                }
                else if (prev == ',' && !(selectionIndex == toTextBox.Text.Length))
                {
                    toTextBox.SelectionStart = selectionIndex + 1;
                }
                else if (prev == ',')
                {
                    string insertText = " ";
                    toTextBox.Text = toTextBox.Text.Insert(selectionIndex, insertText);
                    toTextBox.SelectionStart = selectionIndex + insertText.Length;
                }
            }

        }

        private void addcontactButton_Click(object sender, EventArgs e)
        {
            try
            {
                Contact a = new Contact(addfnameBox.Text, addlnameBox.Text, addemailBox.Text, Convert.ToInt32(prevmailedCheckBox.Checked), addrelationBox.Text, addDobBox.Text);
                Data.cont.Add(a);
                MessageBox.Show(Data.db.Insert(Data.cont[Data.cont.Count() - 1]));


            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void accountviewBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (UserMail element in Data.user.accounts)
            {
                if (accountviewBox.Text == element.email)
                {
                    accountpwBox.Text = element.pwd;
                    savepwcheckBox.Checked = true;
                    break;
                }
            }
        }

        //Check this checkbox on email send
        private void savepwcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (savepwcheckBox.Checked != true){
                foreach (UserMail element in Data.user.accounts)
                {
                    if (accountviewBox.Text == element.email)
                    {
                        if (element.pwd != null)
                            element.pwd = null;
                        break;

                    }
                }
            }else
            {
                foreach (UserMail element in Data.user.accounts)
                {
                    if (accountviewBox.Text == element.email)
                    {
                        if (element.pwd == null)
                            element.pwd = null;
                        break;

                    }
                }
            }
        }

        protected void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account = new AccountForm();
            account.ShowDialog();
        }





    }
}
