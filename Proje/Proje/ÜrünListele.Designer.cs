namespace Proje
{
    partial class ÜrünListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSatis2 = new System.Windows.Forms.TextBox();
            this.txtKod2 = new System.Windows.Forms.TextBox();
            this.txtAlis2 = new System.Windows.Forms.TextBox();
            this.txtTedarikci2 = new System.Windows.Forms.TextBox();
            this.txtMiktar2 = new System.Windows.Forms.TextBox();
            this.txtMarka2 = new System.Windows.Forms.TextBox();
            this.txtÜrünAdi2 = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtkodAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(106, 340);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(100, 23);
            this.btnGüncelle.TabIndex = 22;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Satış fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Miktarı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Tedarikçi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Ürün Kodu";
            // 
            // txtSatis2
            // 
            this.txtSatis2.Location = new System.Drawing.Point(106, 291);
            this.txtSatis2.Name = "txtSatis2";
            this.txtSatis2.Size = new System.Drawing.Size(100, 22);
            this.txtSatis2.TabIndex = 28;
            // 
            // txtKod2
            // 
            this.txtKod2.Location = new System.Drawing.Point(106, 117);
            this.txtKod2.Name = "txtKod2";
            this.txtKod2.Size = new System.Drawing.Size(100, 22);
            this.txtKod2.TabIndex = 21;
            // 
            // txtAlis2
            // 
            this.txtAlis2.Location = new System.Drawing.Point(106, 262);
            this.txtAlis2.Name = "txtAlis2";
            this.txtAlis2.Size = new System.Drawing.Size(100, 22);
            this.txtAlis2.TabIndex = 27;
            // 
            // txtTedarikci2
            // 
            this.txtTedarikci2.Location = new System.Drawing.Point(106, 146);
            this.txtTedarikci2.Name = "txtTedarikci2";
            this.txtTedarikci2.Size = new System.Drawing.Size(100, 22);
            this.txtTedarikci2.TabIndex = 23;
            // 
            // txtMiktar2
            // 
            this.txtMiktar2.Location = new System.Drawing.Point(106, 233);
            this.txtMiktar2.Name = "txtMiktar2";
            this.txtMiktar2.Size = new System.Drawing.Size(100, 22);
            this.txtMiktar2.TabIndex = 26;
            // 
            // txtMarka2
            // 
            this.txtMarka2.Location = new System.Drawing.Point(106, 175);
            this.txtMarka2.Name = "txtMarka2";
            this.txtMarka2.Size = new System.Drawing.Size(100, 22);
            this.txtMarka2.TabIndex = 24;
            // 
            // txtÜrünAdi2
            // 
            this.txtÜrünAdi2.Location = new System.Drawing.Point(106, 204);
            this.txtÜrünAdi2.Name = "txtÜrünAdi2";
            this.txtÜrünAdi2.Size = new System.Drawing.Size(100, 22);
            this.txtÜrünAdi2.TabIndex = 25;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(827, 103);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 36;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtkodAra
            // 
            this.txtkodAra.Location = new System.Drawing.Point(540, 46);
            this.txtkodAra.Name = "txtkodAra";
            this.txtkodAra.Size = new System.Drawing.Size(116, 22);
            this.txtkodAra.TabIndex = 37;
            this.txtkodAra.TextChanged += new System.EventHandler(this.txtkodAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ürün koduyla Ara";
            // 
            // ÜrünListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkodAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSatis2);
            this.Controls.Add(this.txtKod2);
            this.Controls.Add(this.txtAlis2);
            this.Controls.Add(this.txtTedarikci2);
            this.Controls.Add(this.txtMiktar2);
            this.Controls.Add(this.txtMarka2);
            this.Controls.Add(this.txtÜrünAdi2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ÜrünListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.ÜrünListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSatis2;
        private System.Windows.Forms.TextBox txtKod2;
        private System.Windows.Forms.TextBox txtAlis2;
        private System.Windows.Forms.TextBox txtTedarikci2;
        private System.Windows.Forms.TextBox txtMiktar2;
        private System.Windows.Forms.TextBox txtMarka2;
        private System.Windows.Forms.TextBox txtÜrünAdi2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtkodAra;
        private System.Windows.Forms.Label label1;
    }
}