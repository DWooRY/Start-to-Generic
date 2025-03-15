namespace WindowsFormsControls
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
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.labe1 = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Onizleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(82, 37);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(162, 20);
            this.txt_isim.TabIndex = 0;
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Location = new System.Drawing.Point(12, 40);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(25, 13);
            this.labe1.TabIndex = 1;
            this.labe1.Text = "Isim";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(82, 149);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(72, 33);
            this.btn_temizle.TabIndex = 4;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(160, 149);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(84, 33);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(82, 63);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(162, 20);
            this.txt_soyisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(82, 89);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(162, 20);
            this.txt_email.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email Adres";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(82, 115);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(162, 20);
            this.txt_telefon.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefon Num";
            // 
            // btn_Onizleme
            // 
            this.btn_Onizleme.Location = new System.Drawing.Point(82, 187);
            this.btn_Onizleme.Name = "btn_Onizleme";
            this.btn_Onizleme.Size = new System.Drawing.Size(162, 39);
            this.btn_Onizleme.TabIndex = 6;
            this.btn_Onizleme.Text = "Kayit Onizleme";
            this.btn_Onizleme.UseVisualStyleBackColor = true;
            this.btn_Onizleme.Click += new System.EventHandler(this.btn_Onizleme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 238);
            this.Controls.Add(this.btn_Onizleme);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labe1);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_isim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri Uygulamasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Onizleme;
    }
}

