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
    public partial class AnaForm : Form
    {
        public AnaForm(kullanici _kullanici)
        {
            InitializeComponent();
            ekranGuncelleme(_kullanici);
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            kullanici guncellenecek = sanalDatabase.kullaniciTablo.Find(i => i.kullaniciAdi == txt_kullaniciAdi.Text);
            if (guncellenecek != null && txt_isim.Text != string.Empty && txt_soyisim.Text != string.Empty && txt_sifre.Text != string.Empty)
            {
                guncellenecek.isim = txt_isim.Text;
                guncellenecek.soyIsim = txt_soyisim.Text;
                guncellenecek.sifre = txt_sifre.Text;
                guncellenecek.aciklama = txt_aciklama.Text;

                sanalDatabase.kullaniciTablo[guncellenecek.id] = guncellenecek;

                MessageBox.Show("Bilgileriniz Guncellendi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }

        private void ekranGuncelleme(kullanici _kullanici)
        {
            txt_isim.Text = _kullanici.isim;
            txt_soyisim.Text = _kullanici.soyIsim;
            txt_kullaniciAdi.Text = _kullanici.kullaniciAdi;
            txt_sifre.Text = _kullanici.sifre;
            txt_aciklama.Text = _kullanici.aciklama;
        }
    }
}
