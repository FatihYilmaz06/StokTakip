namespace StokTakip
{
    partial class SatisYap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGW = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbKategori = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBirim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtEklemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.TxtGuncellemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGWKasa = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PbSatisYap = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWKasa)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSatisYap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGW
            // 
            this.DGW.AllowUserToAddRows = false;
            this.DGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGW.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGW.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGW.Location = new System.Drawing.Point(0, 0);
            this.DGW.Name = "DGW";
            this.DGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGW.Size = new System.Drawing.Size(656, 463);
            this.DGW.TabIndex = 18;
            this.DGW.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtAra);
            this.groupBox1.Location = new System.Drawing.Point(273, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 49);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Yap";
            // 
            // TxtAra
            // 
            this.TxtAra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAra.Location = new System.Drawing.Point(3, 16);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(187, 20);
            this.TxtAra.TabIndex = 1;
            this.TxtAra.TextChanged += new System.EventHandler(this.TxtAra_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.16484F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.83517F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtAd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CbKategori, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtAciklama, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TxtAdet, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TxtBirim, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TxtFiyat, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.TxtEklemeTarihi, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TxtGuncellemeTarihi, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 310);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // TxtAd
            // 
            this.TxtAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAd.Enabled = false;
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(164, 3);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(293, 23);
            this.TxtAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori";
            // 
            // CbKategori
            // 
            this.CbKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbKategori.Enabled = false;
            this.CbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CbKategori.FormattingEnabled = true;
            this.CbKategori.Location = new System.Drawing.Point(164, 32);
            this.CbKategori.Name = "CbKategori";
            this.CbKategori.Size = new System.Drawing.Size(293, 24);
            this.CbKategori.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama";
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAciklama.Enabled = false;
            this.TxtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAciklama.Location = new System.Drawing.Point(164, 62);
            this.TxtAciklama.Multiline = true;
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(293, 99);
            this.TxtAciklama.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adet";
            // 
            // TxtAdet
            // 
            this.TxtAdet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdet.Location = new System.Drawing.Point(164, 167);
            this.TxtAdet.Name = "TxtAdet";
            this.TxtAdet.Size = new System.Drawing.Size(293, 23);
            this.TxtAdet.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birim";
            // 
            // TxtBirim
            // 
            this.TxtBirim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBirim.Enabled = false;
            this.TxtBirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBirim.Location = new System.Drawing.Point(164, 196);
            this.TxtBirim.Name = "TxtBirim";
            this.TxtBirim.Size = new System.Drawing.Size(293, 23);
            this.TxtBirim.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fiyat";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtFiyat.Enabled = false;
            this.TxtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtFiyat.Location = new System.Drawing.Point(164, 225);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(293, 23);
            this.TxtFiyat.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ekleme Tarihi";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Güncelleme Tarihi";
            // 
            // TxtEklemeTarihi
            // 
            this.TxtEklemeTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEklemeTarihi.Enabled = false;
            this.TxtEklemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEklemeTarihi.Location = new System.Drawing.Point(166, 254);
            this.TxtEklemeTarihi.Name = "TxtEklemeTarihi";
            this.TxtEklemeTarihi.Size = new System.Drawing.Size(289, 22);
            this.TxtEklemeTarihi.TabIndex = 16;
            // 
            // TxtGuncellemeTarihi
            // 
            this.TxtGuncellemeTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtGuncellemeTarihi.Enabled = false;
            this.TxtGuncellemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGuncellemeTarihi.Location = new System.Drawing.Point(166, 283);
            this.TxtGuncellemeTarihi.Name = "TxtGuncellemeTarihi";
            this.TxtGuncellemeTarihi.Size = new System.Drawing.Size(289, 22);
            this.TxtGuncellemeTarihi.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGWKasa);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(656, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 463);
            this.panel2.TabIndex = 23;
            // 
            // DGWKasa
            // 
            this.DGWKasa.AllowUserToAddRows = false;
            this.DGWKasa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGWKasa.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.DGWKasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGWKasa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGWKasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWKasa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGWKasa.Location = new System.Drawing.Point(6, 409);
            this.DGWKasa.Name = "DGWKasa";
            this.DGWKasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGWKasa.Size = new System.Drawing.Size(229, 45);
            this.DGWKasa.TabIndex = 21;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.PbSatisYap);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(246, 385);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 75);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // PbSatisYap
            // 
            this.PbSatisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbSatisYap.Location = new System.Drawing.Point(151, 3);
            this.PbSatisYap.Name = "PbSatisYap";
            this.PbSatisYap.Size = new System.Drawing.Size(66, 66);
            this.PbSatisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSatisYap.TabIndex = 0;
            this.PbSatisYap.TabStop = false;
            this.PbSatisYap.Click += new System.EventHandler(this.PbSatisYap_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGW);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 463);
            this.panel1.TabIndex = 24;
            // 
            // SatisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1125, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SatisYap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatisYap";
            this.Load += new System.EventHandler(this.SatisYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGWKasa)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbSatisYap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbKategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBirim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker TxtEklemeTarihi;
        private System.Windows.Forms.DateTimePicker TxtGuncellemeTarihi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox PbSatisYap;
        private System.Windows.Forms.DataGridView DGWKasa;
    }
}