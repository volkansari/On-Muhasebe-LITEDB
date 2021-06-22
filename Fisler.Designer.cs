namespace Muhasebe
{
    partial class Fisler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fisler));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fişiDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fişiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.advancedDataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayıGösterToolStripMenuItem,
            this.fişiDüzenleToolStripMenuItem,
            this.fişiSilToolStripMenuItem,
            this.yazdırToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // detayıGösterToolStripMenuItem
            // 
            this.detayıGösterToolStripMenuItem.Name = "detayıGösterToolStripMenuItem";
            this.detayıGösterToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.detayıGösterToolStripMenuItem.Text = "Detayı Göster";
            this.detayıGösterToolStripMenuItem.Click += new System.EventHandler(this.detayıGösterToolStripMenuItem_Click);
            // 
            // fişiDüzenleToolStripMenuItem
            // 
            this.fişiDüzenleToolStripMenuItem.Name = "fişiDüzenleToolStripMenuItem";
            this.fişiDüzenleToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.fişiDüzenleToolStripMenuItem.Text = "Fişi Düzenle";
            this.fişiDüzenleToolStripMenuItem.Click += new System.EventHandler(this.fişiDüzenleToolStripMenuItem_Click);
            // 
            // fişiSilToolStripMenuItem
            // 
            this.fişiSilToolStripMenuItem.Name = "fişiSilToolStripMenuItem";
            this.fişiSilToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.fişiSilToolStripMenuItem.Text = "Fişi Sil";
            this.fişiSilToolStripMenuItem.Click += new System.EventHandler(this.fişiSilToolStripMenuItem_Click);
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            this.yazdırToolStripMenuItem.Click += new System.EventHandler(this.yazdırToolStripMenuItem_Click);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(805, 670);
            this.dockPanel1.TabIndex = 1;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AllowUserToDeleteRows = false;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.ReadOnly = true;
            this.advancedDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advancedDataGridView1.Size = new System.Drawing.Size(805, 670);
            this.advancedDataGridView1.TabIndex = 5;
            this.advancedDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellClick_1);
            this.advancedDataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridView1_CellDoubleClick_1);
            // 
            // Fisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 670);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.dockPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fisler";
            this.Text = "Detaylı Fiş Görünümü";
            this.Load += new System.EventHandler(this.Fisler_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detayıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fişiDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fişiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
        private System.Windows.Forms.DataGridView advancedDataGridView1;
    }
}