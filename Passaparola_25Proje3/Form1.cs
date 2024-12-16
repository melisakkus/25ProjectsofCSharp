using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_25Proje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e) //Keydown
        {
            if(e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    case 1:
                        if((textBox1.Text).ToLower() == "atmosfer")
                        {
                            btnA.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text)+1).ToString();
                        }
                        else
                        {
                            btnA.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 2:
                        if ((textBox1.Text).ToLower() == "beyran")
                        {
                            btnB.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnB.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 3:
                        if ((textBox1.Text).ToLower() == "ceviz")
                        {
                            btnC.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnC.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 4:
                        if ((textBox1.Text).ToLower() == "denizli")
                        {
                            btnD.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnD.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 5:
                        if ((textBox1.Text).ToLower() == "eski")
                        {
                            btnE.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnE.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 6:
                        if ((textBox1.Text).ToLower() == "ferman")
                        {
                            btnF.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnF.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 7:
                        if ((textBox1.Text).ToLower() == "güneş")
                        {
                            btnG.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnG.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 8:
                        if ((textBox1.Text).ToLower() == "hera")
                        {
                            btnH.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnH.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 9:
                        if ((textBox1.Text).ToLower() == "ığdır")
                        {
                            btnI.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnI.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 10:
                        if ((textBox1.Text).ToLower() == "içel")
                        {
                            btnİ.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnİ.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 11:
                        if ((textBox1.Text).ToLower() == "jandarma")
                        {
                            btnJ.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnJ.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 12:
                        if ((textBox1.Text).ToLower() == "kayısı")
                        {
                            btnK.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnK.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 13:
                        if ((textBox1.Text).ToLower() == "lale festivali")
                        {
                            btnL.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnL.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 14:
                        if ((textBox1.Text).ToLower() == "martı")
                        {
                            btnM.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnM.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 15:
                        if ((textBox1.Text).ToLower() == "nevşehir")
                        {
                            btnN.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnN.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 16:
                        if ((textBox1.Text).ToLower() == "ozan")
                        {
                            btnO.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnO.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 17:
                        if ((textBox1.Text).ToLower() == "pizza")
                        {
                            btnP.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnP.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 18:
                        if ((textBox1.Text).ToLower() == "ramazan")
                        {
                            btnR.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnR.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 19:
                        if ((textBox1.Text).ToLower() == "sismograf")
                        {
                            btnS.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnS.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 20:
                        if ((textBox1.Text).ToLower() == "türkçe")
                        {
                            btnT.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnT.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 21:
                        if ((textBox1.Text).ToLower() == "uludağ")
                        {
                            btnU.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnU.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 22:
                        if ((textBox1.Text).ToLower() == "van")
                        {
                            btnV.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnV.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 23:
                        if ((textBox1.Text).ToLower() == "yıldırım")
                        {
                            btnY.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnY.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;

                    case 24:
                        if ((textBox1.Text).ToLower() == "zeytin")
                        {
                            btnZ.BackColor = Color.Green;
                            lblDogru.Text = (int.Parse(lblDogru.Text) + 1).ToString();
                        }
                        else
                        {
                            btnZ.BackColor = Color.Red;
                            lblYanlis.Text = (int.Parse(lblYanlis.Text) + 1).ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.Text = "Sonraki";
            soruNo++;
            LblSoruNo.Text = soruNo.ToString();

            if(soruNo == 1)
            {
                richTextBox1.Text = "Yeryüzünü saran hava tabakası?";
                btnA.BackColor = Color.Yellow;
            }

            if (soruNo == 2)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Gaziantep yöresinde yapılan çorba?";
                btnB.BackColor = Color.Yellow;
            }

            if (soruNo == 3)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Şekli beyne benzeyen besin?";
                btnC.BackColor = Color.Yellow;
            }

            if (soruNo == 4)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Pamukkale Travertenler'i ile meşhur ilimiz?";
                btnD.BackColor = Color.Yellow;
            }

            if (soruNo == 5)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                btnE.BackColor = Color.Yellow;
            }

            if (soruNo == 6)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                btnF.BackColor = Color.Yellow;
            }

            if (soruNo == 7)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                btnG.BackColor = Color.Yellow;
            }

            if (soruNo == 8)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Yunan mitolojisinde Zeus’un eşi olan tanrıça?";
                btnH.BackColor = Color.Yellow;
            }

            if (soruNo == 9)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Gülü ile ünlü ilimiz?";
                btnI.BackColor = Color.Yellow;
            }

            if (soruNo == 10)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Mersinin diğer ismi?";
                btnİ.BackColor = Color.Yellow;
            }

            if (soruNo == 11)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Askeri bir topluluk?";
                btnJ.BackColor = Color.Yellow;
            }

            if (soruNo == 12)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Malatya'nın meşhur meyvesi?";
                btnK.BackColor = Color.Yellow;
            }

            if (soruNo == 13)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Bahar mevisiminde İstanbul'daki parklarda ve korularda yapılan festival?";
                btnL.BackColor = Color.Yellow;
            }

            if (soruNo == 14)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Kıyı bölgelerinde yaşayan bir tür kuş?";
                btnM.BackColor = Color.Yellow;
            }

            if (soruNo == 15)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Türkiye’de yer alan, Kapadokya bölgesindeki ünlü peribacalarıyla tanınan şehir?";
                btnN.BackColor = Color.Yellow;
            }

            if (soruNo == 16)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Halk şairine verilen isim?";
                btnO.BackColor = Color.Yellow;
            }

            if (soruNo == 17)
            {
                textBox1.Text = "";
                richTextBox1.Text = "İtalyanca kökenli, fırında yapılan ince hamurlu bir yiyecek?";
                btnP.BackColor = Color.Yellow;
            }

            if (soruNo == 18)
            {
                textBox1.Text = "";
                richTextBox1.Text = "11 ayın sultanı?";
                btnR.BackColor = Color.Yellow;
            }

            if (soruNo == 19)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Depremlerin ölçüldüğü aletin adı nedir?";
                btnS.BackColor = Color.Yellow;
            }

            if (soruNo == 20)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Türkiye’nin resmi dili nedir?";
                btnT.BackColor = Color.Yellow;
            }

            if (soruNo == 21)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Marmara Bölgesinin en yüksek dağı?";
                btnU.BackColor = Color.Yellow;
            }

            if (soruNo == 22)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Renkli gözlü kedileri ile ünlü ilimiz?";
                btnV.BackColor = Color.Yellow;
            }

            if (soruNo == 23)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                btnY.BackColor = Color.Yellow;
            }

            if (soruNo == 24)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan ve yağı yapılan besini?";
                btnZ.BackColor = Color.Yellow;
            }

        }
    }
}

//this.Text //formun sol üst texti
