using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StokTakip
{
    public partial class SatisYap : Form
    {
        #region Form
        public SatisYap()
        {
            InitializeComponent();
        }
        #endregion
        #region Değişkenler
        public static int sirano, adet, urunSayisi;
        double para;
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
        private void SatisYap_Load(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection(Yol);
            UrunGetir();
            DataGridDoldur();
            KasaDoldur();

            PbSatisYap.Image = Image.FromFile("ikonlar/satis.png");
        }
        #endregion
        #region Metodlar
        public void DataGridDoldur()
        {
            try
            {
                baglanti = new OleDbConnection(Yol);
                adaptor = new OleDbDataAdapter("Select * From Urunler", baglanti);
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
            }
            catch
            {
                baglanti.Close();
                MessageBox.Show("Veritabanına bağlanılamadı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UrunGetir()
        {
            try
            {
                baglanti.Open();
                komut = new OleDbCommand("Select * From Urunler", baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    urunSayisi++;
                }
                baglanti.Close();
                if (urunSayisi <= 0)
                    PbSatisYap.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ürünler tablosuna bağlanılamadı.\nBağlantı hatası", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        public void KasaDoldur()
        {
            try
            {

                baglanti = new OleDbConnection(Yol);
                adaptor = new OleDbDataAdapter("Select * From Kasa", baglanti);
                ds = new DataSet();
                baglanti.Open();
                adaptor.Fill(ds, "Kasa");
                DGWKasa.DataSource = ds.Tables["Kasa"];
                baglanti.Close();

                DGWKasa.Columns[0].Visible = false;

                para = Convert.ToDouble(ds.Tables["Kasa"].Rows[0]["KASA"].ToString());
            }
            catch
            {
                MessageBox.Show("Kasa tablosuna bağlanılamadı.\nBağlantı hatası", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        #endregion
        #region Arama
        private void TxtAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti = new OleDbConnection(Yol);
                adaptor = new OleDbDataAdapter("Select * from Urunler where UrunAd like '%" + TxtAra.Text + "%' or KategoriAd like '%" + TxtAra.Text + "%' or UrunAciklama like '%" + TxtAra.Text + "%' or UrunAdet like '%" + TxtAra.Text + "%' or UrunBirim like '%" + TxtAra.Text + "%' or UrunFiyat like '%" + TxtAra.Text + "%' or UrunEklemeTarih like '%" + TxtAra.Text + "%' or UrunGuncellemeTarih like '%" + TxtAra.Text + "%'", baglanti);
                ds = new DataSet();
                baglanti.Open();
                adaptor.Fill(ds, "Urunler");
                DGW.DataSource = ds.Tables["Urunler"];
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Ürünler tablosundan veri çekilemedi.\nBağlantı hatası", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        #endregion
        #region Butonlar
        private void PbSatisYap_Click(object sender, EventArgs e)
        {
            try
            {
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "update Urunler set UrunAdet='" + (adet - Convert.ToInt32(TxtAdet.Text)).ToString() + "' where UrunID=" + sirano + "";
                komut.ExecuteNonQuery();
                baglanti.Close();

                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "update Kasa set KASA='" + (para + (Convert.ToDouble(TxtAdet.Text) * Convert.ToDouble(TxtFiyat.Text))).ToString() + "' where SiraNo=1";
                komut.ExecuteNonQuery();
                baglanti.Close();

                komut = new OleDbCommand();
                baglanti.Open();
                komut = new OleDbCommand("INSERT INTO SatisTakip(UrunAd,KategoriAd,UrunAciklama,UrunAdet,UrunBirim,UrunFiyat,UrunSatisTarih,UrunNo) VALUES('" + TxtAd.Text + "','" + CbKategori.Text + "','" + TxtAciklama.Text + "','" + TxtAdet.Text + "','" + TxtBirim.Text + "','" + TxtFiyat.Text + "','" + TxtEklemeTarihi.Value.ToShortDateString() + "','" + sirano + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                DataGridDoldur();
                KasaDoldur();
                MessageBox.Show("Satış yapıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Satış yapılamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        private void DGW_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            sirano = Convert.ToInt32(DGW.CurrentRow.Cells[0].Value.ToString());
            adet = Convert.ToInt32(DGW.CurrentRow.Cells[4].Value.ToString());
            TxtAd.Text = DGW.CurrentRow.Cells[1].Value.ToString();
            CbKategori.Text = DGW.CurrentRow.Cells[2].Value.ToString();
            TxtAciklama.Text = DGW.CurrentRow.Cells[3].Value.ToString();
            TxtAdet.Text = DGW.CurrentRow.Cells[4].Value.ToString();
            TxtBirim.Text = DGW.CurrentRow.Cells[5].Value.ToString();
            TxtFiyat.Text = DGW.CurrentRow.Cells[6].Value.ToString();
            TxtEklemeTarihi.Text = DGW.CurrentRow.Cells[7].Value.ToString();
            TxtGuncellemeTarihi.Text = DGW.CurrentRow.Cells[8].Value.ToString();
        }
        #endregion
    }
}