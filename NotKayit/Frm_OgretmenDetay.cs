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

namespace NotKayit
{
    public partial class Frm_OgretmenDetay : Form
    {
        public Frm_OgretmenDetay()
        {
            InitializeComponent();
        }

        private void Frm_OgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.Tbl_Ders' table. You can move, or remove it, as needed.
            this.tbl_DersTableAdapter.Fill(this.dbNotKayitDataSet.Tbl_Ders);
            GecenKalanGuncelle();
        }

        public void GecenKalanGuncelle()
        {
            baglanti.Open();
            SqlCommand komutGecen = new SqlCommand("Select Count(*) from Tbl_Ders where Durum = 'True'", baglanti);
            SqlDataReader dataReader = komutGecen.ExecuteReader();
            while (dataReader.Read())
            {
                tbxGecen.Text = dataReader[0].ToString();
            }
            dataReader.Close();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutKalan = new SqlCommand("Select Count(*) from Tbl_Ders where Durum = 'False'", baglanti);
            SqlDataReader dataReader2 = komutKalan.ExecuteReader();
            while (dataReader2.Read())
            {
                tbxKalan.Text = dataReader2[0].ToString();
            }
            dataReader2.Close();
            baglanti.Close();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-B6FJQDJ\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutEkle = new SqlCommand("Insert into Tbl_Ders (OgrenciNumara,OgrenciAd,OgrenciSoyad) values (@pNumara,@pAd,@pSoyad)", baglanti);
            komutEkle.Parameters.AddWithValue("@pNumara", mtbxNumara.Text);
            komutEkle.Parameters.AddWithValue("@pAd", tbxAd.Text);
            komutEkle.Parameters.AddWithValue("@pSoyad", tbxSoyad.Text);
            komutEkle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme işlemi başarıyla tamamlanmıştır.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.tbl_DersTableAdapter.Fill(this.dbNotKayitDataSet.Tbl_Ders);
            GecenKalanGuncelle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama, sinav1, sinav2, sinav3;
            string durum;
            sinav1 = Convert.ToDouble(tbxSinav1.Text);
            sinav2 = Convert.ToDouble(tbxSinav2.Text);
            sinav3 = Convert.ToDouble(tbxSinav3.Text);
            ortalama = (sinav1+sinav2+sinav3) / 3;
            tbxOrtalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Ders set Sinav1=@psinav1, Sinav2 = @pSinav2, Sinav3 = @pSinav3 , Ortalama = @pOrtalama, Durum = @pDurum where OgrenciNumara = @pNumara",baglanti);
            komutGuncelle.Parameters.AddWithValue("@psinav1",Convert.ToInt16(tbxSinav1.Text));
            komutGuncelle.Parameters.AddWithValue("@pSinav2", Convert.ToInt16(tbxSinav2.Text));
            komutGuncelle.Parameters.AddWithValue("@pSinav3", Convert.ToInt16(tbxSinav3.Text));
            komutGuncelle.Parameters.AddWithValue("@pOrtalama", Convert.ToDecimal(tbxOrtalama.Text));
            komutGuncelle.Parameters.AddWithValue("@pDurum", durum);
            komutGuncelle.Parameters.AddWithValue("@pNumara",mtbxNumara.Text);
            komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi başarıyla tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tbl_DersTableAdapter.Fill(this.dbNotKayitDataSet.Tbl_Ders);
            GecenKalanGuncelle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbxId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            mtbxNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbxAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tbxSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tbxSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tbxSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            tbxSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
    }
}
