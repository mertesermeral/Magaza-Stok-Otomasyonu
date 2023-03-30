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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OORND2B;Initial Catalog=Stok;Integrated Security=True");
        bool durum;
        private void markaengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text == read["tedarikci"].ToString() && textBox1.Text == read["marka"].ToString() || textBox1.Text == "" || comboBox1.Text == "")
                {
                    durum = false;
                }

            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            markaengelle();
            if (durum == true) {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into markabilgileri(tedarikci,marka) values('" + comboBox1.Text + "','" + textBox1.Text + "')", baglanti);


                komut.ExecuteNonQuery();
                baglanti.Close();
                textBox1.Text = "";
                comboBox1.Text = "";
                MessageBox.Show("Marka Eklendi");
            }
            else
            {
                MessageBox.Show("Tekrar Deneyiniz");
            }

        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            tedarikcigetir();
        }

        private void tedarikcigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from tedarikcibilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["tedarikci"].ToString());
            }
            baglanti.Close();
        }
    }
}
