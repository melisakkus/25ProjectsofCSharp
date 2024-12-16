using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CefSharp;
using CefSharp.WinForms;
using static System.Windows.Forms.LinkLabel;

namespace FilmArsivi_25Proje5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-B6FJQDJ\\SQLEXPRESS;Initial Catalog=DbFilmArsivi_25Proje.5;Integrated Security=True");

        void Listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select FilmAd as 'Film Adı',FilmKategori as 'Kategori',FilmLink as 'Link' from Tbl_Filmler", baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Georgia", 9, FontStyle.Regular);
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutEkle = new SqlCommand("Insert into Tbl_Filmler (FilmAd,FilmKategori,FilmLink) values (@pAd,@pKategori,@pLink)",baglanti);
            komutEkle.Parameters.AddWithValue("@pAd",tbxFilmAdi.Text);
            komutEkle.Parameters.AddWithValue("@pKategori",tbxKategori.Text);
            komutEkle.Parameters.AddWithValue("@pLink",tbxLink.Text);
            komutEkle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni film başarıyla eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link1 = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            if (!string.IsNullOrEmpty(link1))
            {
                // Yeni ChromiumWebBrowser nesnesini oluştur
                ChromiumWebBrowser chromiumWebBrowser = new ChromiumWebBrowser(link1)
                {
                    Dock = DockStyle.Fill
                };

                // Önceki kontrolleri temizle
                this.groupBox2.Controls.Clear();
                this.groupBox2.Controls.Add(chromiumWebBrowser);

                // Sayfayı yükle
                chromiumWebBrowser.Load(link1);
            }
            else
            {
                MessageBox.Show("Geçersiz bağlantı.");
            }
        }


        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Melisa Akkuş tarafından 29 Ekim 2024 tarihinde kodlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            string[] renkler = new string[] { "#e17055", "#a29bfe", "#636e72", "#474787", "#b33939", "#6D214F", "#BDC581" };
            //Random sınıfı ile rastgele bir indeks seç
            Random random = new Random();
            int randomIndex = random.Next(renkler.Length);
            //Rastgele deçilen elemanı al
            string randomRenk = renkler[randomIndex];
            BackColor = ColorTranslator.FromHtml(randomRenk);
        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
            Frm_TamEkran formTamEkran = new Frm_TamEkran();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link1 = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            formTamEkran.link = link1;
            formTamEkran.Show();
        }
    }
}
