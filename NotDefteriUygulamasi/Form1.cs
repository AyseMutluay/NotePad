using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteriUygulamasi
{
    public partial class Form1 : Form
    {
        private string mevcutDosyaYolu = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void menuFarkliKaydet_Click(object sender, EventArgs e)
        {
            if (dlgKaydet.ShowDialog() == DialogResult.OK)
            {
                // Eğer kullanıcı "Kaydet"e bastıysa, seçtiği dosyanın yolunu alıp
                // metin kutusundaki (txtNotAlani) tüm yazıyı o dosyaya yazıyoruz.
                System.IO.File.WriteAllText(dlgKaydet.FileName, txtNotAlani.Text);

                mevcutDosyaYolu = dlgKaydet.FileName;
            }
        }

        private void menuAc_Click(object sender, EventArgs e)
        {
            if (dlgAc.ShowDialog() == DialogResult.OK)
            {
                txtNotAlani.Text = System.IO.File.ReadAllText(dlgAc.FileName);
                // YENİ EKLENEN SATIR:
                mevcutDosyaYolu = dlgAc.FileName;
            }
        }

        private void menuKaydet_Click(object sender, EventArgs e)
        {
            // Eğer daha önce bir dosya açılmadıysa veya "yeni" bir belgeyse
            if (string.IsNullOrEmpty(mevcutDosyaYolu))
            {
                // "Farklı Kaydet" ile aynı işlemi yap.
                // Bunun için doğrudan o menünün click olayını tetikleyebiliriz.
                menuFarkliKaydet_Click(sender, e);
            }
            else
            {
                // Eğer zaten çalıştığımız bir dosya varsa, direkt üzerine yaz.
                System.IO.File.WriteAllText(mevcutDosyaYolu, txtNotAlani.Text);
            }
        }

        private void menuYeni_Click(object sender, EventArgs e)
        {
            // Metin kutusunu temizle.
            txtNotAlani.Clear();

            // Yeni bir dosya olduğu için mevcut dosya yolunu sıfırla.
            // Bu sayede "Kaydet" tıklandığında "Farklı Kaydet" çalışır.
            mevcutDosyaYolu = "";
        }

        private void menuCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuGeriAl_Click(object sender, EventArgs e)
        {
            txtNotAlani.Undo();
        }

        private void menuKes_Click(object sender, EventArgs e)
        {
            txtNotAlani.Cut();
        }

        private void menuKopyala_Click(object sender, EventArgs e)
        {
            txtNotAlani.Copy();
        }

        private void menuYapistir_Click(object sender, EventArgs e)
        {
            txtNotAlani.Paste();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNotAlani.SelectAll();
        }
    }
}
