namespace kutuphanefinal_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kİŞİİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kisiIsemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPİŞLEMLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kİTAPVERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kİŞİİŞLEMLERİToolStripMenuItem,
            this.kİTAPİŞLEMLERİToolStripMenuItem,
            this.kİTAPVERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kİŞİİŞLEMLERİToolStripMenuItem
            // 
            this.kİŞİİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kisiIsemleriToolStripMenuItem,
            this.kitaplarToolStripMenuItem});
            this.kİŞİİŞLEMLERİToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kİŞİİŞLEMLERİToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kİŞİİŞLEMLERİToolStripMenuItem.Image")));
            this.kİŞİİŞLEMLERİToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kİŞİİŞLEMLERİToolStripMenuItem.Name = "kİŞİİŞLEMLERİToolStripMenuItem";
            this.kİŞİİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.kİŞİİŞLEMLERİToolStripMenuItem.Text = "KİŞİ İŞLEMLERİ";
            // 
            // kisiIsemleriToolStripMenuItem
            // 
            this.kisiIsemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kisiIsemleriToolStripMenuItem.Image")));
            this.kisiIsemleriToolStripMenuItem.Name = "kisiIsemleriToolStripMenuItem";
            this.kisiIsemleriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kisiIsemleriToolStripMenuItem.Text = "KİŞİ İŞLEMLERİ";
            this.kisiIsemleriToolStripMenuItem.Click += new System.EventHandler(this.kisiIsemleriToolStripMenuItem_Click);
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitaplarToolStripMenuItem.Image")));
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kitaplarToolStripMenuItem.Text = "KİŞİLER";
            this.kitaplarToolStripMenuItem.Click += new System.EventHandler(this.kitaplarToolStripMenuItem_Click);
            // 
            // kİTAPİŞLEMLERİToolStripMenuItem
            // 
            this.kİTAPİŞLEMLERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapİşlemleriToolStripMenuItem,
            this.kitaplarToolStripMenuItem1});
            this.kİTAPİŞLEMLERİToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kİTAPİŞLEMLERİToolStripMenuItem.Image")));
            this.kİTAPİŞLEMLERİToolStripMenuItem.Name = "kİTAPİŞLEMLERİToolStripMenuItem";
            this.kİTAPİŞLEMLERİToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.kİTAPİŞLEMLERİToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.kİTAPİŞLEMLERİToolStripMenuItem.Text = "KİTAP İŞLEMLERİ";
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kitapİşlemleriToolStripMenuItem.Image")));
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.kitapİşlemleriToolStripMenuItem.Text = "KİTAP İŞLEMLERİ";
            this.kitapİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kitapİşlemleriToolStripMenuItem_Click);
            // 
            // kitaplarToolStripMenuItem1
            // 
            this.kitaplarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kitaplarToolStripMenuItem1.Image")));
            this.kitaplarToolStripMenuItem1.Name = "kitaplarToolStripMenuItem1";
            this.kitaplarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.kitaplarToolStripMenuItem1.Text = "KİTAPLAR";
            this.kitaplarToolStripMenuItem1.Click += new System.EventHandler(this.kitaplarToolStripMenuItem1_Click);
            // 
            // kİTAPVERToolStripMenuItem
            // 
            this.kİTAPVERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teslimAlToolStripMenuItem,
            this.teslimVerToolStripMenuItem});
            this.kİTAPVERToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kİTAPVERToolStripMenuItem.Image")));
            this.kİTAPVERToolStripMenuItem.Name = "kİTAPVERToolStripMenuItem";
            this.kİTAPVERToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.kİTAPVERToolStripMenuItem.Text = "KİTAP VER";
            // 
            // teslimAlToolStripMenuItem
            // 
            this.teslimAlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("teslimAlToolStripMenuItem.Image")));
            this.teslimAlToolStripMenuItem.Name = "teslimAlToolStripMenuItem";
            this.teslimAlToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.teslimAlToolStripMenuItem.Text = "TESLİM ET";
            this.teslimAlToolStripMenuItem.Click += new System.EventHandler(this.teslimAlToolStripMenuItem_Click);
            // 
            // teslimVerToolStripMenuItem
            // 
            this.teslimVerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("teslimVerToolStripMenuItem.Image")));
            this.teslimVerToolStripMenuItem.Name = "teslimVerToolStripMenuItem";
            this.teslimVerToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.teslimVerToolStripMenuItem.Text = "TESLİM AL";
            this.teslimVerToolStripMenuItem.Click += new System.EventHandler(this.teslimVerToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(568, 373);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "kutuphaneOtomasyon";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kİŞİİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kisiIsemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPİŞLEMLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kİTAPVERToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teslimAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teslimVerToolStripMenuItem;
    }
}

