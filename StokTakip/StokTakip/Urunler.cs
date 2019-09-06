using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StokTakip
{
    public partial class Urunler : Form
    {
        #region Form
        public Urunler()
        {
            InitializeComponent();
        }
        #endregion
        #region Değişkenler
        int sirano, urunSayisi;
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
        private void Urunler_Load(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection(Yol);
            DataGridDoldur();
            KategorileriGetir();

            PbKaydet.Image = Image.FromFile("ikonlar/kaydet.png");
            PbGuncelle.Image = Image.FromFile("ikonlar/guncelle.png");
            PbSil.Image = Image.FromFile("ikonlar/sil.png");
        }
        #endregion
        #region Metodlar
        public void DataGridDoldur()
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
            }
            catch
            {
                baglanti.Close();
                MessageBox.Show("Veritabanına bağlanılamadı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void KategorileriGetir()
        {
            try
            {
                CbKategori.Items.Clear();
                baglanti.Open();
                komut = new OleDbCommand("Select * From Kategoriler", baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    CbKategori.Items.Add(oku["KategoriAd"].ToString());

                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Kategoriler gösterilemedi\nVeritabanına bağlanılamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
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
                {
                    PbSil.Enabled = false;
                    PbGuncelle.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ürünler tablosuna bağlanılamadı.\nBağlantı hatası", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        #endregion
        #region Butonlar
        private void PbKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                komut = new OleDbCommand("INSERT INTO Urunler(UrunAd,KategoriAd,UrunAciklama,UrunAdet,UrunBirim,UrunFiyat,UrunEklemeTarih) VALUES('" + TxtAd.Text + "','" + CbKategori.Text + "','" + TxtAciklama.Text + "','" + TxtAdet.Text + "','" + TxtBirim.Text + "','" + TxtFiyat.Text + "','" + TxtEklemeTarihi.Value.ToShortDateString() + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                DataGridDoldur();
                MessageBox.Show("Ürün eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün eklenemedi.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        private void PbGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "update Urunler set UrunAd='" + TxtAd.Text + "',KategoriAd='" + CbKategori.Text + "',UrunAciklama='" + TxtAciklama.Text + "',UrunAdet='" + TxtAdet.Text + "',UrunBirim='" + TxtBirim.Text + "',UrunFiyat='" + TxtFiyat.Text + "',UrunEklemeTarih='" + TxtEklemeTarihi.Value.ToShortDateString() + "',UrunGuncellemeTarih='" + TxtGuncellemeTarihi.Value.ToShortDateString() + "' where UrunID=" + sirano + "";
                komut.ExecuteNonQuery();
                baglanti.Close();
                DataGridDoldur();
                MessageBox.Show("Ürün güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün güncellenemedi.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        private void PbSil_Click(object sender, EventArgs e)
        {
            DialogResult yqkup = MessageBox.Show("Silmek istediğinize emin misiniz?", "DİKKAT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (yqkup == DialogResult.Yes)
            {
                try
                {
                    komut = new OleDbCommand();
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from Urunler where UrunID=" + sirano + "";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    DataGridDoldur();
                    MessageBox.Show("Ürün silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ürün silinemedi.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                }
            }
        }
        private void DGW_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            sirano = Convert.ToInt32(DGW.CurrentRow.Cells[0].Value.ToString());
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
            catch (Exception)
            {
                MessageBox.Show("Arama Yapılamadı\nGirdilerinizi kontrol ediniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        #endregion
    }
}