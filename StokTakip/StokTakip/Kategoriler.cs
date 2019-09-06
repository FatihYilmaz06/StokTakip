using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StokTakip
{
    public partial class Kategoriler : Form
    {
        #region Form
        public Kategoriler()
        {
            InitializeComponent();
        }
        #endregion
        #region Değişklenler
        int sirano;
        int[] kategoriID;
        string[] kategoriAdi, kategoriAciklama;
        #endregion
        #region Bağlantı
        string Yol = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + System.Windows.Forms.Application.StartupPath.ToString() + "\\VT.mdb;";
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataReader oku;
        #endregion
        #region Load
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection(Yol);
            KategorileriGetir();

            PbKaydet.Image = Image.FromFile("ikonlar/kaydet.png");
            PbGuncelle.Image = Image.FromFile("ikonlar/guncelle.png");
            PbSil.Image = Image.FromFile("ikonlar/sil.png");
        }
        #endregion
        #region Metodlar
        void KategorileriGetir()
        {
            try
            {
                Liste.Items.Clear();
                baglanti.Open();
                komut = new OleDbCommand("Select * From Kategoriler", baglanti);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    Liste.Items.Add(oku["KategoriAd"].ToString());

                }
                baglanti.Close();

                baglanti.Open();
                komut = new OleDbCommand("Select * From Kategoriler", baglanti);
                oku = komut.ExecuteReader();

                kategoriID = new int[Liste.Items.Count];
                kategoriAdi = new string[Liste.Items.Count];
                kategoriAciklama = new string[Liste.Items.Count];

                int x = 0;
                while (oku.Read())
                {
                    kategoriID[x] = Convert.ToInt16(oku["KategoriID"].ToString());
                    kategoriAdi[x] = oku["KategoriAd"].ToString();
                    kategoriAciklama[x] = oku["KategoriAciklama"].ToString();
                    x++;

                }
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Kategoriler gösterilemedi\nVeritabanına bağlanılamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                komut = new OleDbCommand("INSERT INTO Kategoriler(KategoriAd,KategoriAciklama) VALUES('" + TxtAd.Text + "','" + TxtAciklama.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                KategorileriGetir();
                MessageBox.Show("Kategori eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Kategori eklenemedi.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        private void PbGuncelle_Click(object sender, EventArgs e)
        {
            if (Liste.SelectedIndex >= 0)
            {
                try
                {
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "update Kategoriler set KategoriAd='" + TxtAd.Text + "',KategoriAciklama='" + TxtAciklama.Text + "' where KategoriID=" + sirano + "";
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    KategorileriGetir();
                    MessageBox.Show("Kategori güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kategori güncellenemedi.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                }
            }
            else
                MessageBox.Show("Lütfen listeden bir kategori seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void PbSil_Click(object sender, EventArgs e)
        {
            if (Liste.SelectedIndex >= 0)
            {
                DialogResult yqkup = MessageBox.Show("Silmek istediğinize emin misiniz?", "DİKKAT!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (yqkup == DialogResult.Yes)
                {
                    try
                    {
                        baglanti.Open();
                        komut = new OleDbCommand("DELETE FROM Kategoriler WHERE KategoriAd='" + Liste.SelectedItem + "'", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        KategorileriGetir();
                        MessageBox.Show("Kategori silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Kategori silinemedi.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        baglanti.Close();
                    }
                }
            }
            else
                MessageBox.Show("Lütfen listeden bir kategori seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sirano = kategoriID[Liste.SelectedIndex];
                TxtAd.Text = kategoriAdi[Liste.SelectedIndex];
                TxtAciklama.Text = kategoriAciklama[Liste.SelectedIndex];
            }
            catch
            {
            }
        }
        #endregion
    }
}