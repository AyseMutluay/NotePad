namespace NotDefteriUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNotAlani = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFarkliKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeriAl = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuKes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgAc = new System.Windows.Forms.OpenFileDialog();
            this.dlgKaydet = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNotAlani
            // 
            this.txtNotAlani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotAlani.Location = new System.Drawing.Point(0, 28);
            this.txtNotAlani.Multiline = true;
            this.txtNotAlani.Name = "txtNotAlani";
            this.txtNotAlani.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotAlani.Size = new System.Drawing.Size(800, 422);
            this.txtNotAlani.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYeni,
            this.menuAc,
            this.menuKaydet,
            this.menuFarkliKaydet,
            this.toolStripMenuItem1,
            this.menuCikis});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGeriAl,
            this.toolStripMenuItem2,
            this.menuKes,
            this.menuKopyala,
            this.menuYapistir,
            this.toolStripMenuItem3,
            this.tümünüSeçToolStripMenuItem});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // menuYeni
            // 
            this.menuYeni.Name = "menuYeni";
            this.menuYeni.Size = new System.Drawing.Size(224, 26);
            this.menuYeni.Text = "Yeni";
            this.menuYeni.Click += new System.EventHandler(this.menuYeni_Click);
            // 
            // menuAc
            // 
            this.menuAc.Name = "menuAc";
            this.menuAc.Size = new System.Drawing.Size(224, 26);
            this.menuAc.Text = "Aç";
            this.menuAc.Click += new System.EventHandler(this.menuAc_Click);
            // 
            // menuKaydet
            // 
            this.menuKaydet.Name = "menuKaydet";
            this.menuKaydet.Size = new System.Drawing.Size(224, 26);
            this.menuKaydet.Text = "Kaydet";
            this.menuKaydet.Click += new System.EventHandler(this.menuKaydet_Click);
            // 
            // menuFarkliKaydet
            // 
            this.menuFarkliKaydet.Name = "menuFarkliKaydet";
            this.menuFarkliKaydet.Size = new System.Drawing.Size(224, 26);
            this.menuFarkliKaydet.Text = "Farklı Kaydet";
            this.menuFarkliKaydet.Click += new System.EventHandler(this.menuFarkliKaydet_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.Size = new System.Drawing.Size(224, 26);
            this.menuCikis.Text = "Çıkış";
            this.menuCikis.Click += new System.EventHandler(this.menuCikis_Click);
            // 
            // menuGeriAl
            // 
            this.menuGeriAl.Name = "menuGeriAl";
            this.menuGeriAl.Size = new System.Drawing.Size(224, 26);
            this.menuGeriAl.Text = "Geri Al";
            this.menuGeriAl.Click += new System.EventHandler(this.menuGeriAl_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // menuKes
            // 
            this.menuKes.Name = "menuKes";
            this.menuKes.Size = new System.Drawing.Size(224, 26);
            this.menuKes.Text = "Kes";
            this.menuKes.Click += new System.EventHandler(this.menuKes_Click);
            // 
            // menuKopyala
            // 
            this.menuKopyala.Name = "menuKopyala";
            this.menuKopyala.Size = new System.Drawing.Size(224, 26);
            this.menuKopyala.Text = "Kopyala";
            this.menuKopyala.Click += new System.EventHandler(this.menuKopyala_Click);
            // 
            // menuYapistir
            // 
            this.menuYapistir.Name = "menuYapistir";
            this.menuYapistir.Size = new System.Drawing.Size(224, 26);
            this.menuYapistir.Text = "Yapıştır";
            this.menuYapistir.Click += new System.EventHandler(this.menuYapistir_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            this.tümünüSeçToolStripMenuItem.Click += new System.EventHandler(this.tümünüSeçToolStripMenuItem_Click);
            // 
            // dlgAc
            // 
            this.dlgAc.FileName = "openFileDialog1";
            // 
            // dlgKaydet
            // 
            this.dlgKaydet.DefaultExt = "txt";
            this.dlgKaydet.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            this.dlgKaydet.Title = "Metin dosyasını kaydet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNotAlani);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notlarım";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNotAlani;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuYeni;
        private System.Windows.Forms.ToolStripMenuItem menuAc;
        private System.Windows.Forms.ToolStripMenuItem menuKaydet;
        private System.Windows.Forms.ToolStripMenuItem menuFarkliKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuGeriAl;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuKes;
        private System.Windows.Forms.ToolStripMenuItem menuKopyala;
        private System.Windows.Forms.ToolStripMenuItem menuYapistir;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgAc;
        private System.Windows.Forms.SaveFileDialog dlgKaydet;
    }
}

