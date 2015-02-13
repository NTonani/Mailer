namespace HolidayMailerCSCD350
{
    partial class PasswordReset
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errormessagetb = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.finishbutton = new System.Windows.Forms.Button();
            this.successlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(60, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please provide your username:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // errormessagetb
            // 
            this.errormessagetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errormessagetb.Location = new System.Drawing.Point(60, 155);
            this.errormessagetb.Name = "errormessagetb";
            this.errormessagetb.ReadOnly = true;
            this.errormessagetb.Size = new System.Drawing.Size(149, 13);
            this.errormessagetb.TabIndex = 3;
            // 
            // sendbtn
            // 
            this.sendbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sendbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendbtn.Location = new System.Drawing.Point(60, 246);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(182, 23);
            this.sendbtn.TabIndex = 4;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = false;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(101, 302);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 5;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Location = new System.Drawing.Point(60, 126);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(182, 23);
            this.searchbtn.TabIndex = 6;
            this.searchbtn.Text = "Submit";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select address to be notified";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeButton.Location = new System.Drawing.Point(234, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(31, 24);
            this.minimizeButton.TabIndex = 16;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeButton.Location = new System.Drawing.Point(268, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 24);
            this.closeButton.TabIndex = 15;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 26);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.finishbutton);
            this.panel2.Controls.Add(this.successlabel);
            this.panel2.Location = new System.Drawing.Point(6, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 244);
            this.panel2.TabIndex = 19;
            this.panel2.Visible = false;
            // 
            // finishbutton
            // 
            this.finishbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishbutton.Location = new System.Drawing.Point(152, 184);
            this.finishbutton.Name = "finishbutton";
            this.finishbutton.Size = new System.Drawing.Size(100, 31);
            this.finishbutton.TabIndex = 1;
            this.finishbutton.Text = "FINISH";
            this.finishbutton.UseVisualStyleBackColor = true;
            this.finishbutton.Click += new System.EventHandler(this.finishbutton_Click);
            // 
            // successlabel
            // 
            this.successlabel.Location = new System.Drawing.Point(19, 29);
            this.successlabel.Name = "successlabel";
            this.successlabel.Size = new System.Drawing.Size(256, 116);
            this.successlabel.TabIndex = 0;
            // 
            // PasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(303, 297);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.errormessagetb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "PasswordReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordReset";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox errormessagetb;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label successlabel;
        private System.Windows.Forms.Button finishbutton;
    }
}