using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMessageBoxs
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mesaj1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullaniciya gostermek istedigimiz bilgi","Baslik", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_SoruSor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yeniden denemek ister misiniz?", "Soru", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
            else if (result == DialogResult.No)
            {
            }
            else if (result == DialogResult.Cancel)
            {
                 
            }
        }
    }
}
