using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Muhasebe
{
    public partial class Fisler : DockContent
    {
        Data<Fis> dt;
        Data<Taksit> taksitler;
        List<Fis> fisler;
        List<Fis> fislerAlacak;
        Musteri musteri;
        private BindingSource source=new BindingSource();
   

        public Fisler()
        {
            InitializeComponent();
        }

        public Fisler(Musteri musteri)
        {
            this.musteri = musteri;
            InitializeComponent();
            load();

        }



        public void load(){
            
            dt = new Data<Fis>();
            taksitler = new Data<Taksit>();
            if (Sabitler.musteri!= null) fisler = dt.GetAll().Where(x => x.Musteri.ID == Sabitler.musteri.ID).OrderBy(x => x.Tarih).ToList();
            if (fisler != null) { 
            foreach (Fis fis in fisler)
                {
                    fis.KalanBakiye = fis.Tutar - taksitler.GetAll().Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.Tutar);
                
                    if (fis.KalanBakiye == 0) {
                        foreach (MoneyType mn in Helper.generalMoneyList)
                        {

                            if (fis.TutarCinsi == mn.moneyType)
                            {
                                // if (fis.Fistipi.Equals(Fis.FisTipi.Alacak)) { fis.KurFarki = Math.Round((fis.Kur - mn.price) * fis.Tutar, 4); }
                                 //else { fis.KurFarki = Math.Round((mn.price - fis.Kur) * fis.Tutar, 4); }
                                fis.KurFarki = fis.KurTutari - taksitler.GetAll().Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.KurTutari);
                                MessageBox.Show(fis.KurTutari.ToString());
                                MessageBox.Show(taksitler.GetAll().Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.KurTutari).ToString());

                            }
                        }

                    }

                    
                }
            }
            Sabitler.genelToplam(Sabitler.musteri);
            source.DataSource = fisler;
            advancedDataGridView1.Tag = fisler;
            advancedDataGridView1.DataSource = source;
              


        } 
  

    



        private void Fisler_Load(object sender, EventArgs e)
        {
            Sabitler.fislerLoad = load;

        }

        private void fişiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {


            DataGridViewRow dr = advancedDataGridView1.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            Fis fis = dr.DataBoundItem as Fis;

            if (fis != null)
            {

                Data<Taksit> taksit = new Data<Taksit>();
             
                    foreach (Taksit _taksit in taksit.GetAll().FindAll(x => x.Fis.ID.Equals(fis.ID)))
                    {
                        taksit.DeleteSingle(_taksit.ID);
                    }
                    dt.DeleteSingle(fis.ID);
                advancedDataGridView1.Rows.Remove(dr);
                Sabitler.fislerLoad();
                Sabitler.taksitlerLoad();
                Sabitler.genelToplam(Sabitler.musteri);
            }
        }

        private void detayıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = advancedDataGridView1.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            Fis fis = dr.DataBoundItem as Fis;

            if (fis != null)
            {

                FisEkleGuncelle fg = new FisEkleGuncelle(fis, 2);
                fg.Show();
            }
        }

        private void fişiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = advancedDataGridView1.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            Fis fis = dr.DataBoundItem as Fis;

            if (fis != null)
            {

                FisEkleGuncelle fg = new FisEkleGuncelle(fis, 1);
                fg.Show();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void advancedDataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
            DataGridViewRow dr = advancedDataGridView1.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            Fis fis = dr.DataBoundItem as Fis;

            if (fis != null)
            {
           
                Sabitler.fis = fis;
                Sabitler.taksitlerLoad();
             
            }

           

        }

        private void advancedDataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = advancedDataGridView1.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            Fis fis = dr.DataBoundItem as Fis;

            if (fis != null)
            {
                Sabitler.fis = fis;
                FisEkleGuncelle fg = new FisEkleGuncelle(fis, 2);
                fg.Show();
            }

        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rapor rp = new Rapor();
            rp.Show();
        }

    

        private void advancedDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string value = e.Value as string;
    if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
    {
        e.Value = e.CellStyle.NullValue;
        e.FormattingApplied = true;
    }
        }
    }
    }


 
