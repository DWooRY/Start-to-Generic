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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            database db = new database();
            List<musteri> musteriListe = db.musteriListele();

            dgw_MusteriListe.DataSource = musteriListe;

            dgw_MusteriListe.Columns[0].HeaderText = "Musteri ID"; //satir basligi degistirme
            dgw_MusteriListe.Columns[1].HeaderText = "Isim";
            dgw_MusteriListe.Columns[2].HeaderText = "Soyisim";

            dgw_MusteriListe.Columns[4].Width = 200; // satir genisligi degistirme










            #region belli veriyi ekrana yazdirma

            // dgw_MusteriListe.DataSource = musteriListe; bu sekilde bir yazimda, liste icerisindeki tum degerleri ornegin id, mail, telefon bla bla
            // gridviewda goruntuleyebiliyoruz. 

            //Ama varsayalim ki biz ekranda sadece isim soyisim ve email gostermek istiyoruz. o zaman su sekilde bir kullanim yapilabilir:

            //var dgvListe = from I in musteriListe
            //               select new
            //               {
            //                   isim = I.isim,
            //                   soyisim = I.soyisim,
            //                   mail = I.emailAdres
            //               };
            //dgw_MusteriListe.DataSource = dgvListe.ToList();

            #endregion
        }

        private void dgw_MusteriListe_DoubleClick(object sender, EventArgs e)
        {
            int musteriID = (int)dgw_MusteriListe[0, dgw_MusteriListe.CurrentCell.RowIndex].Value;

            database db = new database();
            musteri blnMusteri = db.musteriListele().FindAll(i => i.id == musteriID).FirstOrDefault();

            popupMusteri popup = new popupMusteri(blnMusteri);
            popup.ShowDialog();

        }
    }
}
