using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxUygulama
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            int islemSonuc = yeniMusteriEkle(new Musteri
            {
                id = Guid.NewGuid(),
                isim = txt_isim.Text,
                soyisim = txt_soyisim.Text,
                emailAdres = txt_emailAdres.Text,
                telefonNumarasi = txt_telefonNumarasi.Text
            });

            if (islemSonuc > 0 )
            {
                DialogResult result = MessageBox.Show("Musteri ekleme islemi basarili. Yeni musteri kaydi eklemek ister misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ntf_bildirimCubugu = new NotifyIcon();
                    ntf_bildirimCubugu.BalloonTipText = "Toplam musteri sayisi = " + sanalDatabase.musteriler.Count.ToString();
                    ntf_bildirimCubugu.BalloonTipTitle = "Musteri adet bilgisi.";
                    ntf_bildirimCubugu.Visible = true;
                    ntf_bildirimCubugu.Icon = SystemIcons.Information;
                    ntf_bildirimCubugu.ShowBalloonTip(2000);
                
                }
                if (result == DialogResult.No)
                {

                }

                EkranTemizle();
                EkranListele();

            }
            else
            {
                MessageBox.Show("Musteri ekleme islemi basarisiz","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }


        private void EkranListele()
        {
            lst_musteriler.Items.Clear();
            for (int i = 0; i < sanalDatabase.musteriler.Count; i++)
            {
                string dataIsim = sanalDatabase.musteriler[i].isim;
                lst_musteriler.Items.Add(sanalDatabase.musteriler.Find(x => x.isim == dataIsim).ToString());
            }
            
        }


        private void EkranTemizle()
        {
            txt_isim.Text = string.Empty;
            txt_soyisim.Text = string.Empty;
            txt_emailAdres.Text = string.Empty;
            txt_telefonNumarasi.Text = string.Empty;
        }

        private int yeniMusteriEkle(Musteri data)
        {
            sanalDatabase.musteriler.Add(data);
            return 1;
        }
    }
}
