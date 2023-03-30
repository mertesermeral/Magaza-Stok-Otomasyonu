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

namespace Proje
{
    public partial class frmTedarikciSayfasi : Form
    {
        public frmTedarikciSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTedarikci tedarikci = new frmTedarikci();
            tedarikci.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka tedarikci = new frmMarka();
            tedarikci.ShowDialog();
        }

        private void frmTedarikciSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}
