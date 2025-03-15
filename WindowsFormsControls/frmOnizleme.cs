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
    public partial class frmOnizleme : Form
    {
        public frmOnizleme()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            
            foreach (Form item in Application.OpenForms)
            {
                if (item.Name == "Form1")
                {
                    foreach (Control formItem in item.Controls)
                    {
                        if (formItem is TextBox)
                        {
                            ((TextBox)formItem).Text = string.Empty;
                        }

                    }
                }
            }
            this.Close();
        }
    }
}
