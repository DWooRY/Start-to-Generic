namespace WindowsFormGiris
{
    partial class Form2
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
            this.txt_Mesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Mesaj
            // 
            this.txt_Mesaj.AutoSize = true;
            this.txt_Mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Mesaj.Location = new System.Drawing.Point(218, 133);
            this.txt_Mesaj.Name = "txt_Mesaj";
            this.txt_Mesaj.Size = new System.Drawing.Size(188, 39);
            this.txt_Mesaj.TabIndex = 1;
            this.txt_Mesaj.Text = "Ikinci Form";
            this.txt_Mesaj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 330);
            this.Controls.Add(this.txt_Mesaj);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_Mesaj;
    }
}