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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Form2Ac_Click(object sender, EventArgs e)
        { 

            Form2 form2 = new Form2(txt_Mesaj.Text);
            form2.Show();
        }

        private void txt_Mesaj_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.Text = string.Empty;
        }
    }
}
