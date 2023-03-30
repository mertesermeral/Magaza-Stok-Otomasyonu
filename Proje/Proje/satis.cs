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
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OORND2B;Initial Catalog=Stok;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet",baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();
        }
        private void hesapla()
        {
            try{
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet", baglanti);
                lblTop.Text = komut.ExecuteScalar() + " TL";
                baglanti.Close();
            }
            catch(Exception)
            {

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sepetListele();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMüsteriListele listele=new FrmMüsteriListele();
            listele.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where no='"+dataGridView1.CurrentRow.Cells["no"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Sepetten Çıkarıldı.");
            daset.Tables["sepet"].Clear();
            sepetListele();
            hesapla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMüsteriEkle ekle=new frmMüsteriEkle();
            ekle.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmUrunEkle ekle= new frmUrunEkle();
            ekle.ShowDialog();

        }

        private void btnTedarikci_Click(object sender, EventArgs e)
        {
            frmTedarikciSayfasi tedarikci = new frmTedarikciSayfasi();
            tedarikci.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ÜrünListele listele = new ÜrünListele();
            listele.ShowDialog();

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if(txtTc.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTel.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from müsteri where tc like '"+txtTc.Text+"'",baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTel.Text = read["tel"].ToString();


            }
            baglanti.Close();
        }

        private void txtKod_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where urunkodu like '" + txtKod.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                TxtÜrünAdi.Text = read["urunadi"].ToString();
                txtSatis.Text = read["satisfiyati"].ToString();


            }
            baglanti.Close();

        }

        private void Temizle()
        {
            if (txtKod.Text == "")
            {
                foreach (Control item in groupBox4.Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                }
            }
        }
        bool durum;
        private void kodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet",baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                if(txtNo.Text == read["no"].ToString() )
                {
                    durum=false;
                }

            }
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            kodkontrol();
            baglanti.Open();
            SqlCommand komutx = new SqlCommand("select miktari from urun", baglanti);
            SqlDataReader reader=komutx.ExecuteReader();
            reader.Read();
            if (int.Parse(txtMiktar.Text) > int.Parse(reader["miktari"].ToString()))
            {
                MessageBox.Show("Yetersiz Stok.");
                baglanti.Close();

            }
            else
            {
                baglanti.Close();
                if (durum == true)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into sepet(no,tc,adsoyad,tel,urunkodu,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@no,@tc,@adsoyad,@tel,@urunkodu,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                    komut.Parameters.AddWithValue("@no", txtNo.Text);
                    komut.Parameters.AddWithValue("@tc", txtTc.Text);
                    komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@tel", txtTel.Text);
                    komut.Parameters.AddWithValue("@urunkodu", txtKod.Text);
                    komut.Parameters.AddWithValue("@urunadi", TxtÜrünAdi.Text);
                    komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktar.Text));
                    komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatis.Text));
                    komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplam.Text));
                    komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("update sepet set miktari=miktari+ '" + int.Parse(txtMiktar.Text) + "' where no='" + txtNo.Text + "'", baglanti);
                    komut2.ExecuteNonQuery();

                    SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyati=miktari*satisfiyati where no='" + txtNo.Text + "'", baglanti);


                    komut3.ExecuteNonQuery();

                    baglanti.Close();
                }
                daset.Tables["sepet"].Clear();
                sepetListele();
                hesapla();
                Temizle();
            }
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplam.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatis.Text)).ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void txtSatis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplam.Text = (double.Parse(txtMiktar.Text) * double.Parse(txtSatis.Text)).ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            SatisListele listele = new SatisListele();
            listele.ShowDialog();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(no,tc,adsoyad,tel,urunkodu,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@no,@tc,@adsoyad,@tel,@urunkodu,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@no", dataGridView1.Rows[i].Cells["no"].Value.ToString());
                komut.Parameters.AddWithValue("@tc", dataGridView1.Rows[i].Cells["tc"].Value.ToString());
                komut.Parameters.AddWithValue("@adsoyad", dataGridView1.Rows[i].Cells["adsoyad"].Value.ToString());
                komut.Parameters.AddWithValue("@tel", dataGridView1.Rows[i].Cells["tel"].Value.ToString());
                komut.Parameters.AddWithValue("@urunkodu", dataGridView1.Rows[i].Cells["urunkodu"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati",double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", dataGridView1.Rows[i].Cells["tarih"].Value.ToString());
                komut.ExecuteNonQuery();
                
                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-'" + int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString()) + "' where urunkodu='" + dataGridView1.Rows[i].Cells["urunkodu"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                
                
                
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["sepet"].Clear();
            sepetListele();
            hesapla();
            MessageBox.Show("Satış Yapıldı.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GünlükRapor raporla = new GünlükRapor();
            raporla.ShowDialog();
        }
    }
}
