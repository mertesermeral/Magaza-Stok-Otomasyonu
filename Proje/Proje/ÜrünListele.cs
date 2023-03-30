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
    public partial class ÜrünListele : Form
    {
        public ÜrünListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-OORND2B;Initial Catalog=Stok;Integrated Security=True");
        DataSet daset = new DataSet();
        private void ÜrünListele_Load(object sender, EventArgs e)
        {
            ÜrünListeleme();
        }

        private void ÜrünListeleme()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKod2.Text = dataGridView1.CurrentRow.Cells["urunkodu"].Value.ToString();
            txtTedarikci2.Text = dataGridView1.CurrentRow.Cells["tedarikci"].Value.ToString();
            txtMarka2.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            txtÜrünAdi2.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            txtMiktar2.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            txtAlis2.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            txtSatis2.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set tedarikci=@tedarikci,marka=@marka,urunadi=@urunadi,miktari=@miktari,alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where urunkodu=@urunkodu", baglanti);
            komut.Parameters.AddWithValue("@urunkodu",txtKod2.Text);
            komut.Parameters.AddWithValue("@tedarikci", txtTedarikci2.Text);
            komut.Parameters.AddWithValue("@marka", txtMarka2.Text);
            komut.Parameters.AddWithValue("@urunadi", txtÜrünAdi2.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktar2.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(txtAlis2.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatis2.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            ÜrünListeleme();
            MessageBox.Show("Güncelleme Yapıldı.");
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where urunkodu='" + dataGridView1.CurrentRow.Cells["urunkodu"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            ÜrünListeleme();
            MessageBox.Show("Ürün Kaydı Silindi.");
        }

        private void txtkodAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where urunkodu like '%" + txtkodAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
