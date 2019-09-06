namespace StokTakip
{
    partial class Kategoriler
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
            this.Liste = new System.Windows.Forms.ListBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAciklama = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PbKaydet = new System.Windows.Forms.PictureBox();
            this.PbGuncelle = new System.Windows.Forms.PictureBox();
            this.PbSil = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbKaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSil)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.BackColor = System.Drawing.Color.LightSalmon;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Left;
            this.Liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Liste.FormattingEnabled = true;
            this.Liste.ItemHeight = 20;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(208, 297);
            this.Liste.TabIndex = 0;
            this.Liste.SelectedIndexChanged += new System.EventHandler(this.Liste_SelectedIndexChanged);
            // 
            // TxtAd
            // 
            this.TxtAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(119, 3);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(304, 26);
            this.TxtAd.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.23005F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.76995F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtAciklama, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtAd, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.81481F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.18519F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 216);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama";
            // 
            // TxtAciklama
            // 
            this.TxtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAciklama.Location = new System.Drawing.Point(119, 34);
            this.TxtAciklama.Multiline = true;
            this.TxtAciklama.Name = "TxtAciklama";
            this.TxtAciklama.Size = new System.Drawing.Size(304, 179);
            this.TxtAciklama.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.PbKaydet);
            this.flowLayoutPanel1.Controls.Add(this.PbGuncelle);
            this.flowLayoutPanel1.Controls.Add(this.PbSil);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(426, 78);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // PbKaydet
            // 
            this.PbKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbKaydet.Location = new System.Drawing.Point(357, 3);
            this.PbKaydet.Name = "PbKaydet";
            this.PbKaydet.Size = new System.Drawing.Size(66, 66);
            this.PbKaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbKaydet.TabIndex = 0;
            this.PbKaydet.TabStop = false;
            this.PbKaydet.Click += new System.EventHandler(this.PbKaydet_Click);
            // 
            // PbGuncelle
            // 
            this.PbGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbGuncelle.Location = new System.Drawing.Point(285, 3);
            this.PbGuncelle.Name = "PbGuncelle";
            this.PbGuncelle.Size = new System.Drawing.Size(66, 66);
            this.PbGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbGuncelle.TabIndex = 1;
            this.PbGuncelle.TabStop = false;
            this.PbGuncelle.Click += new System.EventHandler(this.PbGuncelle_Click);
            // 
            // PbSil
            // 
            this.PbSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbSil.Location = new System.Drawing.Point(213, 3);
            this.PbSil.Name = "PbSil";
            this.PbSil.Size = new System.Drawing.Size(66, 66);
            this.PbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSil.TabIndex = 2;
            this.PbSil.TabStop = false;
            this.PbSil.Click += new System.EventHandler(this.PbSil_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(208, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 219);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(208, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 78);
            this.panel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adı";
            // 
            // Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(634, 297);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Liste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kategoriler";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbKaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Liste;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAciklama;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox PbKaydet;
        private System.Windows.Forms.PictureBox PbGuncelle;
        private System.Windows.Forms.PictureBox PbSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}