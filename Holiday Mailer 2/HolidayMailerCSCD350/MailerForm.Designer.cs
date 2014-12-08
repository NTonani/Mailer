namespace HolidayMailerCSCD350
{
    partial class MailerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailerForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mailerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.contactControl = new System.Windows.Forms.TabControl();
            this.contactPage = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contactView = new System.Windows.Forms.ListView();
            this.addTab = new System.Windows.Forms.TabPage();
            this.clearButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addcontactButton = new System.Windows.Forms.Button();
            this.prevmailedCheckBox = new System.Windows.Forms.CheckBox();
            this.addrelationBox = new System.Windows.Forms.TextBox();
            this.addemailBox = new System.Windows.Forms.TextBox();
            this.addlnameBox = new System.Windows.Forms.TextBox();
            this.addfnameBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.sendtoprevCheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.attachView = new System.Windows.Forms.ListView();
            this.attachButton = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.bodyTextBox = new System.Windows.Forms.RichTextBox();
            this.accountviewBox = new System.Windows.Forms.ComboBox();
            this.contactContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editcontactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.attachContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountpwBox = new System.Windows.Forms.TextBox();
            this.savepwcheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.contactControl.SuspendLayout();
            this.contactPage.SuspendLayout();
            this.addTab.SuspendLayout();
            this.contactContext.SuspendLayout();
            this.attachContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailerToolStripMenuItem,
            this.contactsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1327, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mailerToolStripMenuItem
            // 
            this.mailerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.mailerToolStripMenuItem.Name = "mailerToolStripMenuItem";
            this.mailerToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mailerToolStripMenuItem.Text = "Mailer";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sc.Location = new System.Drawing.Point(0, 24);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.sc.Panel1.Controls.Add(this.contactControl);
            this.sc.Panel1.Controls.Add(this.searchBox);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.AllowDrop = true;
            this.sc.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.sc.Panel2.Controls.Add(this.sendtoprevCheckBox);
            this.sc.Panel2.Controls.Add(this.progressBar);
            this.sc.Panel2.Controls.Add(this.attachView);
            this.sc.Panel2.Controls.Add(this.attachButton);
            this.sc.Panel2.Controls.Add(this.subjectTextBox);
            this.sc.Panel2.Controls.Add(this.toTextBox);
            this.sc.Panel2.Controls.Add(this.subjectLabel);
            this.sc.Panel2.Controls.Add(this.toLabel);
            this.sc.Panel2.Controls.Add(this.sendButton);
            this.sc.Panel2.Controls.Add(this.bodyTextBox);
            this.sc.Panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.sc_Panel2_DragDrop);
            this.sc.Size = new System.Drawing.Size(1327, 543);
            this.sc.SplitterDistance = 264;
            this.sc.TabIndex = 1;
            // 
            // contactControl
            // 
            this.contactControl.Controls.Add(this.contactPage);
            this.contactControl.Controls.Add(this.addTab);
            this.contactControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactControl.ItemSize = new System.Drawing.Size(127, 30);
            this.contactControl.Location = new System.Drawing.Point(3, 63);
            this.contactControl.Name = "contactControl";
            this.contactControl.SelectedIndex = 0;
            this.contactControl.Size = new System.Drawing.Size(258, 584);
            this.contactControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.contactControl.TabIndex = 0;
            this.contactControl.TabStop = false;
            // 
            // contactPage
            // 
            this.contactPage.Controls.Add(this.comboBox1);
            this.contactPage.Controls.Add(this.contactView);
            this.contactPage.Location = new System.Drawing.Point(4, 34);
            this.contactPage.Name = "contactPage";
            this.contactPage.Padding = new System.Windows.Forms.Padding(3);
            this.contactPage.Size = new System.Drawing.Size(250, 546);
            this.contactPage.TabIndex = 0;
            this.contactPage.Text = "Contacts";
            this.contactPage.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // contactView
            // 
            this.contactView.FullRowSelect = true;
            this.contactView.HideSelection = false;
            this.contactView.Location = new System.Drawing.Point(0, 23);
            this.contactView.Name = "contactView";
            this.contactView.ShowItemToolTips = true;
            this.contactView.Size = new System.Drawing.Size(250, 537);
            this.contactView.TabIndex = 0;
            this.contactView.TabStop = false;
            this.contactView.UseCompatibleStateImageBehavior = false;
            this.contactView.View = System.Windows.Forms.View.Details;
            this.contactView.SelectedIndexChanged += new System.EventHandler(this.contactView_SelectedIndexChanged);
            this.contactView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contactView_MouseClick);
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.clearButton);
            this.addTab.Controls.Add(this.label4);
            this.addTab.Controls.Add(this.label3);
            this.addTab.Controls.Add(this.label2);
            this.addTab.Controls.Add(this.label1);
            this.addTab.Controls.Add(this.addcontactButton);
            this.addTab.Controls.Add(this.prevmailedCheckBox);
            this.addTab.Controls.Add(this.addrelationBox);
            this.addTab.Controls.Add(this.addemailBox);
            this.addTab.Controls.Add(this.addlnameBox);
            this.addTab.Controls.Add(this.addfnameBox);
            this.addTab.Location = new System.Drawing.Point(4, 34);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(250, 546);
            this.addTab.TabIndex = 1;
            this.addTab.Text = "Add Contact";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(6, 415);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(238, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // addcontactButton
            // 
            this.addcontactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcontactButton.Location = new System.Drawing.Point(6, 268);
            this.addcontactButton.Name = "addcontactButton";
            this.addcontactButton.Size = new System.Drawing.Size(239, 23);
            this.addcontactButton.TabIndex = 5;
            this.addcontactButton.Text = "ADD CONTACT";
            this.addcontactButton.UseVisualStyleBackColor = true;
            // 
            // prevmailedCheckBox
            // 
            this.prevmailedCheckBox.AutoSize = true;
            this.prevmailedCheckBox.Location = new System.Drawing.Point(6, 245);
            this.prevmailedCheckBox.Name = "prevmailedCheckBox";
            this.prevmailedCheckBox.Size = new System.Drawing.Size(210, 19);
            this.prevmailedCheckBox.TabIndex = 4;
            this.prevmailedCheckBox.Text = "Contact has mailed you previously";
            this.prevmailedCheckBox.UseVisualStyleBackColor = true;
            // 
            // addrelationBox
            // 
            this.addrelationBox.Location = new System.Drawing.Point(6, 219);
            this.addrelationBox.Name = "addrelationBox";
            this.addrelationBox.Size = new System.Drawing.Size(238, 21);
            this.addrelationBox.TabIndex = 3;
            // 
            // addemailBox
            // 
            this.addemailBox.Location = new System.Drawing.Point(6, 180);
            this.addemailBox.Name = "addemailBox";
            this.addemailBox.Size = new System.Drawing.Size(238, 21);
            this.addemailBox.TabIndex = 2;
            // 
            // addlnameBox
            // 
            this.addlnameBox.Location = new System.Drawing.Point(6, 127);
            this.addlnameBox.Name = "addlnameBox";
            this.addlnameBox.Size = new System.Drawing.Size(238, 21);
            this.addlnameBox.TabIndex = 1;
            // 
            // addfnameBox
            // 
            this.addfnameBox.Location = new System.Drawing.Point(6, 87);
            this.addfnameBox.Name = "addfnameBox";
            this.addfnameBox.Size = new System.Drawing.Size(238, 21);
            this.addfnameBox.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(3, 37);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(258, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // sendtoprevCheckBox
            // 
            this.sendtoprevCheckBox.AutoSize = true;
            this.sendtoprevCheckBox.Location = new System.Drawing.Point(188, 7);
            this.sendtoprevCheckBox.Name = "sendtoprevCheckBox";
            this.sendtoprevCheckBox.Size = new System.Drawing.Size(282, 17);
            this.sendtoprevCheckBox.TabIndex = 6;
            this.sendtoprevCheckBox.Text = "Send only to contacts who have mailed you previously";
            this.sendtoprevCheckBox.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 84);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1049, 7);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 10;
            this.progressBar.Visible = false;
            // 
            // attachView
            // 
            this.attachView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.attachView.AllowDrop = true;
            this.attachView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attachView.Location = new System.Drawing.Point(7, 94);
            this.attachView.Name = "attachView";
            this.attachView.Size = new System.Drawing.Size(1040, 75);
            this.attachView.TabIndex = 9;
            this.attachView.TabStop = false;
            this.attachView.UseCompatibleStateImageBehavior = false;
            this.attachView.Visible = false;
            this.attachView.VisibleChanged += new System.EventHandler(this.attachView_VisibleChanged);
            this.attachView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.attachView_MouseClick);
            // 
            // attachButton
            // 
            this.attachButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachButton.Location = new System.Drawing.Point(135, 4);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(47, 23);
            this.attachButton.TabIndex = 5;
            this.attachButton.Text = "INSERT";
            this.attachButton.UseVisualStyleBackColor = true;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectTextBox.Location = new System.Drawing.Point(49, 61);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(757, 20);
            this.subjectTextBox.TabIndex = 2;
            // 
            // toTextBox
            // 
            this.toTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toTextBox.Location = new System.Drawing.Point(49, 34);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(757, 20);
            this.toTextBox.TabIndex = 1;
            this.toTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toTextBox_KeyPress);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(8, 65);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(43, 13);
            this.subjectLabel.TabIndex = 5;
            this.subjectLabel.Text = "Subject";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(30, 37);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 13);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To";
            this.toLabel.Click += new System.EventHandler(this.toLabel_Click);
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(4, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(125, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.AcceptsTab = true;
            this.bodyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bodyTextBox.Location = new System.Drawing.Point(3, 94);
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.bodyTextBox.Size = new System.Drawing.Size(1049, 448);
            this.bodyTextBox.TabIndex = 3;
            this.bodyTextBox.Text = "";
            // 
            // accountviewBox
            // 
            this.accountviewBox.FormattingEnabled = true;
            this.accountviewBox.Location = new System.Drawing.Point(775, 3);
            this.accountviewBox.MaxDropDownItems = 20;
            this.accountviewBox.Name = "accountviewBox";
            this.accountviewBox.Size = new System.Drawing.Size(201, 21);
            this.accountviewBox.TabIndex = 7;
            // 
            // contactContext
            // 
            this.contactContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToMailToolStripMenuItem,
            this.editcontactToolStripMenuItem,
            this.removeContactToolStripMenuItem});
            this.contactContext.Name = "contactContext";
            this.contactContext.Size = new System.Drawing.Size(163, 70);
            // 
            // addToMailToolStripMenuItem
            // 
            this.addToMailToolStripMenuItem.Name = "addToMailToolStripMenuItem";
            this.addToMailToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addToMailToolStripMenuItem.Text = "Add to Mail";
            this.addToMailToolStripMenuItem.Click += new System.EventHandler(this.addToMailToolStripMenuItem_Click);
            // 
            // editcontactToolStripMenuItem
            // 
            this.editcontactToolStripMenuItem.Name = "editcontactToolStripMenuItem";
            this.editcontactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editcontactToolStripMenuItem.Text = "Edit Contact";
            this.editcontactToolStripMenuItem.Click += new System.EventHandler(this.editcontactToolStripMenuItem_Click);
            // 
            // removeContactToolStripMenuItem
            // 
            this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            this.removeContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.removeContactToolStripMenuItem.Text = "Remove Contact";
            this.removeContactToolStripMenuItem.Click += new System.EventHandler(this.removeContactToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Open";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // attachContext
            // 
            this.attachContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.attachContext.Name = "attachContext";
            this.attachContext.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeAttachToolStripMenuItem_Click);
            // 
            // accountpwBox
            // 
            this.accountpwBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountpwBox.Location = new System.Drawing.Point(1036, 3);
            this.accountpwBox.Name = "accountpwBox";
            this.accountpwBox.Size = new System.Drawing.Size(155, 21);
            this.accountpwBox.TabIndex = 8;
            // 
            // savepwcheckBox
            // 
            this.savepwcheckBox.AutoSize = true;
            this.savepwcheckBox.Location = new System.Drawing.Point(1197, 5);
            this.savepwcheckBox.Name = "savepwcheckBox";
            this.savepwcheckBox.Size = new System.Drawing.Size(126, 17);
            this.savepwcheckBox.TabIndex = 3;
            this.savepwcheckBox.Text = "Remember Password";
            this.savepwcheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(983, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email Account";
            // 
            // MailerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 567);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.savepwcheckBox);
            this.Controls.Add(this.accountpwBox);
            this.Controls.Add(this.accountviewBox);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MailerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holiday Mailer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MailerForm_FormClosed);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MailerForm_DragDrop);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel1.PerformLayout();
            this.sc.Panel2.ResumeLayout(false);
            this.sc.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.contactControl.ResumeLayout(false);
            this.contactPage.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            this.contactContext.ResumeLayout(false);
            this.attachContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mailerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.TabControl contactControl;
        private System.Windows.Forms.TabPage contactPage;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListView contactView;
        private System.Windows.Forms.TextBox addemailBox;
        private System.Windows.Forms.TextBox addlnameBox;
        private System.Windows.Forms.TextBox addfnameBox;
        private System.Windows.Forms.ComboBox accountviewBox;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox bodyTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button addcontactButton;
        private System.Windows.Forms.CheckBox prevmailedCheckBox;
        private System.Windows.Forms.TextBox addrelationBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.ContextMenuStrip contactContext;
        private System.Windows.Forms.ToolStripMenuItem editcontactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListView attachView;
        private System.Windows.Forms.ContextMenuStrip attachContext;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox accountpwBox;
        private System.Windows.Forms.CheckBox savepwcheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox sendtoprevCheckBox;
        private System.Windows.Forms.ToolStripMenuItem addToMailToolStripMenuItem;
    }
}