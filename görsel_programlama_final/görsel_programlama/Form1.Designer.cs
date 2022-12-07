namespace görsel_programlama
{
    partial class AnaSayfa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btnuyelistele = new System.Windows.Forms.Button();
            this.BtnUyeEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btnkitaplistele = new System.Windows.Forms.Button();
            this.Btnkitapekle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btnemanet_iade = new System.Windows.Forms.Button();
            this.Btnemanetliste = new System.Windows.Forms.Button();
            this.Btnemanetverne = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnGrafik = new System.Windows.Forms.Button();
            this.Btnsiralama = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btnuyelistele);
            this.groupBox1.Controls.Add(this.BtnUyeEkle);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(292, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // Btnuyelistele
            // 
            this.Btnuyelistele.BackColor = System.Drawing.Color.Turquoise;
            this.Btnuyelistele.Location = new System.Drawing.Point(23, 96);
            this.Btnuyelistele.Name = "Btnuyelistele";
            this.Btnuyelistele.Size = new System.Drawing.Size(246, 51);
            this.Btnuyelistele.TabIndex = 1;
            this.Btnuyelistele.Text = "Üye Listele";
            this.Btnuyelistele.UseVisualStyleBackColor = false;
            // 
            // BtnUyeEkle
            // 
            this.BtnUyeEkle.BackColor = System.Drawing.Color.Turquoise;
            this.BtnUyeEkle.Location = new System.Drawing.Point(23, 28);
            this.BtnUyeEkle.Name = "BtnUyeEkle";
            this.BtnUyeEkle.Size = new System.Drawing.Size(246, 51);
            this.BtnUyeEkle.TabIndex = 0;
            this.BtnUyeEkle.Text = "Üye Ekleme";
            this.BtnUyeEkle.UseVisualStyleBackColor = false;
            this.BtnUyeEkle.Click += new System.EventHandler(this.BtnUyeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btnkitaplistele);
            this.groupBox2.Controls.Add(this.Btnkitapekle);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(312, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(292, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // Btnkitaplistele
            // 
            this.Btnkitaplistele.BackColor = System.Drawing.Color.Turquoise;
            this.Btnkitaplistele.Location = new System.Drawing.Point(30, 96);
            this.Btnkitaplistele.Name = "Btnkitaplistele";
            this.Btnkitaplistele.Size = new System.Drawing.Size(246, 51);
            this.Btnkitaplistele.TabIndex = 3;
            this.Btnkitaplistele.Text = "Kitap Listele";
            this.Btnkitaplistele.UseVisualStyleBackColor = false;
            // 
            // Btnkitapekle
            // 
            this.Btnkitapekle.BackColor = System.Drawing.Color.Turquoise;
            this.Btnkitapekle.Location = new System.Drawing.Point(30, 28);
            this.Btnkitapekle.Name = "Btnkitapekle";
            this.Btnkitapekle.Size = new System.Drawing.Size(246, 51);
            this.Btnkitapekle.TabIndex = 2;
            this.Btnkitapekle.Text = "Kitap ekleme";
            this.Btnkitapekle.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btnemanet_iade);
            this.groupBox3.Controls.Add(this.Btnemanetliste);
            this.groupBox3.Controls.Add(this.Btnemanetverne);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(14, 205);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(292, 181);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // Btnemanet_iade
            // 
            this.Btnemanet_iade.BackColor = System.Drawing.Color.Turquoise;
            this.Btnemanet_iade.Location = new System.Drawing.Point(38, 114);
            this.Btnemanet_iade.Name = "Btnemanet_iade";
            this.Btnemanet_iade.Size = new System.Drawing.Size(205, 43);
            this.Btnemanet_iade.TabIndex = 2;
            this.Btnemanet_iade.Text = "Emanet Kitap İadesi\r\n\r\n";
            this.Btnemanet_iade.UseVisualStyleBackColor = false;
            // 
            // Btnemanetliste
            // 
            this.Btnemanetliste.BackColor = System.Drawing.Color.Turquoise;
            this.Btnemanetliste.Location = new System.Drawing.Point(38, 71);
            this.Btnemanetliste.Name = "Btnemanetliste";
            this.Btnemanetliste.Size = new System.Drawing.Size(205, 37);
            this.Btnemanetliste.TabIndex = 1;
            this.Btnemanetliste.Text = "Emanet Kitap Listeleme\r\n";
            this.Btnemanetliste.UseVisualStyleBackColor = false;
            // 
            // Btnemanetverne
            // 
            this.Btnemanetverne.BackColor = System.Drawing.Color.Turquoise;
            this.Btnemanetverne.Location = new System.Drawing.Point(38, 28);
            this.Btnemanetverne.Name = "Btnemanetverne";
            this.Btnemanetverne.Size = new System.Drawing.Size(205, 37);
            this.Btnemanetverne.TabIndex = 0;
            this.Btnemanetverne.Text = "Emanet Kitap Verme";
            this.Btnemanetverne.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnGrafik);
            this.groupBox4.Controls.Add(this.Btnsiralama);
            this.groupBox4.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(315, 205);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(292, 181);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve Grafikler";
            // 
            // BtnGrafik
            // 
            this.BtnGrafik.BackColor = System.Drawing.Color.Turquoise;
            this.BtnGrafik.Location = new System.Drawing.Point(42, 92);
            this.BtnGrafik.Name = "BtnGrafik";
            this.BtnGrafik.Size = new System.Drawing.Size(217, 50);
            this.BtnGrafik.TabIndex = 1;
            this.BtnGrafik.Text = "Grafikler";
            this.BtnGrafik.UseVisualStyleBackColor = false;
            // 
            // Btnsiralama
            // 
            this.Btnsiralama.BackColor = System.Drawing.Color.Turquoise;
            this.Btnsiralama.Location = new System.Drawing.Point(42, 25);
            this.Btnsiralama.Name = "Btnsiralama";
            this.Btnsiralama.Size = new System.Drawing.Size(217, 50);
            this.Btnsiralama.TabIndex = 0;
            this.Btnsiralama.Text = "Sıralama";
            this.Btnsiralama.UseVisualStyleBackColor = false;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(619, 418);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AnaSayfa";
            this.Text = "anaSayfa";
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
       //     this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btnuyelistele;
        private System.Windows.Forms.Button BtnUyeEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btnkitaplistele;
        private System.Windows.Forms.Button Btnkitapekle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btnemanet_iade;
        private System.Windows.Forms.Button Btnemanetliste;
        private System.Windows.Forms.Button Btnemanetverne;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnGrafik;
        private System.Windows.Forms.Button Btnsiralama;
    }
}

