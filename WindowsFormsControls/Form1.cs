using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Form uzerindeki alanlari temizlemek istediginize emin misiniz?", "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes)
            {
                FormTemizle();
            }
        
        }

        private void FormTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }

            }

            //Foreach olmadan silmek istedigimiz yeri silmek icin:
            //((TextBox)this.Controls["txt_isim"]).Text = string.Empty;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            sanalDatabase.Musterilers.Add(new Musteriler()
            {
                isim = txt_isim.Text,
                soyisim = txt_soyisim.Text,
                email = txt_email.Text,
                telefon = txt_telefon.Text
            });
            MessageBox.Show("Kayit Basarili", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Onizleme_Click(object sender, EventArgs e)
        {
            frmOnizleme onizleme = new frmOnizleme();
            ((TextBox)onizleme.Controls["txt_isim"]).Text = txt_isim.Text;
            ((TextBox)onizleme.Controls["txt_soyisim"]).Text = txt_soyisim.Text;
            ((TextBox)onizleme.Controls["txt_email"]).Text = txt_email.Text;
            ((TextBox)onizleme.Controls["txt_telefon"]).Text = txt_telefon.Text;
            onizleme.ShowDialog();
        }
    }
}
