namespace HolidayMailerCSCD350
{
    partial class Form1
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
            this.prevtb = new System.Windows.Forms.TextBox();
            this.reltb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dobtb = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.outputtb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.lnametb = new System.Windows.Forms.TextBox();
            this.fnametb = new System.Windows.Forms.TextBox();
            this.prevcb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // prevtb
            // 
            this.prevtb.Location = new System.Drawing.Point(0, 331);
            this.prevtb.Name = "prevtb";
            this.prevtb.Size = new System.Drawing.Size(333, 20);
            this.prevtb.TabIndex = 0;
            // 
            // reltb
            // 
            this.reltb.Location = new System.Drawing.Point(0, 357);
            this.reltb.Name = "reltb";
            this.reltb.Size = new System.Drawing.Size(333, 20);
            this.reltb.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dobtb
            // 
            this.dobtb.Location = new System.Drawing.Point(0, 383);
            this.dobtb.Name = "dobtb";
            this.dobtb.Size = new System.Drawing.Size(333, 20);
            this.dobtb.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // outputtb
            // 
            this.outputtb.Location = new System.Drawing.Point(48, 27);
            this.outputtb.Multiline = true;
            this.outputtb.Name = "outputtb";
            this.outputtb.ReadOnly = true;
            this.outputtb.Size = new System.Drawing.Size(285, 206);
            this.outputtb.TabIndex = 5;
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(0, 305);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(333, 20);
            this.emailtb.TabIndex = 6;
            // 
            // lnametb
            // 
            this.lnametb.Location = new System.Drawing.Point(0, 279);
            this.lnametb.Name = "lnametb";
            this.lnametb.Size = new System.Drawing.Size(333, 20);
            this.lnametb.TabIndex = 7;
            // 
            // fnametb
            // 
            this.fnametb.Location = new System.Drawing.Point(0, 253);
            this.fnametb.Name = "fnametb";
            this.fnametb.Size = new System.Drawing.Size(333, 20);
            this.fnametb.TabIndex = 8;
            // 
            // prevcb
            // 
            this.prevcb.AutoSize = true;
            this.prevcb.Location = new System.Drawing.Point(348, 282);
            this.prevcb.Name = "prevcb";
            this.prevcb.Size = new System.Drawing.Size(80, 17);
            this.prevcb.TabIndex = 9;
            this.prevcb.Text = "checkBox1";
            this.prevcb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 684);
            this.Controls.Add(this.prevcb);
            this.Controls.Add(this.fnametb);
            this.Controls.Add(this.lnametb);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.dobtb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reltb);
            this.Controls.Add(this.prevtb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.outputtb);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prevtb;
        private System.Windows.Forms.TextBox reltb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dobtb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox outputtb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox lnametb;
        private System.Windows.Forms.TextBox fnametb;
        private System.Windows.Forms.CheckBox prevcb;
    }
}

