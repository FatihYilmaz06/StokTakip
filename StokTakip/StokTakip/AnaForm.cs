using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StokTakip
{
    public partial class AnaForm : Form
    {
        #region Form
        public AnaForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Bağlantı
        string Yol = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath.ToString() + "\\VT.mdb";
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataReader oku;
        OleDbDataAdapter adaptor;
        DataSet ds;
        #endregion
        #region Load
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
            RaporOlustur();

            PbKategori.Image = Image.FromFile("ikonlar/kategori.png");
            PbSatisYap.Image = Image.FromFile("ikonlar/satisYap.png");
            PbUrunler.Image = Image.FromFile("ikonlar/urunler.png");
            PbSatisTakip.Image = Image.FromFile("ikonlar/satisTakip.png");
        }
        #endregion
        #region Metodlar
        void RaporOlustur()
        {
            try
            {
                baglanti.Open();
                komut = new OleDbCommand("Select UrunID From Urunler", baglanti);
                oku = komut.ExecuteReader();
                int toplamUrunCesidi = 0;
                while (oku.Read())
                {
                    toplamUrunCesidi++;
                }
                ///////////////////////////////////////////////////
                double toplamTutar = 0;
                komut = new OleDbCommand("Select UrunAdet,UrunFiyat From Urunler", baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (oku["UrunAdet"].ToString() != "" && oku["UrunFiyat"].ToString() != "")
                    {
                        double deger = Convert.ToDouble(oku["UrunAdet"]) * Convert.ToDouble(oku["UrunFiyat"]);
                        toplamTutar += deger;
                    }
                }
                ////////////////////////////////////////////////////
                int toplamKategori = 0;
                komut = new OleDbCommand("Select KategoriID From Kategoriler", baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    toplamKategori++;
                }
                ///////////////////////////////////////////////////
                string sonEklenenUrun = "";
                komut = new OleDbCommand("Select * From Urunler ORDER BY UrunID", baglanti);
                oku = komut.ExecuteReader();
                int urunID = 0;
                while (oku.Read())
                {
                    urunID = Convert.ToInt32(oku["UrunID"].ToString());
                }
                komut = new OleDbCommand("Select UrunAd From Urunler WHERE UrunID=" + urunID, baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    sonEklenenUrun = oku["UrunAd"].ToString();
                }
                ///////////////////////////////////////////////////
                string sonGuncellenenUrun = "";
                komut = new OleDbCommand("Select * From Urunler Order BY UrunGuncellemeTarih", baglanti);
                oku = komut.ExecuteReader();
                int urunID2 = 0;
                while (oku.Read())
                {
                    urunID2 = Convert.ToInt32(oku["UrunID"].ToString());
                }
                komut = new OleDbCommand("Select UrunAd From Urunler WHERE UrunID=" + urunID2, baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    sonGuncellenenUrun = oku["UrunAd"].ToString();
                }
                ////////////////////////////////////////////////////
                string sonGuncellemeTarih = "";
                komut = new OleDbCommand("Select * From Urunler Order By UrunGuncellemeTarih", baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    sonGuncellemeTarih = oku["UrunGuncellemeTarih"].ToString();
                }
                ////////////////////////////////////////////////////
                baglanti.Close();

                toolStripLabel1.Text = "Toplam Ürün: " + toplamUrunCesidi.ToString() + " Adet";
                toolStripLabel2.Text = "Toplan Tutar: " + toplamTutar.ToString("c");
                toolStripLabel3.Text = "Toplam Kategori: " + toplamKategori.ToString() + " Adet";
                toolStripLabel4.Text = "Son Eklenen Ürün: " + sonEklenenUrun;
                toolStripLabel5.Text = "Son Güncellenen Ürün: " + sonGuncellenenUrun;
                toolStripLabel6.Text = "Son Güncelleme Tarihi: " + sonGuncellemeTarih;
                toolStripButton1.Image = Image.FromFile("ikonlar/yenile.png");
            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("Rapor oluşturulamadı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void AzalanVeyaKalmayanUrunler()
        {
            try
            {
                Liste.Items.Clear();
                baglanti.Open();
                komut = new OleDbCommand("Select * From Urunler Where UrunAdet<=" + CbLimit.Text, baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Liste.Items.Add(oku["UrunAdet"].ToString() + "\t" + oku["UrunAd"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("Adet sayısına ulaşılamadı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void DataGridDoldur()
        {
            try
            {
                baglanti = new OleDbConnection(Yol);
                adaptor = new OleDbDataAdapter("Select * From Urunler order by UrunID", baglanti);
                ds = new DataSet();
                baglanti.Open();
                adaptor.Fill(ds, "Urunler");
                DGW.DataSource = ds.Tables["Urunler"];
                baglanti.Close();

                DGW.Columns[0].Visible = false;
                DGW.Columns[1].HeaderText = "Ürün Adı";
                DGW.Columns[2].HeaderText = "Kategori";
                DGW.Columns[3].HeaderText = "Ürün Açıklaması";
                DGW.Columns[4].HeaderText = "Stok Adedi";
                DGW.Columns[5].HeaderText = "Birim Adı";
                DGW.Columns[6].HeaderText = "Birim Fiyatı";
                DGW.Columns[7].HeaderText = "Ekleme Tarihi";
                DGW.Columns[8].HeaderText = "Güncelleme Tarihi";

                DGW.Columns[0].Width = 50;
                DGW.Columns[1].Width = 150;
                DGW.Columns[3].Width = 250;

                toolStripLabel1.Text = "Toplam Kayıt: " + DGW.RowCount.ToString();
                ParaHesapla();
            }
            catch
            {
                baglanti.Close();
                MessageBox.Show("Veritabanına bağlanılamadı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public double toplam = 0;
        void ParaHesapla()
        {
            try
            {
                toplam = 0;

                baglanti.Open();
                komut = new OleDbCommand("Select UrunAdet,UrunFiyat From Urunler", baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (oku["UrunAdet"].ToString() != "" && oku["UrunFiyat"].ToString() != "")
                    {
                        double deger = Convert.ToDouble(oku["UrunAdet"]) * Convert.ToDouble(oku["UrunFiyat"]);
                        toplam += deger;
                    }
                }
                baglanti.Close();
                toolStripLabel2.Text = "Toplam Tutar: " + toplam.ToString("c");
            }
            catch
            {
            }
        }
        #endregion
        #region Butonlar
        private void PbUrunler_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.ShowDialog();
        }
        private void PbSatisYap_Click(object sender, EventArgs e)
        {
            SatisYap sy = new SatisYap();
            sy.ShowDialog();
        }
        private void PbKategori_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.ShowDialog();
        }
        private void PbSatisTakip_Click(object sender, EventArgs e)
        {
            SatisTakip st = new SatisTakip();
            st.ShowDialog();
        }
        private void CbLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbLimit.Text != "Seçiniz")
                AzalanVeyaKalmayanUrunler();
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            DataGridDoldur();
            RaporOlustur();
        }
        #endregion
        #region Ara
        private void TxtAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti = new OleDbConnection(Yol);
                switch (CbKriter.SelectedIndex)
                {
                    case 0:
                        adaptor = new OleDbDataAdapter("Select * from Urunler where UrunAd like '%" + TxtAra.Text + "%'", baglanti);
                        break;
                    case 1:
                        adaptor = new OleDbDataAdapter("Select * from Urunler where KategoriAd like '%" + TxtAra.Text + "%'", baglanti);
                        break;
                    case 2:
                        adaptor = new OleDbDataAdapter("Select * from Urunler where UrunAciklama like '%" + TxtAra.Text + "%'", baglanti);
                        break;
                }
                ds = new DataSet();
                baglanti.Open();
                adaptor.Fill(ds, "Urunler");
                DGW.DataSource = ds.Tables["Urunler"];
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Arama Yapılamadı\nGirdilerinizi kontrol ediniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        #endregion
    }
}