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
using System.Runtime.InteropServices;


namespace HolidayMailerCSCD350
{
    public partial class MailerForm : Form
    {
        private AccountForm account;
        private UserMail use;

        private bool fnselected = false;
        private bool lnselected = false;
        private bool efnselected = false;
        private bool elnselected = false;
        private bool searchselected = false;
        private bool lsearchselected = false;
        private bool tochanged = true;
        private bool success = false;
        public bool logout = false;

        private int eindex = 0;
        private string oldemail = "";

        private List<string> attachedfiles = new List<string>();
        private ImageList attachmentImageList = new ImageList();

        private List<Contact> selected = new List<Contact>();
        private List<string> accountemails = new List<string>();

        private List<string> contactlist = new List<string>();
        private string[] mailreqs = new string[4];
        private List<string> tolist = new List<string>();

        public MailerForm()
        {
            InitializeComponent();

            LoadUp();

        }

        public void LoadUp()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            accountpwBox.PasswordChar = '●';

            progressBar.MarqueeAnimationSpeed = 1;
            Data.cont = Data.db.ReadIn();

            attachmentImageList.ImageSize = new Size(40, 40);
            attachView.LargeImageList = attachmentImageList;
            attachView.View = View.LargeIcon;

            attachView.AllowDrop = true;
            attachView.DragEnter += new DragEventHandler(attachView_DragEnter);
            attachView.DragDrop += new DragEventHandler(attachView_DragDrop);

            bodyTextBox.AllowDrop = true;
            bodyTextBox.DragDrop += new DragEventHandler(bodyTextBox_DragDrop);

            accountviewBox.DropDownStyle = ComboBoxStyle.DropDownList;

            contactView.Columns.Add("email", 200);
            contactView.Columns.Add("name", 140);

            sortBy.Items.Add("Sort by Email");
            sortBy.Items.Add("Sort by Last Name");
            sortBy.Items.Add("Sort by First Name");

            sortBy.Text = "Sort by Email";
            Data.OrderBy("Email");

            ShowContacts(Data.cont);


            ShowUserEmails();
        }
        private void ShowUserEmails()
        {
            accountviewBox.Items.Clear();
            for (int i = 0; i < Data.user.accounts.Count; i++)
            {
                accountviewBox.Items.Add(Data.user.accounts[i].email);
            }

            accountviewBox.Text = Data.user.accounts[0].email;
            accountpwBox.Text = Data.user.accounts[0].pwd;

        }


        private void ShowContacts(List<Contact> contacts)
        {
            contactView.Items.Clear();
            for (int i = 0; i < contacts.Count; i++)
            {
                String[] row = { contacts[i].email, contacts[i].fname + " " + contacts[i].lname};
                var listViewItem = new ListViewItem(row);


                contactView.Items.Add(listViewItem);
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
            if (searchBox.Text.Length > 0)
            {
                if (searchselected && !lsearchselected)
                {
                    ShowContacts(Data.Search(searchBox.Text));
                }
            }
        }



        private void MailerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Data.Clear();
            this.Close();
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
            editerrbox.Clear();
            editfname.Text = "First";
            editfname.ForeColor = Color.DarkGray;
            efnselected = false;
            editlname.Text = "Last";
            editlname.ForeColor = Color.DarkGray;
            elnselected = false;

            Contact toedit;
            List<Contact> temp;
            if (!searchselected)
            {
                temp = Data.cont;
            }
            else
            {
                temp = Data.Search(searchBox.Text);
            }

            eindex = this.contactView.SelectedIndices[0];

            toedit = temp[eindex];

            if (!toedit.fname.Equals(""))
            {
                editfname.Text = toedit.fname;
                editfname.ForeColor = Color.Black;
                efnselected = true;
            }
            if (!toedit.lname.Equals(""))
            {
                editlname.Text = toedit.lname;
                editlname.ForeColor = Color.Black;
                elnselected = true;
            }

            editemail.Text = toedit.email;
            oldemail = toedit.email;

            editrelation.Text = toedit.rel;
            if (toedit.prev == 1)
            {
                editprevmail.Checked = true;
            }

            editbday.Text = toedit.DOB;

            editPanel.Visible = true;
            searchln.Visible = false;

        }


        List<Contact> temporary = new List<Contact> { };

        private void removeContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            ListView.SelectedIndexCollection indexes = this.contactView.SelectedIndices;

            if (indexes.Count == 1)
            {
                result = new MessageForm("Are you sure you want to remove this contact?", true, new Point(Cursor.Position.X - 125, Cursor.Position.Y - 90)).ShowDialog();
            }
            else
            {
                result = new MessageForm("Are you sure you want to remove these contacts?", true, new Point(Cursor.Position.X - 125, Cursor.Position.Y - 90)).ShowDialog();

            }



            if (result == DialogResult.Yes)
            {

                List<Contact> temp = new List<Contact> { };
                if (!searchselected && !lsearchselected)
                {
                    temp = Data.cont;
                    int rem = 0;
                    foreach (int index in indexes)
                    {

                        for (int i = 0; i < Data.cont.Count(); i++)
                        {
                            if (temp[index - rem].email == Data.cont[i].email)
                            {
                                if (Data.db.RemoveContact(Data.cont[i]))
                                {
                                    Data.cont.RemoveAt(i);
                                    rem++;
                                    break;
                                }

                            }
                        }

                    }
                }
                else
                {
                    if (!lsearchselected)
                    {
                        temp = Data.Search(searchBox.Text);
                    }
                    else
                    {
                        temp = temporary;
                    }

                    foreach (int index in indexes)
                    {
                        for (int i = 0; i < Data.cont.Count(); i++)
                        {
                            if (temp[index].email == Data.cont[i].email)
                            {
                                if (Data.db.RemoveContact(Data.cont[i]))
                                {
                                    Data.cont.RemoveAt(i);
                                    break;
                                }

                            }
                        }

                    }


                }

                Checklnsearch();
                SortBy();
            }

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
                mailreqs[2] = accountpwBox.Text;


                Data.user.pwd = accountpwBox.Text;


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
                attachButton.Enabled = false;

                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception err)
            {

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            Data.mail = new Mail(use, Data.user.fname + " " + Data.user.lname, mailreqs[0], mailreqs[1], attachedfiles);

            for (int i = 0; i < tolist.Count; i++)
            {
                if (!Data.ValidateEmail(tolist[i].Trim()))
                {
                    tolist.RemoveAt(i);
                    i--;
                }
            }

            Data.mail.AddRecip(tolist);

            success = Data.mail.Send(mailreqs[2], worker, e);

            if (!success)
            {
                DialogResult result = new MessageForm("Error sending email\n\nCheck that your password is correct", false, new Point(this.Location.X + (this.Width/2) - 138, this.Location.Y + (this.Height/2) - 103)).ShowDialog();
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
            attachButton.Enabled = true;
            if (success)
            {
                bodyTextBox.Clear();
                toTextBox.Clear();
                subjectTextBox.Clear();
                attachView.Clear();
                attachedfiles.Clear();
                sendtoprevCheckBox.Checked = false;
                sendtoall.Checked = false;
                attachView.Visible = false;
            }
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

            if (ValidateExt(fin))
            {
                attachedfiles.Add(fin.FullName);

                if (!attachmentImageList.Images.ContainsKey(fin.Extension))
                {
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(fin.FullName);
                    attachmentImageList.Images.Add(fin.Extension, iconForFile);
                }
                item.ImageKey = fin.Extension;
                attachView.Items.Add(item);
                attachView.Visible = true;
            }
        }

        private bool ValidateExt(System.IO.FileInfo fin)
        {

            if (fin.Length > 26214400)
            {
                return false;
            }

            if (fin.Extension.EndsWith(".txt"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".zip"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".rar"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".doc"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".docx"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".jpg"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".jpeg"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".pdf"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".gif"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".png"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".bmp"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".cs"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".java"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".html"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".xls"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith("ppt"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".mov"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".mp3"))
            {
                return true;
            }
            else if (fin.Extension.EndsWith(".mp3"))
            {
                return true;
            }

            return false;
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
            }

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
                if (searchBox.Text.Length == 0)
                {
                    if (lsearchselected)
                    {
                        ShowContacts(temporary);
                    }
                    else
                    {
                        ShowContacts(Data.cont);
                    }
                }
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

       // SET UP ADD CONTACT WITH VALIDATION
        private void addcontactButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (Data.ValidateDate(addbdayBox.Text) && Data.ValidateEmail(addemailBox.Text))
                {
                    string lname = "";
                    string fname = "";

                    if (lnselected)
                    {
                        lname = addlnameBox.Text;
                    }

                    if (fnselected)
                    {
                        fname = addfnameBox.Text;
                    }

                    Contact a = new Contact(lname, fname, addemailBox.Text, Convert.ToInt32(prevmailedCheckBox.Checked), addrelationBox.Text, addbdayBox.Text);
                    
                    this.resultBox.BackColor = System.Drawing.Color.White;
                    this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    this.resultBox.ForeColor = System.Drawing.Color.Black;
                    if (Data.db.Insert(a))
                    {
                        Data.cont.Add(a);
                        if (lsearchselected)
                        {
                            Checklnsearch();
                            ShowContacts(temporary);
                        }
                        else if (searchselected)
                        {
                            ShowContacts(Data.Search(searchBox.Text));
                        }
                        else
                        {
                            ShowContacts(Data.cont);
                        }
                        ClearAdd();
                        resultBox.Text = "Successfully added contact";
                    }
                    else
                    {
                        this.resultBox.BackColor = System.Drawing.Color.White;
                        this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.resultBox.ForeColor = System.Drawing.Color.Red;
                        resultBox.Text = "Email already exists";

                    }
                }
                else
                {
                    this.resultBox.BackColor = System.Drawing.Color.White;
                    this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    this.resultBox.ForeColor = System.Drawing.Color.Red;
                    resultBox.Text = "One of more fields is incorrect";
                }


            }
            catch (Exception error)
            {
                this.resultBox.BackColor = System.Drawing.SystemColors.Control;
                this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.resultBox.ForeColor = System.Drawing.Color.Red;
                resultBox.Text = error.ToString();
            }
        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAdd();
        }

        private void ClearAdd()
        {
            resultBox.Clear();
            if (fnselected)
            {
                fnselected = false;
                addfnameBox.Text = "First";
                addfnameBox.ForeColor = Color.DarkGray;
            }
            if (lnselected)
            {
                lnselected = false;
                addlnameBox.Text = "Last";
                addlnameBox.ForeColor = Color.DarkGray;
            }
            addrelationBox.Clear();
            addemailBox.Clear();
            addbdayBox.Clear();
            prevmailedCheckBox.Checked = false;
        }

        private void accountviewBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (UserMail element in Data.user.accounts)
            {
                if (accountviewBox.Text == element.email)
                {
                    accountpwBox.Text = element.pwd;
                    break;
                }
            }
        }

        private void addfnameBox_Enter(object sender, EventArgs e)
        {
            if (!fnselected)
            {
                addfnameBox.Clear();
                addfnameBox.ForeColor = Color.Black;
                fnselected = true;
            }

        }

        private void addfnameBox_Leave(object sender, EventArgs e)
        {
            if (addfnameBox.Text.Equals(""))
            {
                addfnameBox.Text = "First";
                addfnameBox.ForeColor = Color.DarkGray;
                fnselected = false;
            }
        }

        private void addlnameBox_Enter(object sender, EventArgs e)
        {
            if (!lnselected)
            {
                addlnameBox.Clear();
                addlnameBox.ForeColor = Color.Black;
                lnselected = true;
            }

        }

        private void addlnameBox_Leave(object sender, EventArgs e)
        {
            if (addlnameBox.Text.Equals(""))
            {
                addlnameBox.Text = "Last";
                addlnameBox.ForeColor = Color.DarkGray;
                lnselected = false;
            }
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

        private void panelbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account = new AccountForm();
            account.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Account_FormClosing);
            account.ShowDialog();
        }

        private void Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowUserEmails();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = true;
            Data.Clear();
            this.Close();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Clear();
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Data.Clear();
            this.Close();
        }

        private void editCancel_Click(object sender, EventArgs e)
        {
            editPanel.Visible = false;
            searchln.Visible = true;
        }


        private void editfname_Enter(object sender, EventArgs e)
        {
            if (!efnselected)
            {
                editfname.Clear();
                editfname.ForeColor = Color.Black;
                efnselected = true;
            }

        }

        private void editfname_Leave(object sender, EventArgs e)
        {
            if (editfname.Text.Equals(""))
            {
                editfname.Text = "First";
                editfname.ForeColor = Color.DarkGray;
                efnselected = false;
            }
        }

        private void editlname_Enter(object sender, EventArgs e)
        {

            if (!elnselected)
            {
                editlname.Clear();
                editlname.ForeColor = Color.Black;
                elnselected = true;
            }


        }

        private void editlname_Leave(object sender, EventArgs e)
        {
            if (editlname.Text.Equals(""))
            {
                editlname.Text = "Last";
                editlname.ForeColor = Color.DarkGray;
                elnselected = false;
            }
        }


        private void saveedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Data.ValidateDate(editbday.Text) && Data.ValidateEmail(editemail.Text))
                {
                    string lname = "";
                    string fname = "";

                    if (elnselected)
                    {
                        lname = editlname.Text;
                    }

                    if (efnselected)
                    {
                        fname = editfname.Text;
                    }

                    Contact a = new Contact(lname, fname, editemail.Text, Convert.ToInt32(editprevmail.Checked), editrelation.Text, editbday.Text);
                    
                    this.editerrbox.BackColor = System.Drawing.Color.White;
                    this.editerrbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    this.editerrbox.ForeColor = System.Drawing.Color.Black;
                    if (Data.db.UpdateContact(a, oldemail))
                    {
                        if (searchselected)
                        {
                            Contact temp = Data.Search(searchBox.Text)[eindex];

                            for (int i = 0; i < Data.cont.Count(); i++)
                            {
                                if (temp.email == Data.cont[i].email)
                                {
                                    Data.cont[i] = a;
                                }
                            }
                            ShowContacts(Data.Search(searchBox.Text));
                        }
                        else
                        {
                            Data.cont[eindex] = a;
                            ShowContacts(Data.cont);
                        }

                        editerrbox.Text = "Successfully edited contact";
                    }
                    else
                    {
                        this.editerrbox.BackColor = System.Drawing.Color.White;
                        this.editerrbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                        this.editerrbox.ForeColor = System.Drawing.Color.Red;
                        editerrbox.Text = "Email already exists";
                    }
                }
                else
                {
                    this.editerrbox.BackColor = System.Drawing.Color.White;
                    this.editerrbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    this.editerrbox.ForeColor = System.Drawing.Color.Red;
                    editerrbox.Text = "One of more fields is incorrect";
                }


            }
            catch (Exception error)
            {
                this.editerrbox.BackColor = System.Drawing.SystemColors.Control;
                this.editerrbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.editerrbox.ForeColor = System.Drawing.Color.Red;
                editerrbox.Text = error.ToString();
            }
        
        }


        private void searchln_Enter(object sender, EventArgs e)
        {
            if (!lsearchselected)
            {
                lsearchselected = true;
                searchln.Clear();
                searchln.ForeColor = Color.Black;
            }

        }

        private void searchln_Leave(object sender, EventArgs e)
        {
            if (searchln.Text.Equals(""))
            {
                lsearchselected = false;
                searchln.Text = "Search by Last Name";
                searchln.ForeColor = Color.DarkGray;
                if (searchselected)
                {
                    ShowContacts(Data.Search(searchBox.Text));
                }
                else
                {
                    ShowContacts(Data.cont);
                }
            }
        }

        private void searchln_TextChanged(object sender, EventArgs e)
        {
            Checklnsearch();
        }


        private void Checklnsearch()
        {

            temporary = new List<Contact> { };
            foreach (Contact element in Data.cont)
            {
                if (element.lname.StartsWith(searchln.Text.ToUpper()))
                    temporary.Add(element);
                else if (element.lname.StartsWith(searchln.Text.ToLower()))
                    temporary.Add(element);
            }
            
            if (searchln.Text.Length > 0)
            {
                ShowContacts(temporary);
            }
            else if (searchselected)
            {
                ShowContacts(Data.Search(searchBox.Text));
            }
            else
            {
                ShowContacts(Data.cont);
            }
        }


        private void sendtoprevCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            toTextBox.Clear();

            if (sendtoprevCheckBox.Checked)
            {
                sendtoall.Checked = false;

                MailToTextFormat(toTextBox.Text.Length);

                int selectionIndex = toTextBox.Text.Length;
                int prevIndex = toTextBox.SelectionStart;

                string insertText = "";

                for (int i = 0; i < Data.cont.Count; i++)
                {
                    if (Data.cont[i].prev == 1)
                    {
                        insertText += Data.cont[i].email + ", ";
                    }
                }

                toTextBox.Text = toTextBox.Text.Insert(selectionIndex, insertText);
                toTextBox.SelectionStart = prevIndex;

                this.ActiveControl = toTextBox;
            }
        }

        private void sendtoall_CheckedChanged(object sender, EventArgs e)
        {
            toTextBox.Clear();

            if (sendtoall.Checked)
            {
                sendtoprevCheckBox.Checked = false;
                MailToTextFormat(toTextBox.Text.Length);

                int selectionIndex = toTextBox.Text.Length;
                int prevIndex = toTextBox.SelectionStart;

                string insertText = "";

                for (int i = 0; i < Data.cont.Count; i++)
                {
                    insertText += Data.cont[i].email + ", ";
                }

                toTextBox.Text = toTextBox.Text.Insert(selectionIndex, insertText);
                toTextBox.SelectionStart = prevIndex;

                this.ActiveControl = toTextBox;
            }

        }

        private void SortBy()
        {
            if (sortBy.Text.Equals("Sort by Last Name"))
            {
                Data.OrderBy("Lname");
            }
            else if (sortBy.Text.Equals("Sort by First Name"))
            {
                Data.OrderBy("Fname");
            }
            else if(sortBy.Text.Equals("Sort by Email"))
            {
                Data.OrderBy("Email");
            }

            if (lsearchselected)
            {
                Checklnsearch();
            }
            else if (searchselected)
            {
                ShowContacts(Data.Search(searchBox.Text));
            }
            else
            {
                ShowContacts(Data.cont);
            }
        }

        private void sortBy_SelectionChangeCommitted(object sender, EventArgs e)
        {

            SortBy();
        }


        private void searchln_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (searchln.Text.Length > 0)
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void sortBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






    }
}





/*
            ListViewGroup group1 = new ListViewGroup("Group 01");
            ListViewGroup group2 = new ListViewGroup("Group 02");
            contactView.Groups.AddRange(new ListViewGroup[] { group1, group2 });
            listViewItem.Group = group1;
 
 */
