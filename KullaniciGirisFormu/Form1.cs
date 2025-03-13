using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisFormu
{
    public partial class frm_KullaniciGirisEkrani : Form
    {
        public frm_KullaniciGirisEkrani()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_KAdi.Text;
            string sifre = txt_Sifre.Text;

            kullanici bulunanKullanici = sanalDatabase.kullaniciTablo.Find(i => i.kullaniciAdi == kullaniciAdi && i.sifre == sifre);

            if (bulunanKullanici != null)
            {
                AnaForm _anaForm = new AnaForm(bulunanKullanici);
                _anaForm.Show();
            }
            else
            {
                MessageBox.Show("Hatali Kullanici Bilgileri", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_KAdi_Enter(object sender, EventArgs e)
        {
            TextBox TB1 = (TextBox)sender;
            TB1.BackColor = Color.Gray;
        }
        private void txt_KAdi_Leave(object sender, EventArgs e)
        {
            TextBox TB1 = (TextBox)sender;
            TB1.BackColor = Color.White;
        }
    }
}
