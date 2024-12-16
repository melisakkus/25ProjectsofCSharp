using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;


namespace DovizOfisi_25Proje4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDosya = new XmlDocument();
            xmlDosya.Load(bugun);

            string dolarAlis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod ='USD']/BanknoteBuying").InnerXml;
            lblDolarAlis.Text = dolarAlis;


            string dolarSatis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod = 'USD']/BanknoteSelling").InnerXml;
            lblDolarSatis.Text = dolarSatis;

            string euroAlis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroAlis.Text = euroAlis;

            string euroSatis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSatis.Text = euroSatis;
            //var bütün değşkenleri üzerine alan değişken
        }

        private void btnDolarAlis_Click(object sender, EventArgs e)
        {
            tbxKur.Text = lblDolarAlis.Text;
        }

        private void btnDolarSatis_Click(object sender, EventArgs e)
        {
            tbxKur.Text = lblDolarSatis.Text;
        }

        private void btnEuroAlis_Click(object sender, EventArgs e)
        {
            tbxKur.Text = lblEuroAlis.Text;
        }

        private void btnEuroSatis_Click(object sender, EventArgs e)
        {
            tbxKur.Text = lblEuroSatis.Text;
        }

        private void tbxSatisYap_Click(object sender, EventArgs e)
        {
            double miktar = Convert.ToDouble(tbxMiktar.Text);
            double kur = Convert.ToDouble(tbxKur.Text);
            double tutar = miktar * kur;
            tbxTutar.Text = tutar.ToString();
        }

        private void tbxKur_TextChanged(object sender, EventArgs e)
        {
            tbxKur.Text = tbxKur.Text.Replace(".",",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(tbxKur.Text);
            int tutar = Convert.ToInt32(tbxTutar.Text);
            int miktar = Convert.ToInt32(tutar / kur);
            tbxMiktar.Text = miktar.ToString();
            double kalan;
            kalan = miktar % kur;
            tbxKalan.Text = kalan.ToString();
        }
    }
}

//.InnerXml, bir XML düğümünün (node) içeriğini, yani tüm alt düğümlerini ve metin verisini XML formatında bir string olarak döndürü