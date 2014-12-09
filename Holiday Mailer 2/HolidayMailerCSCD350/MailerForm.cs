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

        bool searchselected = false;
        bool tochanged = true;

        List<string> attachedfiles = new List<string>();
        ImageList attachmentImageList = new ImageList();

        List<Contact> selected = new List<Contact>();
        List<string> accountemails = new List<string>();

        List<string> contactlist = new List<string>();
        string[] mailreqs = new string[4];
        List<string> tolist = new List<string>();

        public MailerForm()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            accountpwBox.PasswordChar = '●';

            progressBar.MarqueeAnimationSpeed = 1;

            Data.db = new Database(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            Data.cont = Data.db.ReadIn();

            ShowContacts(Data.cont);

            attachmentImageList.ImageSize = new Size(40, 40);
            attachView.LargeImageList = attachmentImageList;
            attachView.View = View.LargeIcon;

            attachView.AllowDrop = true;
            attachView.DragEnter += new DragEventHandler(attachView_DragEnter);
            attachView.DragDrop += new DragEventHandler(attachView_DragDrop);

            bodyTextBox.AllowDrop = true;
            bodyTextBox.DragDrop += new DragEventHandler(bodyTextBox_DragDrop);

            accountviewBox.DropDownStyle = ComboBoxStyle.DropDownList;

            contactView.Columns.Add("name", 100);
            contactView.Columns.Add("email", 300);

            accountemails.Add("drinzypooh@hotmail.com");
            accountemails.Add("lelandburlingame@gmail.com");
            accountemails.Add("lburlingame@haruham.com");




            for (int i = 0; i < accountemails.Count; i++)
            {
                accountviewBox.Items.Add(accountemails[i]);
            }

            accountviewBox.Text = accountemails[0];

            SetTheme(false);

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

            ListView.SelectedIndexCollection indexes = this.contactView.SelectedIndices;

            if (searchselected)
            {
                foreach (int index in indexes)
                {
                    selected.Add(Data.Search(searchBox.Text)[index]);
                }
            }
            else
            {
                foreach (int index in indexes)
                {
                    selected.Add(Data.cont[index]);
                }
            }

        }


        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchselected)
            {
                ShowContacts(Data.Search(searchBox.Text));
            }
        }



        private void MailerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Data.db.Close();
            Application.Exit();
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

                if (tochanged)
                {
                    tolist = toTextBox.Text.Split(',').ToList<string>();
                    tochanged = false;
                }
                mailreqs[0] = subjectTextBox.Text;
                mailreqs[1] = bodyTextBox.Text;
                mailreqs[2] = accountviewBox.Text;
                mailreqs[3] = accountpwBox.Text;

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

            Data.mail = new Mail(mailreqs[2], "Snigget McNigget", mailreqs[0], mailreqs[1], attachedfiles);

            for (int i = 0; i < tolist.Count; i++)
            {
                if (!Mail.ValidateEmail(tolist[i].Trim()))
                {
                    tolist.RemoveAt(i);
                    i--;
                }
            }

            Data.mail.AddRecip(tolist);

            bool success = Data.mail.Send(mailreqs[3], worker, e);

            if (!success)
            {
                MessageBox.Show("Error sending email");
            }
            else
            {
                mailreqs = new string[4];
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

        private void AddAttachment(string file)
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
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            attachView.BeginUpdate();

            foreach (String file in openFileDialog.FileNames)
            {
                AddAttachment(file);
                //pictureBox1.Image = Bitmap.FromHicon(new Icon(openFileDialog.FileName, new Size(48, 48)).Handle);
                //pb.Location = new Point(500, 500);
            }

            attachView.Visible = true;
            attachView.EndUpdate();
        }


        /*
        * DRAG DROP CODE
        */


        private void attachView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void attachView_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            attachView.BeginUpdate();

            foreach (string file in files)
            {
                AddAttachment(file);
            }

            attachView.Visible = true;
            attachView.EndUpdate();
        }

        void bodyTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            attachView.BeginUpdate();

            foreach (string file in files)
            {
                AddAttachment(file);
            }

            attachView.Visible = true;
            attachView.EndUpdate();
        }




        private void attachView_VisibleChanged(object sender, EventArgs e)
        {
            if (attachView.Visible)
            {
                bodyTextBox.Location = new Point(bodyTextBox.Location.X, bodyTextBox.Location.Y + attachView.Height);
                bodyTextBox.Size = new Size(bodyTextBox.Size.Width, bodyTextBox.Size.Height - attachView.Height);
            }
            else
            {
                bodyTextBox.Location = new Point(bodyTextBox.Location.X, bodyTextBox.Location.Y - attachView.Height);
                bodyTextBox.Size = new Size(bodyTextBox.Size.Width, bodyTextBox.Size.Height + attachView.Height);
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
            toContext.Items.Clear();

            if (tochanged)
            {
                tolist = toTextBox.Text.Split(',').ToList<string>();
                tochanged = false;
            }

            foreach (string address in tolist)
            {
                if (!address.Equals(""))
                {
                    toContext.Items.Add(address.Trim());
                }
            }
            
            toContext.Show(Cursor.Position);
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


        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (!searchselected)
            {
                searchselected = true;
                searchBox.Clear();
                searchBox.ForeColor = Color.Black;
            }

        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text.Equals(""))
            {
                searchselected = false;
                searchBox.Text = "Search";
                searchBox.ForeColor = Color.DarkGray;
            }
        }

        private void toTextBox_TextChanged(object sender, EventArgs e)
        {
            tochanged = true;
        }








    }
}
