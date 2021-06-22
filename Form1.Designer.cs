namespace Muhasebe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fişEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fişDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fişSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fişDökümRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçiliMüşteriyeGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarihAralığınaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurBilgileriniManuelGirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.faturalarToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.kurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muşteriEkleToolStripMenuItem,
            this.müşteriDüzenleToolStripMenuItem,
            this.müşteriSilToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // muşteriEkleToolStripMenuItem
            // 
            this.muşteriEkleToolStripMenuItem.Name = "muşteriEkleToolStripMenuItem";
            this.muşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.muşteriEkleToolStripMenuItem.Text = "Muşteri Ekle";
            this.muşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.muşteriEkleToolStripMenuItem_Click);
            // 
            // müşteriDüzenleToolStripMenuItem
            // 
            this.müşteriDüzenleToolStripMenuItem.Name = "müşteriDüzenleToolStripMenuItem";
            this.müşteriDüzenleToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.müşteriDüzenleToolStripMenuItem.Text = "Müşteri Düzenle";
            this.müşteriDüzenleToolStripMenuItem.Click += new System.EventHandler(this.müşteriDüzenleToolStripMenuItem_Click);
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.müşteriSilToolStripMenuItem.Text = "Müşteri Sil";
            // 
            // faturalarToolStripMenuItem
            // 
            this.faturalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fişEkleToolStripMenuItem,
            this.fişDüzenleToolStripMenuItem,
            this.fişSilToolStripMenuItem});
            this.faturalarToolStripMenuItem.Name = "faturalarToolStripMenuItem";
            this.faturalarToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.faturalarToolStripMenuItem.Text = "Fişler";
            // 
            // fişEkleToolStripMenuItem
            // 
            this.fişEkleToolStripMenuItem.Name = "fişEkleToolStripMenuItem";
            this.fişEkleToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fişEkleToolStripMenuItem.Text = "Fiş Ekle";
            this.fişEkleToolStripMenuItem.Click += new System.EventHandler(this.fişEkleToolStripMenuItem_Click);
            // 
            // fişDüzenleToolStripMenuItem
            // 
            this.fişDüzenleToolStripMenuItem.Name = "fişDüzenleToolStripMenuItem";
            this.fişDüzenleToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fişDüzenleToolStripMenuItem.Text = "Fiş Düzenle";
            this.fişDüzenleToolStripMenuItem.Click += new System.EventHandler(this.fişDüzenleToolStripMenuItem_Click);
            // 
            // fişSilToolStripMenuItem
            // 
            this.fişSilToolStripMenuItem.Name = "fişSilToolStripMenuItem";
            this.fişSilToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fişSilToolStripMenuItem.Text = "Fiş Sil";
            this.fişSilToolStripMenuItem.Click += new System.EventHandler(this.fişSilToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fişDökümRaporuToolStripMenuItem,
            this.seçiliMüşteriyeGöreToolStripMenuItem,
            this.tarihAralığınaGöreToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // fişDökümRaporuToolStripMenuItem
            // 
            this.fişDökümRaporuToolStripMenuItem.Name = "fişDökümRaporuToolStripMenuItem";
            this.fişDökümRaporuToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.fişDökümRaporuToolStripMenuItem.Text = "Fiş Döküm Raporu";
            // 
            // seçiliMüşteriyeGöreToolStripMenuItem
            // 
            this.seçiliMüşteriyeGöreToolStripMenuItem.Name = "seçiliMüşteriyeGöreToolStripMenuItem";
            this.seçiliMüşteriyeGöreToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.seçiliMüşteriyeGöreToolStripMenuItem.Text = "Seçili Müşteriye Göre";
            // 
            // tarihAralığınaGöreToolStripMenuItem
            // 
            this.tarihAralığınaGöreToolStripMenuItem.Name = "tarihAralığınaGöreToolStripMenuItem";
            this.tarihAralığınaGöreToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tarihAralığınaGöreToolStripMenuItem.Text = "Tarih Aralığına Göre";
            // 
            // kurToolStripMenuItem
            // 
            this.kurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kurBilgileriniManuelGirToolStripMenuItem});
            this.kurToolStripMenuItem.Name = "kurToolStripMenuItem";
            this.kurToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.kurToolStripMenuItem.Text = "Kur";
            // 
            // kurBilgileriniManuelGirToolStripMenuItem
            // 
            this.kurBilgileriniManuelGirToolStripMenuItem.Name = "kurBilgileriniManuelGirToolStripMenuItem";
            this.kurBilgileriniManuelGirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.kurBilgileriniManuelGirToolStripMenuItem.Text = "Kur Bilgilerini Manuel Gir";
            this.kurBilgileriniManuelGirToolStripMenuItem.Click += new System.EventHandler(this.kurBilgileriniManuelGirToolStripMenuItem_Click);
            // 
            // dockPanel1
            // 
            this.dockPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 24);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(781, 426);
            this.dockPanel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(781, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel1.Text = "USD";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel2.Text = "0.0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel3.Text = "EUR";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel4.Text = "0.0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel5.Text = "GBP";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(22, 17);
            this.toolStripStatusLabel6.Text = "0.0";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel7.Text = "Kur Tarihi:";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel8.Text = "--/--/----";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.dosyaToolStripMenuItem.Text = "Veritabanı";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muhasebe  V1.0A";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurBilgileriniManuelGirToolStripMenuItem;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fişSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fişEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fişDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fişDökümRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçiliMüşteriyeGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarihAralığınaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
    }
}

