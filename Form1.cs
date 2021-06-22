using LiteDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using WeifenLuo.WinFormsUI.Docking;

namespace Muhasebe
{
    public partial class Form1 : Form
    {

        private Data<Fis> fisler=new Data<Fis>();
   

        public Form1()
        {
            InitializeComponent();
        }

        private void muşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriEkle me = new MusteriEkle();
            me.Show();
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
            var theme = new VS2015BlueTheme();
            this.dockPanel1.Theme = theme;
            Sabitler.dockpanel = dockPanel1;
            MusterilerForm f1 = new MusterilerForm();
            f1.Show(dockPanel1, DockState.DockLeft);
            Fisler f2 = new Fisler();
            f2.Show(dockPanel1, DockState.Document);
            OdemeForm tf = new OdemeForm();
            tf.Show(dockPanel1, DockState.DockRightAutoHide);
            GenelToplamlar f3 = new GenelToplamlar();
            f3.Show(dockPanel1, DockState.DockBottom);

          
    }

        private void müşteriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Sabitler.musteri != null)
            {
                MusteriGuncelle mg = new MusteriGuncelle(Sabitler.musteri);
                mg.Show();
                Sabitler.fislerLoad();

            }
            else {

                MessageBox.Show("Müşteri Seçiniz");

            }
        }

     
       

        private void kurBilgileriniManuelGirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KurAl kur = new KurAl();
            kur.Show();
        }

        

        private void fişEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FisEkleGuncelle fs = new FisEkleGuncelle(Sabitler.musteri, 0);
            fs.Show();
        }

        

        private void fişSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        if (Sabitler.fis != null)
            {
                if (fisler.DeleteSingle(Sabitler.fis.ID))
                {
                    MessageBox.Show("Başarıyla Silindi");
                }
                else { MessageBox.Show("Hata Oluştu"); }
            }
            else { MessageBox.Show("Fiş Seçiniz"); }
        }

        private void fişDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Sabitler.fis != null)
            {
                FisEkleGuncelle fg = new FisEkleGuncelle(Sabitler.fis, 1);
                fg.Show();
       
            }
            else
            {
                MessageBox.Show("Fiş Seçiniz");

            }

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Veritabanı (*.db)|";
            openFileDialog1.ShowDialog();
            try {
                if (!string.IsNullOrEmpty(openFileDialog1.FileName)) { 
                Sabitler.db = @"Filename=" + openFileDialog1.FileName + ";Connection=shared";
                Sabitler.musteriLoad();
                }
            }
            catch { MessageBox.Show("Geçerli Bir Veritabanı Seçiniz"); }


        }
    }
}
