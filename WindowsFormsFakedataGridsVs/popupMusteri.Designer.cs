namespace WindowsFormsFakedataGridsVs
{
    partial class popupMusteri
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
            this.btn_kapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tamisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Red;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_kapat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_kapat.Location = new System.Drawing.Point(779, 1);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(20, 20);
            this.btn_kapat.TabIndex = 0;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Isim";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(119, 46);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(269, 20);
            this.txt_isim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(119, 72);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(269, 20);
            this.txt_soyisim.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Full";
            // 
            // txt_tamisim
            // 
            this.txt_tamisim.Location = new System.Drawing.Point(119, 98);
            this.txt_tamisim.Name = "txt_tamisim";
            this.txt_tamisim.Size = new System.Drawing.Size(269, 20);
            this.txt_tamisim.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adres";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(435, 46);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(269, 20);
            this.txt_email.TabIndex = 2;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(435, 72);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(269, 20);
            this.txt_telefon.TabIndex = 2;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(119, 124);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(585, 47);
            this.txt_adres.TabIndex = 2;
            // 
            // popupMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 193);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tamisim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "popupMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "popupMusteri";
            this.Load += new System.EventHandler(this.popupMusteri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tamisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_adres;
    }
}