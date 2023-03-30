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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OORND2B;Initial Catalog=Stok;Integrated Security=True");
        bool durum;
        private void kodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtKod.Text==read["urunkodu"].ToString() || txtKod.Text=="")
                {
                    durum = false;
                }

            }
            baglanti.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where tedarikci='"+comboTedarikci.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void tedarikcigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from tedarikcibilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboTedarikci.Items.Add(read["tedarikci"].ToString());
            }
            baglanti.Close();
        }
        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            tedarikcigetir();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            kodkontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun(urunkodu,tedarikci,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values(@urunkodu,@tedarikci,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@urunkodu", txtKod.Text);
                komut.Parameters.AddWithValue("@tedarikci", comboTedarikci.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAdi.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlis.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatis.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi");

            }
            else
            {
                MessageBox.Show("Geçersiz/kullanılmış ürün kodu.");
            }
            comboMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtKod2_TextChanged(object sender, EventArgs e)
        {
            if (txtKod2.Text == "")
            {
                lblStokSayisi.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = "";
                    }




                }
            }
            baglanti.Open();
            SqlCommand komut=new SqlCommand("select *from urun where urunkodu like '"+txtKod2.Text+"'",baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                txtTedarikci2.Text = read["tedarikci"].ToString();
                txtMarka2.Text = read["marka"].ToString();
                txtÜrünAdi2.Text = read["urunadi"].ToString();
                lblStokSayisi.Text = read["miktari"].ToString();
                txtAlis2.Text = read["alisfiyati"].ToString();
                txtSatis2.Text = read["satisfiyati"].ToString();

            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'"+int.Parse(txtMiktar2.Text)+"' where urunkodu='"+txtKod2.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }




            }
            MessageBox.Show("Ekleme Başarılı");
        }
    }
}
