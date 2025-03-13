namespace KullaniciGirisFormu
{
    partial class frm_KullaniciGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KullaniciGirisEkrani));
            this.txt_KAdi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_KAdi
            // 
            this.txt_KAdi.Location = new System.Drawing.Point(142, 42);
            this.txt_KAdi.Name = "txt_KAdi";
            this.txt_KAdi.Size = new System.Drawing.Size(203, 20);
            this.txt_KAdi.TabIndex = 0;
            this.txt_KAdi.Enter += new System.EventHandler(this.txt_KAdi_Enter);
            this.txt_KAdi.Leave += new System.EventHandler(this.txt_KAdi_Leave);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(142, 83);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.Size = new System.Drawing.Size(203, 20);
            this.txt_Sifre.TabIndex = 1;
            this.txt_Sifre.Enter += new System.EventHandler(this.txt_KAdi_Enter);
            this.txt_Sifre.Leave += new System.EventHandler(this.txt_KAdi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanici Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sifre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(139, 109);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(206, 29);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.Text = "Giris Yap";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // frm_KullaniciGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 153);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_KullaniciGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici Giris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KAdi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Giris;
    }
}

