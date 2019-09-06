namespace StokTakip
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.Panel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Liste = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CbLimit = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CbKriter = new System.Windows.Forms.ComboBox();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PbSatisTakip = new System.Windows.Forms.PictureBox();
            this.PbKategori = new System.Windows.Forms.PictureBox();
            this.PbSatisYap = new System.Windows.Forms.PictureBox();
            this.PbUrunler = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.DGW = new System.Windows.Forms.DataGridView();
            this.Panel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSatisTakip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSatisYap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUrunler)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel.Controls.Add(this.groupBox3);
            this.Panel.Controls.Add(this.groupBox2);
            this.Panel.Controls.Add(this.groupBox1);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(305, 536);
            this.Panel.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(0, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 360);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Azalan/Biten Ürünler";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Liste);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 312);
            this.panel2.TabIndex = 4;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Liste.FormattingEnabled = true;
            this.Liste.ItemHeight = 16;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(299, 312);
            this.Liste.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CbLimit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 29);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limit";
            // 
            // CbLimit
            // 
            this.CbLimit.FormattingEnabled = true;
            this.CbLimit.Items.AddRange(new object[] {
            "5",
            "10",
            "25",
            "50",
            "100"});
            this.CbLimit.Location = new System.Drawing.Point(35, 3);
            this.CbLimit.Name = "CbLimit";
            this.CbLimit.Size = new System.Drawing.Size(228, 21);
            this.CbLimit.TabIndex = 1;
            this.CbLimit.Text = "Seçiniz";
            this.CbLimit.SelectedIndexChanged += new System.EventHandler(this.CbLimit_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tomato;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CbKriter);
            this.groupBox2.Controls.Add(this.TxtAra);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 86);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama Yap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kriter";
            // 
            // CbKriter
            // 
            this.CbKriter.FormattingEnabled = true;
            this.CbKriter.Items.AddRange(new object[] {
            "Ürün",
            "Kategori",
            "Açıklama"});
            this.CbKriter.Location = new System.Drawing.Point(49, 19);
            this.CbKriter.Name = "CbKriter";
            this.CbKriter.Size = new System.Drawing.Size(217, 21);
            this.CbKriter.TabIndex = 1;
            // 
            // TxtAra
            // 
            this.TxtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAra.Location = new System.Drawing.Point(48, 46);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(218, 26);
            this.TxtAra.TabIndex = 0;
            this.TxtAra.TextChanged += new System.EventHandler(this.TxtAra_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.PbSatisTakip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PbKategori, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PbSatisYap, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PbUrunler, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Red;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 71);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PbSatisTakip
            // 
            this.PbSatisTakip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbSatisTakip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbSatisTakip.Location = new System.Drawing.Point(151, 3);
            this.PbSatisTakip.Name = "PbSatisTakip";
            this.PbSatisTakip.Size = new System.Drawing.Size(68, 65);
            this.PbSatisTakip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSatisTakip.TabIndex = 4;
            this.PbSatisTakip.TabStop = false;
            this.PbSatisTakip.Click += new System.EventHandler(this.PbSatisTakip_Click);
            // 
            // PbKategori
            // 
            this.PbKategori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbKategori.Location = new System.Drawing.Point(225, 3);
            this.PbKategori.Name = "PbKategori";
            this.PbKategori.Size = new System.Drawing.Size(71, 65);
            this.PbKategori.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbKategori.TabIndex = 3;
            this.PbKategori.TabStop = false;
            this.PbKategori.Click += new System.EventHandler(this.PbKategori_Click);
            // 
            // PbSatisYap
            // 
            this.PbSatisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbSatisYap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbSatisYap.Location = new System.Drawing.Point(3, 3);
            this.PbSatisYap.Name = "PbSatisYap";
            this.PbSatisYap.Size = new System.Drawing.Size(68, 65);
            this.PbSatisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSatisYap.TabIndex = 2;
            this.PbSatisYap.TabStop = false;
            this.PbSatisYap.Click += new System.EventHandler(this.PbSatisYap_Click);
            // 
            // PbUrunler
            // 
            this.PbUrunler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbUrunler.Location = new System.Drawing.Point(77, 3);
            this.PbUrunler.Name = "PbUrunler";
            this.PbUrunler.Size = new System.Drawing.Size(68, 65);
            this.PbUrunler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbUrunler.TabIndex = 1;
            this.PbUrunler.TabStop = false;
            this.PbUrunler.Click += new System.EventHandler(this.PbUrunler_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripLabel5,
            this.toolStripSeparator5,
            this.toolStripLabel6,
            this.toolStripSeparator6,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 536);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1108, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel1.Text = "Toplam Ürün";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel2.Text = "Toplan Tutar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(94, 22);
            this.toolStripLabel3.Text = "Toplam Kategori";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel4.Text = "Son Eklenen Ürün";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(125, 22);
            this.toolStripLabel5.Text = "Son Güncellenen Ürün";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(125, 22);
            this.toolStripLabel6.Text = "Son Güncelleme Tarihi";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Yenile";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // DGW
            // 
            this.DGW.AllowUserToAddRows = false;
            this.DGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGW.BackgroundColor = System.Drawing.Color.White;
            this.DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGW.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGW.Location = new System.Drawing.Point(305, 0);
            this.DGW.Name = "DGW";
            this.DGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGW.Size = new System.Drawing.Size(803, 536);
            this.DGW.TabIndex = 1;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1108, 561);
            this.Controls.Add(this.DGW);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AnaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK TAKİP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbSatisTakip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSatisYap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUrunler)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox Liste;
        private System.Windows.Forms.ComboBox CbLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DGW;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbKriter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.PictureBox PbSatisTakip;
        private System.Windows.Forms.PictureBox PbKategori;
        private System.Windows.Forms.PictureBox PbSatisYap;
        private System.Windows.Forms.PictureBox PbUrunler;
    }
}

