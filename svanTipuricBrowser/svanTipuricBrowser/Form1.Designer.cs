namespace svanTipuricBrowser
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnNaprijed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIdi = new System.Windows.Forms.Button();
            this.btnGmail = new System.Windows.Forms.Button();
            this.btnWebmail = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(2, 41);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(797, 407);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.Color.Lavender;
            this.btnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNazad.Location = new System.Drawing.Point(12, 12);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 1;
            this.btnNazad.Text = "Natrag";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaprijed.Location = new System.Drawing.Point(93, 12);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(75, 23);
            this.btnNaprijed.TabIndex = 2;
            this.btnNaprijed.Text = "Naprijed";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            this.btnNaprijed.Click += new System.EventHandler(this.btnNaprijed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adresa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnIdi
            // 
            this.btnIdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdi.Location = new System.Drawing.Point(456, 11);
            this.btnIdi.Name = "btnIdi";
            this.btnIdi.Size = new System.Drawing.Size(39, 23);
            this.btnIdi.TabIndex = 5;
            this.btnIdi.Text = "Idi";
            this.btnIdi.UseVisualStyleBackColor = true;
            this.btnIdi.Click += new System.EventHandler(this.btnIdi_Click);
            // 
            // btnGmail
            // 
            this.btnGmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGmail.Location = new System.Drawing.Point(562, 11);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(75, 23);
            this.btnGmail.TabIndex = 6;
            this.btnGmail.Text = "Gmail";
            this.btnGmail.UseVisualStyleBackColor = true;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // btnWebmail
            // 
            this.btnWebmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebmail.Location = new System.Drawing.Point(643, 11);
            this.btnWebmail.Name = "btnWebmail";
            this.btnWebmail.Size = new System.Drawing.Size(75, 23);
            this.btnWebmail.TabIndex = 7;
            this.btnWebmail.Text = "Webmail";
            this.btnWebmail.UseVisualStyleBackColor = true;
            this.btnWebmail.Click += new System.EventHandler(this.btnWebmail_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspis.Location = new System.Drawing.Point(724, 11);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 23);
            this.btnIspis.TabIndex = 8;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnWebmail);
            this.Controls.Add(this.btnGmail);
            this.Controls.Add(this.btnIdi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNaprijed);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.Text = "Web izbornik";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnNaprijed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIdi;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button btnWebmail;
        private System.Windows.Forms.Button btnIspis;
    }
}

