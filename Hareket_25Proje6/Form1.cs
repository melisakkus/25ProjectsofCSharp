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

namespace Hareket_25Proje6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-B6FJQDJ\\SQLEXPRESS;Initial Catalog=DbHareket_25Proje.6;Integrated Security=True");

        public void Liste()
        {
            this.hareketTableAdapter.Fill(this._DbHareket_25Proje_6DataSet.Hareket);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Liste();

            connection.Open();
            SqlCommand urunler = new SqlCommand("Select * from Urunler",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(urunler);
            DataTable dataTable = new DataTable();            
            adapter.Fill(dataTable);
            cbxUrun.DisplayMember = "UrunAd";
            cbxUrun.ValueMember = "UrunId";

            DataRow newRow = dataTable.NewRow();
            newRow["UrunId"] = 0;
            newRow["UrunAd"] = "Seçiniz";
            dataTable.Rows.InsertAt(newRow, 0);

            cbxUrun.DataSource = dataTable;
            connection.Close();

            connection.Open();
            SqlCommand musteriler = new SqlCommand("Select * from Musteriler",connection);
            SqlDataAdapter adapter2 = new SqlDataAdapter(musteriler);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);
            cbxMusteri.DisplayMember = "AdSoyad";
            cbxMusteri.ValueMember = "MusteriId";

            DataRow newRow2 = dataTable2.NewRow();
            newRow2["MusteriId"] = 0;
            newRow2["AdSoyad"] = "Seçiniz";
            dataTable2.Rows.InsertAt(newRow2, 0);

            cbxMusteri.DataSource = dataTable2;
            connection.Close();

            connection.Open();
            SqlCommand komut3 = new SqlCommand("Select * from Personeller", connection);
            SqlDataAdapter dataAdapter3 = new SqlDataAdapter(komut3);
            DataTable dataTable3 = new DataTable();
            dataAdapter3.Fill(dataTable3);
            cbxSatici.ValueMember = "PersonelId";
            cbxSatici.DisplayMember= "PersonelAd";

            DataRow newRow3 = dataTable3.NewRow();
            newRow3["PersonelId"] = 0;
            newRow3["PersonelAd"] = "Seçiniz";
            dataTable3.Rows.InsertAt (newRow3, 0);
            cbxSatici.DataSource = dataTable3;
            connection.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand ekle = new SqlCommand("Insert into Hareketler (Urun,Musteri,Personel,Fİyat) values (@pUrun,@pMusteri,@pPersonel,@pFiyat)",connection);
            ekle.Parameters.AddWithValue("@pUrun",cbxUrun.SelectedValue);
            ekle.Parameters.AddWithValue("@pMusteri",cbxMusteri.SelectedValue);
            ekle.Parameters.AddWithValue("@pPersonel",cbxSatici.SelectedValue);
            ekle.Parameters.AddWithValue("@pFiyat",tbxFiyat.Text);
            ekle.ExecuteNonQuery();
            connection.Close();
            Liste();
            MessageBox.Show("Satış başarıyla eklenmiştir.","Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
