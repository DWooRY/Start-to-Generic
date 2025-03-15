namespace WindowsFormsMessageBoxs
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
            this.btn_Mesaj1 = new System.Windows.Forms.Button();
            this.btn_SoruSor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Mesaj1
            // 
            this.btn_Mesaj1.Location = new System.Drawing.Point(31, 37);
            this.btn_Mesaj1.Name = "btn_Mesaj1";
            this.btn_Mesaj1.Size = new System.Drawing.Size(115, 45);
            this.btn_Mesaj1.TabIndex = 0;
            this.btn_Mesaj1.Text = "Mesaj Goster";
            this.btn_Mesaj1.UseVisualStyleBackColor = true;
            this.btn_Mesaj1.Click += new System.EventHandler(this.btn_Mesaj1_Click);
            // 
            // btn_SoruSor
            // 
            this.btn_SoruSor.Location = new System.Drawing.Point(152, 37);
            this.btn_SoruSor.Name = "btn_SoruSor";
            this.btn_SoruSor.Size = new System.Drawing.Size(115, 45);
            this.btn_SoruSor.TabIndex = 0;
            this.btn_SoruSor.Text = "Soru Sor";
            this.btn_SoruSor.UseVisualStyleBackColor = true;
            this.btn_SoruSor.Click += new System.EventHandler(this.btn_SoruSor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SoruSor);
            this.Controls.Add(this.btn_Mesaj1);
            this.Name = "Form1";
            this.Text = "Message Box Inceleme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Mesaj1;
        private System.Windows.Forms.Button btn_SoruSor;
    }
}

