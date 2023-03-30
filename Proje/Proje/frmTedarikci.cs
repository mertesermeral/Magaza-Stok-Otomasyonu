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
    public partial class frmTedarikci : Form
    {
        public frmTedarikci()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-OORND2B;Initial Catalog=Stok;Integrated Security=True");
        bool durum;
        private void tedarikciengelle()
        {
            durum=true;
            baglanti.Open();
            SqlCommand komut=new SqlCommand("select *from tedarikcibilgileri",baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                if(textBox1.Text==read["tedarikci"].ToString() || textBox1.Text == "")
                {
                    durum = false;
                }

            }
            baglanti.Close();
        }
        private void frmTedarikci_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tedarikciengelle();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tedarikcibilgileri(tedarikci) values('" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();  
                MessageBox.Show("Tedarikçi Eklendi");
            }
            else
            {
                MessageBox.Show("Lütfen boş isim veya önceden kullanılmış isim girmeyin.");
            }
            textBox1.Text = "";
        }
    }
}
