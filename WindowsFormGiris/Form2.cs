using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGiris
{
    public partial class Form2: Form
    {
        public Form2(string metin)
        {
            InitializeComponent();
            txt_Mesaj.Text = metin;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
