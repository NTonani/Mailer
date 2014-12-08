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

        List<String> attachedfiles = new List<String>();
        ImageList attachmentImageList = new ImageList();

        List<Contact> selected = new List<Contact>();
        List<String> accountemails = new List<String>();
        string defaultemail;


        List<String> contactlist = new List<String>();
        string[] mailreqs = new string[5];

        public MailerForm()
        {
            InitializeComponent();

            accountpwBox.PasswordChar = '●';

            progressBar.MarqueeAnimationSpeed = 1;

            Data.db = new Database(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            Data.cont = Data.db.ReadIn();

            foreach (Contact c in Data.cont)
            {
                contactlist.Add(c.email);
            }

            string[] cs = contactlist.ToArray();
            var source = new AutoCompleteStringCollection();
            source.AddRange(cs);

            totextBox.AutoCompleteCustomSource = source;
            totextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            totextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            attachmentImageList.ImageSize = new Size(40, 40);
            attachView.LargeImageList = attachmentImageList;
            attachView.View = View.LargeIcon;




            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(MailerForm_DragEnter);
            this.DragDrop += new DragEventHandler(MailerForm_DragDrop);

            ShowContacts(Data.cont);

            bodytextBox.AllowDrop = true;
            bodytextBox.DragDrop += new DragEventHandler(bodytextBox_DragDrop);

            accountviewBox.DropDownStyle = ComboBoxStyle.DropDownList;

            contactView.Columns.Add("name", 100);
            contactView.Columns.Add("email", 150);

            accountemails.Add("drinzypooh@hotmail.com");
            accountemails.Add("lelandburlingame@gmail.com");
            accountemails.Add("lburlingame@haruham.com");




            for (int i = 0; i < accountemails.Count; i++)
            {
                accountviewBox.Items.Add(accountemails[i]);
            }

            accountviewBox.Text = accountemails[0];

            //SetTheme();

        }

        private void SetTheme()
        {
            sc.Panel1.BackColor = Color.FromArgb(64, 64, 64);
            sc.Panel2.BackColor = Color.FromArgb(64, 64, 64);
            contactView.BackColor = Color.FromArgb(64, 64, 64);
            contactPage.BackColor = Color.FromArgb(64, 64, 64);
            this.BackColor = Color.FromArgb(64, 64, 64);
            bodytextBox.BackColor = Color.FromArgb(64, 64, 64);

            sc.Panel1.ForeColor = Color.White;
            sc.Panel2.ForeColor = Color.White;
            contactView.ForeColor = Color.White;
            contactPage.ForeColor = Color.White;
            this.ForeColor = Color.White;
            bodytextBox.ForeColor = Color.White;


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
            /*
            if (contactView.SelectedItems.Count > 0)
            {*/
                selected.Clear();
                bodytextBox.Clear();

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

                    bodytextBox.Text += selected[i].fname + " " + selected[i].lname + "\n";
                }

            /*
            }
            else
            {
                selected.Clear();
                richTextBox1.Text = "";
            }
             */
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            bodytextBox.Clear();
            ShowContacts(Data.Search(searchBox.Text));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (totextBox.Text == null)
                {
                    return;
                }

                mailreqs[0] = totextBox.Text;
                mailreqs[1] = subjecttextBox.Text;
                mailreqs[2] = bodytextBox.Text;
                mailreqs[3] = accountviewBox.Text;
                mailreqs[4] = accountpwBox.Text;

                progressBar.Visible = true;
                sendButton.Enabled = false;
                backgroundWorker1.RunWorkerAsync();    
            }
            catch (Exception err)
            {

            }
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

        void bodytextBox_DragDrop(object sender, DragEventArgs e) {
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
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            Data.mail = new Mail(mailreqs[3], "Snigget McNigget", mailreqs[1], mailreqs[2], attachedfiles);
            Data.mail.AddRecip(mailreqs[0]);

            string check = Data.mail.Send(mailreqs[4], worker, e);
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
                bodytextBox.Location = new Point(bodytextBox.Location.X, bodytextBox.Location.Y + attachView.Height);
            }
            else
            {
                bodytextBox.Location = new Point(bodytextBox.Location.X, bodytextBox.Location.Y - attachView.Height);
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










    }
}
