namespace magazaOtomasyonu
{
    partial class FrmUrun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrun));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblUrnID = new System.Windows.Forms.Label();
            this.LblStkMiktr = new System.Windows.Forms.Label();
            this.LblBrmFyt = new System.Windows.Forms.Label();
            this.LblKategori = new System.Windows.Forms.Label();
            this.LblMagaz = new System.Windows.Forms.Label();
            this.Lblpersnl = new System.Windows.Forms.Label();
            this.LblUrnAd = new System.Windows.Forms.Label();
            this.TxtUrnID = new System.Windows.Forms.TextBox();
            this.TxtUrnAd = new System.Windows.Forms.TextBox();
            this.TxtBrmFyt = new System.Windows.Forms.TextBox();
            this.comboBoxKateg = new System.Windows.Forms.ComboBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnGuncel = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TxtPersonel = new System.Windows.Forms.TextBox();
            this.TxtMagaza = new System.Windows.Forms.TextBox();
            this.BtnSilinenUrun = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 106);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIYAFET MAGAZASI";
            // 
            // LblUrnID
            // 
            this.LblUrnID.AutoSize = true;
            this.LblUrnID.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUrnID.Location = new System.Drawing.Point(33, 166);
            this.LblUrnID.Name = "LblUrnID";
            this.LblUrnID.Size = new System.Drawing.Size(86, 19);
            this.LblUrnID.TabIndex = 1;
            this.LblUrnID.Text = "URUN ID:";
            // 
            // LblStkMiktr
            // 
            this.LblStkMiktr.AutoSize = true;
            this.LblStkMiktr.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStkMiktr.Location = new System.Drawing.Point(33, 283);
            this.LblStkMiktr.Name = "LblStkMiktr";
            this.LblStkMiktr.Size = new System.Drawing.Size(133, 19);
            this.LblStkMiktr.TabIndex = 2;
            this.LblStkMiktr.Text = "Stok Miktar:";
            // 
            // LblBrmFyt
            // 
            this.LblBrmFyt.AutoSize = true;
            this.LblBrmFyt.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBrmFyt.Location = new System.Drawing.Point(33, 245);
            this.LblBrmFyt.Name = "LblBrmFyt";
            this.LblBrmFyt.Size = new System.Drawing.Size(113, 19);
            this.LblBrmFyt.TabIndex = 3;
            this.LblBrmFyt.Text = "BİRİM FİYAT:";
            // 
            // LblKategori
            // 
            this.LblKategori.AutoSize = true;
            this.LblKategori.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKategori.Location = new System.Drawing.Point(33, 413);
            this.LblKategori.Name = "LblKategori";
            this.LblKategori.Size = new System.Drawing.Size(101, 19);
            this.LblKategori.TabIndex = 4;
            this.LblKategori.Text = "kategori:";
            // 
            // LblMagaz
            // 
            this.LblMagaz.AutoSize = true;
            this.LblMagaz.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMagaz.Location = new System.Drawing.Point(33, 366);
            this.LblMagaz.Name = "LblMagaz";
            this.LblMagaz.Size = new System.Drawing.Size(105, 19);
            this.LblMagaz.TabIndex = 5;
            this.LblMagaz.Text = "Magaza ID:";
            // 
            // Lblpersnl
            // 
            this.Lblpersnl.AutoSize = true;
            this.Lblpersnl.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblpersnl.Location = new System.Drawing.Point(33, 321);
            this.Lblpersnl.Name = "Lblpersnl";
            this.Lblpersnl.Size = new System.Drawing.Size(124, 19);
            this.Lblpersnl.TabIndex = 6;
            this.Lblpersnl.Text = "PERSONEL ID:";
            // 
            // LblUrnAd
            // 
            this.LblUrnAd.AutoSize = true;
            this.LblUrnAd.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUrnAd.Location = new System.Drawing.Point(33, 207);
            this.LblUrnAd.Name = "LblUrnAd";
            this.LblUrnAd.Size = new System.Drawing.Size(90, 19);
            this.LblUrnAd.TabIndex = 7;
            this.LblUrnAd.Text = "URUN AD:";
            // 
            // TxtUrnID
            // 
            this.TxtUrnID.Location = new System.Drawing.Point(181, 166);
            this.TxtUrnID.Name = "TxtUrnID";
            this.TxtUrnID.Size = new System.Drawing.Size(118, 26);
            this.TxtUrnID.TabIndex = 8;
            // 
            // TxtUrnAd
            // 
            this.TxtUrnAd.Location = new System.Drawing.Point(181, 207);
            this.TxtUrnAd.Name = "TxtUrnAd";
            this.TxtUrnAd.Size = new System.Drawing.Size(118, 26);
            this.TxtUrnAd.TabIndex = 9;
            // 
            // TxtBrmFyt
            // 
            this.TxtBrmFyt.Location = new System.Drawing.Point(181, 245);
            this.TxtBrmFyt.Name = "TxtBrmFyt";
            this.TxtBrmFyt.Size = new System.Drawing.Size(118, 26);
            this.TxtBrmFyt.TabIndex = 10;
            // 
            // comboBoxKateg
            // 
            this.comboBoxKateg.FormattingEnabled = true;
            this.comboBoxKateg.Location = new System.Drawing.Point(181, 409);
            this.comboBoxKateg.Name = "comboBoxKateg";
            this.comboBoxKateg.Size = new System.Drawing.Size(118, 28);
            this.comboBoxKateg.TabIndex = 14;
            // 
            // BtnList
            // 
            this.BtnList.BackColor = System.Drawing.Color.Pink;
            this.BtnList.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnList.Location = new System.Drawing.Point(19, 505);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(127, 30);
            this.BtnList.TabIndex = 15;
            this.BtnList.Text = "listele";
            this.BtnList.UseVisualStyleBackColor = false;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.Pink;
            this.BtnEkle.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEkle.Location = new System.Drawing.Point(181, 505);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(127, 30);
            this.BtnEkle.TabIndex = 16;
            this.BtnEkle.Text = "ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnGuncel
            // 
            this.BtnGuncel.BackColor = System.Drawing.Color.Pink;
            this.BtnGuncel.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuncel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuncel.Location = new System.Drawing.Point(337, 505);
            this.BtnGuncel.Name = "BtnGuncel";
            this.BtnGuncel.Size = new System.Drawing.Size(127, 30);
            this.BtnGuncel.TabIndex = 17;
            this.BtnGuncel.Text = "guncelle";
            this.BtnGuncel.UseVisualStyleBackColor = false;
            this.BtnGuncel.Click += new System.EventHandler(this.BtnGuncel_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.BackColor = System.Drawing.Color.Pink;
            this.BtnAra.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAra.Location = new System.Drawing.Point(646, 505);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(127, 30);
            this.BtnAra.TabIndex = 18;
            this.BtnAra.Text = "ara";
            this.BtnAra.UseVisualStyleBackColor = false;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Pink;
            this.BtnSil.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSil.Location = new System.Drawing.Point(490, 505);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(127, 30);
            this.BtnSil.TabIndex = 19;
            this.BtnSil.Text = "sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(490, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(546, 291);
            this.dataGridView1.TabIndex = 20;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(181, 283);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 21;
            // 
            // TxtPersonel
            // 
            this.TxtPersonel.Location = new System.Drawing.Point(181, 321);
            this.TxtPersonel.Name = "TxtPersonel";
            this.TxtPersonel.Size = new System.Drawing.Size(118, 26);
            this.TxtPersonel.TabIndex = 22;
            // 
            // TxtMagaza
            // 
            this.TxtMagaza.Location = new System.Drawing.Point(181, 362);
            this.TxtMagaza.Name = "TxtMagaza";
            this.TxtMagaza.Size = new System.Drawing.Size(118, 26);
            this.TxtMagaza.TabIndex = 23;
            // 
            // BtnSilinenUrun
            // 
            this.BtnSilinenUrun.BackColor = System.Drawing.Color.Pink;
            this.BtnSilinenUrun.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSilinenUrun.Location = new System.Drawing.Point(540, 413);
            this.BtnSilinenUrun.Name = "BtnSilinenUrun";
            this.BtnSilinenUrun.Size = new System.Drawing.Size(174, 47);
            this.BtnSilinenUrun.TabIndex = 24;
            this.BtnSilinenUrun.Text = "Silinen Urunler";
            this.BtnSilinenUrun.UseVisualStyleBackColor = false;
            this.BtnSilinenUrun.Click += new System.EventHandler(this.BtnSilinenUrun_Click);
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1036, 562);
            this.Controls.Add(this.BtnSilinenUrun);
            this.Controls.Add(this.TxtMagaza);
            this.Controls.Add(this.TxtPersonel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.BtnGuncel);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.comboBoxKateg);
            this.Controls.Add(this.TxtBrmFyt);
            this.Controls.Add(this.TxtUrnAd);
            this.Controls.Add(this.TxtUrnID);
            this.Controls.Add(this.LblUrnAd);
            this.Controls.Add(this.Lblpersnl);
            this.Controls.Add(this.LblMagaz);
            this.Controls.Add(this.LblKategori);
            this.Controls.Add(this.LblBrmFyt);
            this.Controls.Add(this.LblStkMiktr);
            this.Controls.Add(this.LblUrnID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUrun";
            this.Text = "FrmUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblUrnID;
        private System.Windows.Forms.Label LblStkMiktr;
        private System.Windows.Forms.Label LblBrmFyt;
        private System.Windows.Forms.Label LblKategori;
        private System.Windows.Forms.Label LblMagaz;
        private System.Windows.Forms.Label Lblpersnl;
        private System.Windows.Forms.Label LblUrnAd;
        private System.Windows.Forms.TextBox TxtUrnID;
        private System.Windows.Forms.TextBox TxtUrnAd;
        private System.Windows.Forms.TextBox TxtBrmFyt;
        private System.Windows.Forms.ComboBox comboBoxKateg;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnGuncel;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox TxtPersonel;
        private System.Windows.Forms.TextBox TxtMagaza;
        private System.Windows.Forms.Button BtnSilinenUrun;
    }
}