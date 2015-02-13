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
            this.sc = new System.Windows.Forms.SplitContainer();
            this.editPanel = new System.Windows.Forms.Panel();
            this.editerrbox = new System.Windows.Forms.TextBox();
            this.editCancel = new System.Windows.Forms.Button();
            this.editbday = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.saveedit = new System.Windows.Forms.Button();
            this.editprevmail = new System.Windows.Forms.CheckBox();
            this.editrelation = new System.Windows.Forms.TextBox();
            this.editemail = new System.Windows.Forms.TextBox();
            this.editlname = new System.Windows.Forms.TextBox();
            this.editfname = new System.Windows.Forms.TextBox();
            this.contactControl = new System.Windows.Forms.TabControl();
            this.contactPage = new System.Windows.Forms.TabPage();
            this.searchln = new System.Windows.Forms.TextBox();
            this.sortBy = new System.Windows.Forms.ComboBox();
            this.contactView = new System.Windows.Forms.ListView();
            this.addPage = new System.Windows.Forms.TabPage();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.addbdayBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addcontactButton = new System.Windows.Forms.Button();
            this.prevmailedCheckBox = new System.Windows.Forms.CheckBox();
            this.addrelationBox = new System.Windows.Forms.TextBox();
            this.addemailBox = new System.Windows.Forms.TextBox();
            this.addlnameBox = new System.Windows.Forms.TextBox();
            this.addfnameBox = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.sendtoall = new System.Windows.Forms.CheckBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountviewBox = new System.Windows.Forms.ComboBox();
            this.accountpwBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mailerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editcontactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.attachContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelbar = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.contactControl.SuspendLayout();
            this.contactPage.SuspendLayout();
            this.addPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contactContext.SuspendLayout();
            this.attachContext.SuspendLayout();
            this.panelbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc
            // 
            this.sc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.sc.IsSplitterFixed = true;
            this.sc.Location = new System.Drawing.Point(0, 0);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.BackColor = System.Drawing.Color.White;
            this.sc.Panel1.Controls.Add(this.editPanel);
            this.sc.Panel1.Controls.Add(this.contactControl);
            this.sc.Panel1.Controls.Add(this.searchBox);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.AllowDrop = true;
            this.sc.Panel2.BackColor = System.Drawing.Color.White;
            this.sc.Panel2.Controls.Add(this.sendtoall);
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
            this.sc.Size = new System.Drawing.Size(1471, 861);
            this.sc.SplitterDistance = 357;
            this.sc.SplitterWidth = 1;
            this.sc.TabIndex = 1;
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.editerrbox);
            this.editPanel.Controls.Add(this.editCancel);
            this.editPanel.Controls.Add(this.editbday);
            this.editPanel.Controls.Add(this.label8);
            this.editPanel.Controls.Add(this.label9);
            this.editPanel.Controls.Add(this.label10);
            this.editPanel.Controls.Add(this.label11);
            this.editPanel.Controls.Add(this.saveedit);
            this.editPanel.Controls.Add(this.editprevmail);
            this.editPanel.Controls.Add(this.editrelation);
            this.editPanel.Controls.Add(this.editemail);
            this.editPanel.Controls.Add(this.editlname);
            this.editPanel.Controls.Add(this.editfname);
            this.editPanel.Location = new System.Drawing.Point(8, 168);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(342, 712);
            this.editPanel.TabIndex = 11;
            this.editPanel.Visible = false;
            // 
            // editerrbox
            // 
            this.editerrbox.BackColor = System.Drawing.Color.White;
            this.editerrbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editerrbox.Location = new System.Drawing.Point(76, 424);
            this.editerrbox.Name = "editerrbox";
            this.editerrbox.ReadOnly = true;
            this.editerrbox.Size = new System.Drawing.Size(185, 13);
            this.editerrbox.TabIndex = 26;
            // 
            // editCancel
            // 
            this.editCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editCancel.Location = new System.Drawing.Point(304, 3);
            this.editCancel.Name = "editCancel";
            this.editCancel.Size = new System.Drawing.Size(32, 24);
            this.editCancel.TabIndex = 25;
            this.editCancel.TabStop = false;
            this.editCancel.Text = "X";
            this.editCancel.UseVisualStyleBackColor = true;
            this.editCancel.Click += new System.EventHandler(this.editCancel_Click);
            // 
            // editbday
            // 
            this.editbday.BackColor = System.Drawing.Color.White;
            this.editbday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editbday.ForeColor = System.Drawing.Color.Black;
            this.editbday.Location = new System.Drawing.Point(12, 327);
            this.editbday.Name = "editbday";
            this.editbday.Size = new System.Drawing.Size(319, 20);
            this.editbday.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Birthday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Relation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(9, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Email Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(9, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Name";
            // 
            // saveedit
            // 
            this.saveedit.BackColor = System.Drawing.Color.White;
            this.saveedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveedit.ForeColor = System.Drawing.Color.Black;
            this.saveedit.Location = new System.Drawing.Point(12, 388);
            this.saveedit.Name = "saveedit";
            this.saveedit.Size = new System.Drawing.Size(319, 23);
            this.saveedit.TabIndex = 18;
            this.saveedit.Text = "SAVE CHANGES";
            this.saveedit.UseVisualStyleBackColor = false;
            this.saveedit.Click += new System.EventHandler(this.saveedit_Click);
            // 
            // editprevmail
            // 
            this.editprevmail.AutoSize = true;
            this.editprevmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editprevmail.ForeColor = System.Drawing.Color.Black;
            this.editprevmail.Location = new System.Drawing.Point(12, 363);
            this.editprevmail.Name = "editprevmail";
            this.editprevmail.Size = new System.Drawing.Size(210, 19);
            this.editprevmail.TabIndex = 17;
            this.editprevmail.Text = "Contact has mailed you previously";
            this.editprevmail.UseVisualStyleBackColor = true;
            // 
            // editrelation
            // 
            this.editrelation.BackColor = System.Drawing.Color.White;
            this.editrelation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editrelation.ForeColor = System.Drawing.Color.Black;
            this.editrelation.Location = new System.Drawing.Point(12, 275);
            this.editrelation.Name = "editrelation";
            this.editrelation.Size = new System.Drawing.Size(319, 20);
            this.editrelation.TabIndex = 16;
            // 
            // editemail
            // 
            this.editemail.BackColor = System.Drawing.Color.White;
            this.editemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editemail.ForeColor = System.Drawing.Color.Black;
            this.editemail.Location = new System.Drawing.Point(12, 222);
            this.editemail.Name = "editemail";
            this.editemail.Size = new System.Drawing.Size(319, 20);
            this.editemail.TabIndex = 15;
            // 
            // editlname
            // 
            this.editlname.BackColor = System.Drawing.Color.White;
            this.editlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editlname.ForeColor = System.Drawing.Color.DarkGray;
            this.editlname.Location = new System.Drawing.Point(173, 169);
            this.editlname.Name = "editlname";
            this.editlname.Size = new System.Drawing.Size(158, 21);
            this.editlname.TabIndex = 14;
            this.editlname.Text = "Last";
            this.editlname.Enter += new System.EventHandler(this.editlname_Enter);
            this.editlname.Leave += new System.EventHandler(this.editlname_Leave);
            // 
            // editfname
            // 
            this.editfname.BackColor = System.Drawing.Color.White;
            this.editfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editfname.ForeColor = System.Drawing.Color.DarkGray;
            this.editfname.Location = new System.Drawing.Point(12, 169);
            this.editfname.Name = "editfname";
            this.editfname.Size = new System.Drawing.Size(157, 21);
            this.editfname.TabIndex = 13;
            this.editfname.Text = "First";
            this.editfname.Enter += new System.EventHandler(this.editfname_Enter);
            this.editfname.Leave += new System.EventHandler(this.editfname_Leave);
            // 
            // contactControl
            // 
            this.contactControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactControl.Controls.Add(this.contactPage);
            this.contactControl.Controls.Add(this.addPage);
            this.contactControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactControl.ItemSize = new System.Drawing.Size(169, 40);
            this.contactControl.Location = new System.Drawing.Point(3, 101);
            this.contactControl.Name = "contactControl";
            this.contactControl.SelectedIndex = 0;
            this.contactControl.Size = new System.Drawing.Size(351, 760);
            this.contactControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.contactControl.TabIndex = 0;
            this.contactControl.TabStop = false;
            // 
            // contactPage
            // 
            this.contactPage.BackColor = System.Drawing.Color.White;
            this.contactPage.Controls.Add(this.searchln);
            this.contactPage.Controls.Add(this.sortBy);
            this.contactPage.Controls.Add(this.contactView);
            this.contactPage.Location = new System.Drawing.Point(4, 44);
            this.contactPage.Name = "contactPage";
            this.contactPage.Padding = new System.Windows.Forms.Padding(3);
            this.contactPage.Size = new System.Drawing.Size(343, 712);
            this.contactPage.TabIndex = 0;
            this.contactPage.Text = "Contacts";
            // 
            // searchln
            // 
            this.searchln.ForeColor = System.Drawing.Color.DarkGray;
            this.searchln.Location = new System.Drawing.Point(204, 3);
            this.searchln.Name = "searchln";
            this.searchln.Size = new System.Drawing.Size(127, 21);
            this.searchln.TabIndex = 12;
            this.searchln.Text = "Search by Last Name";
            this.searchln.TextChanged += new System.EventHandler(this.searchln_TextChanged);
            this.searchln.Enter += new System.EventHandler(this.searchln_Enter);
            this.searchln.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchln_KeyPress);
            this.searchln.Leave += new System.EventHandler(this.searchln_Leave);
            // 
            // sortBy
            // 
            this.sortBy.BackColor = System.Drawing.Color.White;
            this.sortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortBy.ForeColor = System.Drawing.Color.Black;
            this.sortBy.FormattingEnabled = true;
            this.sortBy.Location = new System.Drawing.Point(1, 1);
            this.sortBy.Name = "sortBy";
            this.sortBy.Size = new System.Drawing.Size(199, 23);
            this.sortBy.TabIndex = 1;
            this.sortBy.SelectedIndexChanged += new System.EventHandler(this.sortBy_SelectedIndexChanged);
            this.sortBy.SelectionChangeCommitted += new System.EventHandler(this.sortBy_SelectionChangeCommitted);
            // 
            // contactView
            // 
            this.contactView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactView.BackColor = System.Drawing.Color.White;
            this.contactView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactView.ForeColor = System.Drawing.Color.Black;
            this.contactView.FullRowSelect = true;
            this.contactView.HideSelection = false;
            this.contactView.Location = new System.Drawing.Point(0, 23);
            this.contactView.Name = "contactView";
            this.contactView.ShowItemToolTips = true;
            this.contactView.Size = new System.Drawing.Size(340, 690);
            this.contactView.TabIndex = 0;
            this.contactView.TabStop = false;
            this.contactView.UseCompatibleStateImageBehavior = false;
            this.contactView.View = System.Windows.Forms.View.Details;
            this.contactView.SelectedIndexChanged += new System.EventHandler(this.contactView_SelectedIndexChanged);
            this.contactView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contactView_MouseClick);
            // 
            // addPage
            // 
            this.addPage.BackColor = System.Drawing.Color.White;
            this.addPage.Controls.Add(this.resultBox);
            this.addPage.Controls.Add(this.addbdayBox);
            this.addPage.Controls.Add(this.label2);
            this.addPage.Controls.Add(this.clearButton);
            this.addPage.Controls.Add(this.label4);
            this.addPage.Controls.Add(this.label3);
            this.addPage.Controls.Add(this.label1);
            this.addPage.Controls.Add(this.addcontactButton);
            this.addPage.Controls.Add(this.prevmailedCheckBox);
            this.addPage.Controls.Add(this.addrelationBox);
            this.addPage.Controls.Add(this.addemailBox);
            this.addPage.Controls.Add(this.addlnameBox);
            this.addPage.Controls.Add(this.addfnameBox);
            this.addPage.ForeColor = System.Drawing.Color.Black;
            this.addPage.Location = new System.Drawing.Point(4, 44);
            this.addPage.Name = "addPage";
            this.addPage.Padding = new System.Windows.Forms.Padding(3);
            this.addPage.Size = new System.Drawing.Size(343, 712);
            this.addPage.TabIndex = 1;
            this.addPage.Text = "Add Contact";
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.White;
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.Location = new System.Drawing.Point(72, 422);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(185, 14);
            this.resultBox.TabIndex = 9;
            // 
            // addbdayBox
            // 
            this.addbdayBox.BackColor = System.Drawing.Color.White;
            this.addbdayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addbdayBox.ForeColor = System.Drawing.Color.Black;
            this.addbdayBox.Location = new System.Drawing.Point(8, 327);
            this.addbdayBox.Name = "addbdayBox";
            this.addbdayBox.Size = new System.Drawing.Size(319, 21);
            this.addbdayBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Birthday";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(8, 481);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(319, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Relation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // addcontactButton
            // 
            this.addcontactButton.BackColor = System.Drawing.Color.White;
            this.addcontactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcontactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcontactButton.ForeColor = System.Drawing.Color.Black;
            this.addcontactButton.Location = new System.Drawing.Point(8, 388);
            this.addcontactButton.Name = "addcontactButton";
            this.addcontactButton.Size = new System.Drawing.Size(319, 23);
            this.addcontactButton.TabIndex = 5;
            this.addcontactButton.Text = "ADD CONTACT";
            this.addcontactButton.UseVisualStyleBackColor = false;
            this.addcontactButton.Click += new System.EventHandler(this.addcontactButton_Click);
            // 
            // prevmailedCheckBox
            // 
            this.prevmailedCheckBox.AutoSize = true;
            this.prevmailedCheckBox.ForeColor = System.Drawing.Color.Black;
            this.prevmailedCheckBox.Location = new System.Drawing.Point(8, 363);
            this.prevmailedCheckBox.Name = "prevmailedCheckBox";
            this.prevmailedCheckBox.Size = new System.Drawing.Size(210, 19);
            this.prevmailedCheckBox.TabIndex = 4;
            this.prevmailedCheckBox.Text = "Contact has mailed you previously";
            this.prevmailedCheckBox.UseVisualStyleBackColor = true;
            // 
            // addrelationBox
            // 
            this.addrelationBox.BackColor = System.Drawing.Color.White;
            this.addrelationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addrelationBox.ForeColor = System.Drawing.Color.Black;
            this.addrelationBox.Location = new System.Drawing.Point(8, 275);
            this.addrelationBox.Name = "addrelationBox";
            this.addrelationBox.Size = new System.Drawing.Size(319, 21);
            this.addrelationBox.TabIndex = 3;
            // 
            // addemailBox
            // 
            this.addemailBox.BackColor = System.Drawing.Color.White;
            this.addemailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addemailBox.ForeColor = System.Drawing.Color.Black;
            this.addemailBox.Location = new System.Drawing.Point(8, 222);
            this.addemailBox.Name = "addemailBox";
            this.addemailBox.Size = new System.Drawing.Size(319, 21);
            this.addemailBox.TabIndex = 2;
            // 
            // addlnameBox
            // 
            this.addlnameBox.BackColor = System.Drawing.Color.White;
            this.addlnameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addlnameBox.ForeColor = System.Drawing.Color.DarkGray;
            this.addlnameBox.Location = new System.Drawing.Point(169, 169);
            this.addlnameBox.Name = "addlnameBox";
            this.addlnameBox.Size = new System.Drawing.Size(157, 21);
            this.addlnameBox.TabIndex = 1;
            this.addlnameBox.Text = "Last";
            this.addlnameBox.Enter += new System.EventHandler(this.addlnameBox_Enter);
            this.addlnameBox.Leave += new System.EventHandler(this.addlnameBox_Leave);
            // 
            // addfnameBox
            // 
            this.addfnameBox.BackColor = System.Drawing.Color.White;
            this.addfnameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addfnameBox.ForeColor = System.Drawing.Color.DarkGray;
            this.addfnameBox.Location = new System.Drawing.Point(8, 169);
            this.addfnameBox.Name = "addfnameBox";
            this.addfnameBox.Size = new System.Drawing.Size(157, 21);
            this.addfnameBox.TabIndex = 0;
            this.addfnameBox.Text = "First";
            this.addfnameBox.Enter += new System.EventHandler(this.addfnameBox_Enter);
            this.addfnameBox.Leave += new System.EventHandler(this.addfnameBox_Leave);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Location = new System.Drawing.Point(3, 75);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(347, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.Text = "Search";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // sendtoall
            // 
            this.sendtoall.AutoSize = true;
            this.sendtoall.Location = new System.Drawing.Point(211, 76);
            this.sendtoall.Name = "sendtoall";
            this.sendtoall.Size = new System.Drawing.Size(120, 17);
            this.sendtoall.TabIndex = 11;
            this.sendtoall.Text = "Send to all contacts";
            this.sendtoall.UseVisualStyleBackColor = true;
            this.sendtoall.CheckedChanged += new System.EventHandler(this.sendtoall_CheckedChanged);
            // 
            // sendtoprevCheckBox
            // 
            this.sendtoprevCheckBox.AutoSize = true;
            this.sendtoprevCheckBox.BackColor = System.Drawing.Color.White;
            this.sendtoprevCheckBox.ForeColor = System.Drawing.Color.Black;
            this.sendtoprevCheckBox.Location = new System.Drawing.Point(337, 76);
            this.sendtoprevCheckBox.Name = "sendtoprevCheckBox";
            this.sendtoprevCheckBox.Size = new System.Drawing.Size(282, 17);
            this.sendtoprevCheckBox.TabIndex = 6;
            this.sendtoprevCheckBox.Text = "Send only to contacts who have previously mailed you";
            this.sendtoprevCheckBox.UseVisualStyleBackColor = false;
            this.sendtoprevCheckBox.CheckedChanged += new System.EventHandler(this.sendtoprevCheckBox_CheckedChanged);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(5, 154);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1097, 7);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 10;
            this.progressBar.Visible = false;
            // 
            // attachView
            // 
            this.attachView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.attachView.AllowDrop = true;
            this.attachView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.attachView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attachView.ForeColor = System.Drawing.Color.Black;
            this.attachView.Location = new System.Drawing.Point(9, 164);
            this.attachView.Name = "attachView";
            this.attachView.Size = new System.Drawing.Size(1109, 75);
            this.attachView.TabIndex = 9;
            this.attachView.TabStop = false;
            this.attachView.UseCompatibleStateImageBehavior = false;
            this.attachView.Visible = false;
            this.attachView.VisibleChanged += new System.EventHandler(this.attachView_VisibleChanged);
            this.attachView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.attachView_MouseClick);
            // 
            // attachButton
            // 
            this.attachButton.BackColor = System.Drawing.Color.White;
            this.attachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachButton.ForeColor = System.Drawing.Color.Black;
            this.attachButton.Location = new System.Drawing.Point(153, 73);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(52, 23);
            this.attachButton.TabIndex = 5;
            this.attachButton.Text = "INSERT";
            this.attachButton.UseVisualStyleBackColor = false;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.BackColor = System.Drawing.Color.White;
            this.subjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectTextBox.ForeColor = System.Drawing.Color.Black;
            this.subjectTextBox.Location = new System.Drawing.Point(51, 131);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(1051, 20);
            this.subjectTextBox.TabIndex = 2;
            // 
            // toTextBox
            // 
            this.toTextBox.BackColor = System.Drawing.Color.White;
            this.toTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toTextBox.ForeColor = System.Drawing.Color.Black;
            this.toTextBox.Location = new System.Drawing.Point(51, 104);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(1051, 20);
            this.toTextBox.TabIndex = 1;
            this.toTextBox.TextChanged += new System.EventHandler(this.toTextBox_TextChanged);
            this.toTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toTextBox_KeyPress);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.BackColor = System.Drawing.Color.White;
            this.subjectLabel.ForeColor = System.Drawing.Color.Black;
            this.subjectLabel.Location = new System.Drawing.Point(8, 135);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(43, 13);
            this.subjectLabel.TabIndex = 5;
            this.subjectLabel.Text = "Subject";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.BackColor = System.Drawing.Color.White;
            this.toLabel.ForeColor = System.Drawing.Color.Black;
            this.toLabel.Location = new System.Drawing.Point(30, 107);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 13);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To";
            this.toLabel.Click += new System.EventHandler(this.toLabel_Click);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.White;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.Black;
            this.sendButton.Location = new System.Drawing.Point(22, 73);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(125, 23);
            this.sendButton.TabIndex = 4;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.AcceptsTab = true;
            this.bodyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.bodyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bodyTextBox.ForeColor = System.Drawing.Color.Black;
            this.bodyTextBox.Location = new System.Drawing.Point(6, 168);
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.bodyTextBox.Size = new System.Drawing.Size(1112, 690);
            this.bodyTextBox.TabIndex = 3;
            this.bodyTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.accountviewBox);
            this.panel1.Controls.Add(this.accountpwBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 26);
            this.panel1.TabIndex = 11;
            // 
            // accountviewBox
            // 
            this.accountviewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountviewBox.BackColor = System.Drawing.Color.White;
            this.accountviewBox.ForeColor = System.Drawing.Color.Black;
            this.accountviewBox.FormattingEnabled = true;
            this.accountviewBox.Location = new System.Drawing.Point(1043, 3);
            this.accountviewBox.MaxDropDownItems = 20;
            this.accountviewBox.Name = "accountviewBox";
            this.accountviewBox.Size = new System.Drawing.Size(201, 21);
            this.accountviewBox.TabIndex = 7;
            this.accountviewBox.SelectedIndexChanged += new System.EventHandler(this.accountviewBox_SelectedIndexChanged);
            // 
            // accountpwBox
            // 
            this.accountpwBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountpwBox.BackColor = System.Drawing.Color.White;
            this.accountpwBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountpwBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountpwBox.ForeColor = System.Drawing.Color.Black;
            this.accountpwBox.Location = new System.Drawing.Point(1304, 3);
            this.accountpwBox.Name = "accountpwBox";
            this.accountpwBox.Size = new System.Drawing.Size(155, 21);
            this.accountpwBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1248, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(965, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email Account";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mailerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1471, 26);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mailerToolStripMenuItem
            // 
            this.mailerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.mailerToolStripMenuItem.Name = "mailerToolStripMenuItem";
            this.mailerToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.mailerToolStripMenuItem.Text = "Mailer";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
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
            // toContext
            // 
            this.toContext.Name = "toContext";
            this.toContext.Size = new System.Drawing.Size(61, 4);
            // 
            // panelbar
            // 
            this.panelbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelbar.Controls.Add(this.label5);
            this.panelbar.Controls.Add(this.minimizeButton);
            this.panelbar.Controls.Add(this.closeButton);
            this.panelbar.Location = new System.Drawing.Point(0, 0);
            this.panelbar.Name = "panelbar";
            this.panelbar.Size = new System.Drawing.Size(1487, 26);
            this.panelbar.TabIndex = 3;
            this.panelbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelbar_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(645, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Dream Street Holiday Mailer";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeButton.Location = new System.Drawing.Point(1401, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(31, 24);
            this.minimizeButton.TabIndex = 18;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeButton.Location = new System.Drawing.Point(1435, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 24);
            this.closeButton.TabIndex = 17;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MailerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1471, 861);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelbar);
            this.Controls.Add(this.sc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "MailerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holiday Mailer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MailerForm_FormClosed);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel1.PerformLayout();
            this.sc.Panel2.ResumeLayout(false);
            this.sc.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.contactControl.ResumeLayout(false);
            this.contactPage.ResumeLayout(false);
            this.contactPage.PerformLayout();
            this.addPage.ResumeLayout(false);
            this.addPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contactContext.ResumeLayout(false);
            this.attachContext.ResumeLayout(false);
            this.panelbar.ResumeLayout(false);
            this.panelbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.TabControl contactControl;
        private System.Windows.Forms.TabPage contactPage;
        private System.Windows.Forms.TabPage addPage;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListView contactView;
        private System.Windows.Forms.TextBox addemailBox;
        private System.Windows.Forms.TextBox addlnameBox;
        private System.Windows.Forms.TextBox addfnameBox;
        private System.Windows.Forms.ComboBox accountviewBox;
        private System.Windows.Forms.RichTextBox bodyTextBox;
        private System.Windows.Forms.ComboBox sortBy;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListView attachView;
        private System.Windows.Forms.ContextMenuStrip attachContext;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox accountpwBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox sendtoprevCheckBox;
        private System.Windows.Forms.ToolStripMenuItem addToMailToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip toContext;
        private System.Windows.Forms.TextBox addbdayBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mailerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Panel panelbar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.TextBox editbday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button saveedit;
        private System.Windows.Forms.CheckBox editprevmail;
        private System.Windows.Forms.TextBox editrelation;
        private System.Windows.Forms.TextBox editemail;
        private System.Windows.Forms.TextBox editlname;
        private System.Windows.Forms.TextBox editfname;
        private System.Windows.Forms.Button editCancel;
        private System.Windows.Forms.TextBox editerrbox;
        private System.Windows.Forms.CheckBox sendtoall;
        private System.Windows.Forms.TextBox searchln;
    }
}