namespace StokTakip
{
    partial class SatisTakip
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPara = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtilkTarih = new System.Windows.Forms.DateTimePicker();
            this.TxtsonTarih = new System.Windows.Forms.DateTimePicker();
            this.BtnAra = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtUrunAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGW = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PbSil = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.LblPara);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 463);
            this.panel1.TabIndex = 0;
            // 
            // LblPara
            // 
            this.LblPara.AutoSize = true;
            this.LblPara.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPara.ForeColor = System.Drawing.Color.Green;
            this.LblPara.Location = new System.Drawing.Point(12, 207);
            this.LblPara.Name = "LblPara";
            this.LblPara.Size = new System.Drawing.Size(134, 25);
            this.LblPara.TabIndex = 19;
            this.LblPara.Text = "yqkup.com";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtilkTarih, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtsonTarih, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnAra, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(264, 107);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Son Tarih";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlk Tarih";
            // 
            // TxtilkTarih
            // 
            this.TxtilkTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtilkTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtilkTarih.Location = new System.Drawing.Point(103, 8);
            this.TxtilkTarih.Name = "TxtilkTarih";
            this.TxtilkTarih.Size = new System.Drawing.Size(150, 20);
            this.TxtilkTarih.TabIndex = 2;
            // 
            // TxtsonTarih
            // 
            this.TxtsonTarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtsonTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtsonTarih.Location = new System.Drawing.Point(103, 45);
            this.TxtsonTarih.Name = "TxtsonTarih";
            this.TxtsonTarih.Size = new System.Drawing.Size(150, 20);
            this.TxtsonTarih.TabIndex = 3;
            // 
            // BtnAra
            // 
            this.BtnAra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Location = new System.Drawing.Point(95, 77);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(166, 27);
            this.BtnAra.TabIndex = 5;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.TxtUrunAra, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 59);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtUrunAra
            // 
            this.TxtUrunAra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUrunAra.Location = new System.Drawing.Point(104, 19);
            this.TxtUrunAra.Name = "TxtUrunAra";
            this.TxtUrunAra.Size = new System.Drawing.Size(148, 20);
            this.TxtUrunAra.TabIndex = 1;
            this.TxtUrunAra.TextChanged += new System.EventHandler(this.TxtUrunAra_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Seçiniz";
            // 
            // DGW
            // 
            this.DGW.AllowUserToAddRows = false;
            this.DGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGW.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGW.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGW.Location = new System.Drawing.Point(264, 0);
            this.DGW.Name = "DGW";
            this.DGW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGW.Size = new System.Drawing.Size(705, 463);
            this.DGW.TabIndex = 18;
            this.DGW.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_CellEnter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.PbSil);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 376);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(241, 75);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // PbSil
            // 
            this.PbSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbSil.Location = new System.Drawing.Point(172, 3);
            this.PbSil.Name = "PbSil";
            this.PbSil.Size = new System.Drawing.Size(66, 66);
            this.PbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSil.TabIndex = 2;
            this.PbSil.TabStop = false;
            this.PbSil.Click += new System.EventHandler(this.PbSil_Click);
            // 
            // SatisTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 463);
            this.Controls.Add(this.DGW);
            this.Controls.Add(this.panel1);
            this.Name = "SatisTakip";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatisTakip";
            this.Load += new System.EventHandler(this.SatisTakip_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbSil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGW;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TxtUrunAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TxtilkTarih;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TxtsonTarih;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Label LblPara;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox PbSil;
    }
}