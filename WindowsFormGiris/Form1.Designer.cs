namespace WindowsFormGiris
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Form2Ac = new System.Windows.Forms.Button();
            this.txt_Mesaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Form2Ac
            // 
            this.btn_Form2Ac.Location = new System.Drawing.Point(12, 92);
            this.btn_Form2Ac.Name = "btn_Form2Ac";
            this.btn_Form2Ac.Size = new System.Drawing.Size(239, 61);
            this.btn_Form2Ac.TabIndex = 0;
            this.btn_Form2Ac.Text = "Form 2\'ye git";
            this.btn_Form2Ac.UseVisualStyleBackColor = true;
            this.btn_Form2Ac.Click += new System.EventHandler(this.btn_Form2Ac_Click);
            // 
            // txt_Mesaj
            // 
            this.txt_Mesaj.Location = new System.Drawing.Point(12, 66);
            this.txt_Mesaj.Name = "txt_Mesaj";
            this.txt_Mesaj.Size = new System.Drawing.Size(239, 20);
            this.txt_Mesaj.TabIndex = 1;
            this.txt_Mesaj.Text = "Bir yazi giriniz.";
            this.txt_Mesaj.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Mesaj_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ikinci Form uzerinde yazmasini istediniz metni girin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Mesaj);
            this.Controls.Add(this.btn_Form2Ac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Form2Ac;
        private System.Windows.Forms.TextBox txt_Mesaj;
        private System.Windows.Forms.Label label1;
    }
}

