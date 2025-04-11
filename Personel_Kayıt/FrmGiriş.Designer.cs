namespace Personel_Kayıt
{
    partial class FrmGiriş
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKullanıcıAd = new System.Windows.Forms.TextBox();
            this.textBoxŞifre = new System.Windows.Forms.TextBox();
            this.buttonGiriş = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // textBoxKullanıcıAd
            // 
            this.textBoxKullanıcıAd.Location = new System.Drawing.Point(329, 151);
            this.textBoxKullanıcıAd.Name = "textBoxKullanıcıAd";
            this.textBoxKullanıcıAd.Size = new System.Drawing.Size(100, 34);
            this.textBoxKullanıcıAd.TabIndex = 2;
            // 
            // textBoxŞifre
            // 
            this.textBoxŞifre.Location = new System.Drawing.Point(329, 201);
            this.textBoxŞifre.Name = "textBoxŞifre";
            this.textBoxŞifre.Size = new System.Drawing.Size(100, 34);
            this.textBoxŞifre.TabIndex = 3;
            this.textBoxŞifre.UseSystemPasswordChar = true;
            // 
            // buttonGiriş
            // 
            this.buttonGiriş.Location = new System.Drawing.Point(184, 266);
            this.buttonGiriş.Name = "buttonGiriş";
            this.buttonGiriş.Size = new System.Drawing.Size(245, 47);
            this.buttonGiriş.TabIndex = 4;
            this.buttonGiriş.Text = "Giriş yap";
            this.buttonGiriş.UseVisualStyleBackColor = true;
            this.buttonGiriş.Click += new System.EventHandler(this.buttonGiriş_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personel Takip Sistemi Giriş Paneli";
            // 
            // FrmGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(646, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGiriş);
            this.Controls.Add(this.textBoxŞifre);
            this.Controls.Add(this.textBoxKullanıcıAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmGiriş";
            this.Text = "FrmGiriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKullanıcıAd;
        private System.Windows.Forms.TextBox textBoxŞifre;
        private System.Windows.Forms.Button buttonGiriş;
        private System.Windows.Forms.Label label3;
    }
}