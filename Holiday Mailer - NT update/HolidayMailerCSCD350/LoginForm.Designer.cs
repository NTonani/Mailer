namespace HolidayMailerCSCD350
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newaccountButton = new System.Windows.Forms.Button();
            this.forgotButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountTextBox
            // 
            this.accountTextBox.BackColor = System.Drawing.Color.White;
            this.accountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.accountTextBox.Location = new System.Drawing.Point(19, 132);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(247, 20);
            this.accountTextBox.TabIndex = 0;
            this.accountTextBox.Text = "Account";
            this.accountTextBox.Enter += new System.EventHandler(this.accountTextBox_Enter);
            this.accountTextBox.Leave += new System.EventHandler(this.accountTextBox_Leave);
            // 
            // pwTextBox
            // 
            this.pwTextBox.BackColor = System.Drawing.Color.White;
            this.pwTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.pwTextBox.Location = new System.Drawing.Point(19, 158);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(247, 20);
            this.pwTextBox.TabIndex = 1;
            this.pwTextBox.Text = "Password";
            this.pwTextBox.Enter += new System.EventHandler(this.pwTextBox_Enter);
            this.pwTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwTextBox_KeyDown);
            this.pwTextBox.Leave += new System.EventHandler(this.pwTextBox_Leave);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(19, 209);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(247, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginCheckbox
            // 
            this.loginCheckbox.AutoSize = true;
            this.loginCheckbox.ForeColor = System.Drawing.Color.Black;
            this.loginCheckbox.Location = new System.Drawing.Point(19, 184);
            this.loginCheckbox.Name = "loginCheckbox";
            this.loginCheckbox.Size = new System.Drawing.Size(80, 17);
            this.loginCheckbox.TabIndex = 5;
            this.loginCheckbox.Text = "Save Login";
            this.loginCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(95, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "New to Dream Street?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(97, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Forgot your login info?";
            // 
            // newaccountButton
            // 
            this.newaccountButton.BackColor = System.Drawing.Color.White;
            this.newaccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newaccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newaccountButton.ForeColor = System.Drawing.Color.Black;
            this.newaccountButton.Location = new System.Drawing.Point(19, 298);
            this.newaccountButton.Name = "newaccountButton";
            this.newaccountButton.Size = new System.Drawing.Size(247, 23);
            this.newaccountButton.TabIndex = 9;
            this.newaccountButton.Text = "CREATE A NEW ACCOUNT";
            this.newaccountButton.UseVisualStyleBackColor = false;
            this.newaccountButton.Click += new System.EventHandler(this.newaccountButton_Click);
            // 
            // forgotButton
            // 
            this.forgotButton.BackColor = System.Drawing.Color.White;
            this.forgotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotButton.ForeColor = System.Drawing.Color.Black;
            this.forgotButton.Location = new System.Drawing.Point(19, 339);
            this.forgotButton.Name = "forgotButton";
            this.forgotButton.Size = new System.Drawing.Size(247, 23);
            this.forgotButton.TabIndex = 10;
            this.forgotButton.Text = "RETRIEVE LOGIN";
            this.forgotButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-20, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 6);
            this.label5.TabIndex = 11;
            this.label5.Text = "_________________________________________________________________________________" +
    "___________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(10, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 73);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(69, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "DREAM STREET";
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Miramonte", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeButton.Location = new System.Drawing.Point(256, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 24);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeButton.Location = new System.Drawing.Point(222, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(31, 24);
            this.minimizeButton.TabIndex = 16;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 26);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.forgotButton);
            this.Controls.Add(this.newaccountButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginCheckbox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.accountTextBox);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.MinimumSize = new System.Drawing.Size(287, 381);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountTextBox;
        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox loginCheckbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newaccountButton;
        private System.Windows.Forms.Button forgotButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel panel1;
    }
}

