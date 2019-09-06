using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StokTakip
{
    public partial class SatisTakip : Form
    {
        #region Form
        public SatisTakip()
        {
            InitializeComponent();
        }
        #endregion
        #region Değişkenler
        int sirano, adet, eskiAdet, urunNo, urunSayisi;
        double para, fiyat;
        #endregion
        #region Bağlantı
        string Yol = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath.ToString() + "\\VT.mdb";
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter adaptor;
        OleDbDataReader oku;
        DataSet ds;
        #endregion
        #region Load
        private void SatisTakip_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
            Hesapla();
            UrunGetir();

            PbSil.Image = Image.FromFile("ikonlar/sil.png");
        }
        #endregion
        #region Metodlar
        public void DataGridDoldur()
        {
            try
            {
                baglanti = new OleDbConnection(Yol);
                adaptor = new OleDbDataAdapter("Select * From SatisTakip", baglanti);
                ds = new DataSet();
                baglanti.Open();
                adaptor.Fill(ds, "SatisTakip");
                DGW.DataSource = ds.Tables["SatisTakip"];
                baglanti.Close();

                DGW.Columns[0].Visible = false;
                DGW.Columns[1].HeaderText = "Ürün Adı";
                DGW.Columns[2].HeaderText = "Kategori";
                DGW.Columns[3].HeaderText = "Ürün Açıklaması";
                DGW.Columns[4].HeaderText = "Ürün Adedi";
                DGW.Columns[5].HeaderText = "Birim Adı";
                DGW.Columns[6].HeaderText = "Birim Fiyatı";
                DGW.Columns[7].HeaderText = "Satış Tarihi";
                DGW.Columns[8].Visible = false;

                baglanti = new OleDbConnection(Yol);
                adaptor = new OleDbDataAdapter("Select *From Kasa", baglanti);
                ds = new DataSet();
                baglanti.Open();
                adaptor.Fill(ds, "Kasa");
                para = Convert.ToDouble(ds.Tables["Kasa"].Rows[0]["KASA"].ToString());
                baglanti.Close();
            }
            catch (Exception x)
            {
                baglanti.Close();
                MessageBox.Show("Veritabanına bağlanılamadı\n"+x, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Hesapla()
        {
            double toplam = 0;
            for (int i = 0; i < DGW.Rows.Count; ++i)
            {
                toplam += Convert.ToDouble(DGW.Rows[i].Cells[4].Value) * Convert.ToDouble(DGW.Rows[i].Cells[6].Value);
            }
            LblPara.Text = toplam.ToString("c");
        }
        private void UrunIDHesapla()
        {
            baglanti = new OleDbConnection(Yol);
            adaptor = new OleDbDataAdapter("Select *From Urunler", baglanti);
            ds = new DataSet();
            baglanti.Open();
            adaptor.Fill(ds, "Urunler");
            for (int i = 0; i < ds.Tables["Urunler"].Rows.Count; i++)
            {
                if (ds.Tables["Urunler"].Rows[i]["UrunID"].ToString() == urunNo.ToString())
                    eskiAdet = Convert.ToInt32(ds.Tables["Urunler"].Rows[i]["UrunAdet"].ToString());
            }
            baglanti.Close();
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
                    PbSil.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ürünler tablosuna bağlanılamadı.\nBağlantı hatası", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        #endregion
        #region Butonlar
        private void TxtUrunAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti = new OleDbConnection(Yol);
                adaptor = new OleDbDataAdapter("Select * from SatisTakip where UrunAd like '%" + TxtUrunAra.Text + "%'", baglanti);
                ds = new DataSet();
                baglanti.Open();
                adaptor.Fill(ds, "SatisTakip");
                DGW.DataSource = ds.Tables["SatisTakip"];
                baglanti.Close();
                Hesapla();
            }
            catch (Exception)
            {
                MessageBox.Show("Arama Yapılamadı\nGirdilerinizi kontrol ediniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        private void BtnAra_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "SELECT * FROM SatisTakip Where UrunSatisTarih BETWEEN @tar1 and @tar2";
                DataTable dt = new DataTable();
                OleDbDataAdapter adp = new OleDbDataAdapter(sql, baglanti);
                adp.SelectCommand.Parameters.AddWithValue("@tar1", TxtilkTarih.Value.ToShortDateString());
                adp.SelectCommand.Parameters.AddWithValue("@tar2", TxtsonTarih.Value.ToShortDateString());
                adp.Fill(dt);
                baglanti.Close();
                DGW.DataSource = dt;
                Hesapla();
            }
            catch (Exception)
            {
                MessageBox.Show("Arama Yapılamadı\nGirdilerinizi kontrol ediniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        private void PbSil_Click(object sender, EventArgs e)
        {
            try
            {
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "update Kasa set KASA='" + (para - adet * fiyat).ToString() + "' where SiraNo=1";
                komut.ExecuteNonQuery();
                baglanti.Close();

                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "update Urunler set UrunAdet='" + (adet + eskiAdet).ToString() + "' where UrunID=" + urunNo + "";
                komut.ExecuteNonQuery();
                baglanti.Close();

                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "delete from SatisTakip where UrunID=" + sirano + "";
                komut.ExecuteNonQuery();
                baglanti.Close();

                DataGridDoldur();
                Hesapla();
                MessageBox.Show("Satış silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Satış silinemedi.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        private void DGW_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            sirano = Convert.ToInt32(DGW.CurrentRow.Cells[0].Value.ToString());
            adet = Convert.ToInt32(DGW.CurrentRow.Cells[4].Value.ToString());
            fiyat = Convert.ToDouble(DGW.CurrentRow.Cells[6].Value.ToString());
            urunNo = Convert.ToInt32(DGW.CurrentRow.Cells[8].Value.ToString());
            UrunIDHesapla();
        }
        #endregion
    }
}