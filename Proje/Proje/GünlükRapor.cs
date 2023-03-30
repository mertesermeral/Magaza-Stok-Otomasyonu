/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: PROJE
**				ÖĞRENCİ ADI............: MERT ESER MERAL
**				ÖĞRENCİ NUMARASI.......: G211210047
**              DERSİN ALINDIĞI GRUP...: 2-B
****************************************************************************/
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

namespace Proje
{
    public partial class GünlükRapor : Form
    {
        public GünlükRapor()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OORND2B;Initial Catalog=Stok;Integrated Security=True");
        DataSet daset = new DataSet();

        private void GünlükRapor_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from satis", baglanti);
            lblTopGelir.Text = komut.ExecuteScalar() + " TL";
            SqlCommand komut2 = new SqlCommand("select sum(alisfiyati*miktari) from urun", baglanti);
            
            lblSiparisGider.Text = komut2.ExecuteScalar()+" TL";
            
            lblGider.Text = int.Parse(txtMaas.Text) + int.Parse(txtYemek.Text) + int.Parse(txtFatura.Text) + " TL";

            baglanti.Close();
        }
    }
}
