namespace MessageBoxUygulama
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_emailAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_telefonNumarasi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_YeniKayit = new System.Windows.Forms.Button();
            this.lst_musteriler = new System.Windows.Forms.ListBox();
            this.ntf_bildirimCubugu = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_YeniKayit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_telefonNumarasi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_emailAdres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_soyisim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_isim);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_musteriler);
            this.groupBox2.Location = new System.Drawing.Point(359, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Musteri Kayit Listesi";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(112, 51);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(223, 20);
            this.txt_isim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Isim";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(112, 74);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(223, 20);
            this.txt_soyisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // txt_emailAdres
            // 
            this.txt_emailAdres.Location = new System.Drawing.Point(112, 96);
            this.txt_emailAdres.Name = "txt_emailAdres";
            this.txt_emailAdres.Size = new System.Drawing.Size(223, 20);
            this.txt_emailAdres.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email Adresi";
            // 
            // txt_telefonNumarasi
            // 
            this.txt_telefonNumarasi.Location = new System.Drawing.Point(112, 119);
            this.txt_telefonNumarasi.Name = "txt_telefonNumarasi";
            this.txt_telefonNumarasi.Size = new System.Drawing.Size(223, 20);
            this.txt_telefonNumarasi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefon Numarasi";
            // 
            // btn_YeniKayit
            // 
            this.btn_YeniKayit.Location = new System.Drawing.Point(112, 146);
            this.btn_YeniKayit.Name = "btn_YeniKayit";
            this.btn_YeniKayit.Size = new System.Drawing.Size(104, 33);
            this.btn_YeniKayit.TabIndex = 4;
            this.btn_YeniKayit.Text = "Yeni Musteri Ekle";
            this.btn_YeniKayit.UseVisualStyleBackColor = true;
            this.btn_YeniKayit.Click += new System.EventHandler(this.btn_YeniKayit_Click);
            // 
            // lst_musteriler
            // 
            this.lst_musteriler.FormattingEnabled = true;
            this.lst_musteriler.Location = new System.Drawing.Point(7, 20);
            this.lst_musteriler.Name = "lst_musteriler";
            this.lst_musteriler.Size = new System.Drawing.Size(298, 186);
            this.lst_musteriler.TabIndex = 0;
            // 
            // ntf_bildirimCubugu
            // 
            this.ntf_bildirimCubugu.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 239);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Box Uygulama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_YeniKayit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telefonNumarasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_emailAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.ListBox lst_musteriler;
        private System.Windows.Forms.NotifyIcon ntf_bildirimCubugu;
    }
}

