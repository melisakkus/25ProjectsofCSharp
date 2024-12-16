using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;


namespace FilmArsivi_25Proje5
{
    public partial class Frm_TamEkran : Form
    {
        public Frm_TamEkran()
        {
            InitializeComponent();
        }

        public string link;
        private void Frm_TamEkran_Load(object sender, EventArgs e)
        {
            //chromiumWebBrowser = new ChromiumWebBrowser(link);
            //chromiumWebBrowser.Dock = DockStyle.Fill; // Tüm formu kaplaması için
            //this.Controls.Add(chromiumWebBrowser);

            if (!string.IsNullOrEmpty(link))
            {
                // Yeni ChromiumWebBrowser nesnesini oluştur
                ChromiumWebBrowser chromiumWebBrowser = new ChromiumWebBrowser(link)
                {
                    Dock = DockStyle.Fill
                };

                // Önceki kontrolleri temizle
                this.Controls.Clear();
                this.Controls.Add(chromiumWebBrowser);

                // Sayfayı yükle
                chromiumWebBrowser.Load(link);
            }
            else
            {
                MessageBox.Show("Geçersiz bağlantı.");
            }
        }
    }
}
