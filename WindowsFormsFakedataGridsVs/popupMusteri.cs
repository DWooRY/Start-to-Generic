using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFakedataGridsVs
{
    public partial class popupMusteri: Form
    {
        musteri musteriData;
        public popupMusteri(musteri data)
        {
            InitializeComponent();
            musteriData = data;
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void popupMusteri_Load(object sender, EventArgs e)
        {
            txt_isim.Text = musteriData.isim;
            txt_soyisim.Text = musteriData.soyisim;
            txt_tamisim.Text = musteriData.tamAdi;
            txt_email.Text = musteriData.emailAdres;
            txt_telefon.Text = musteriData.telefonNumara;
            txt_adres.Text = musteriData.adres;

        }
    }
}
