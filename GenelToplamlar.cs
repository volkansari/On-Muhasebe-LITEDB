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
    public partial class GenelToplamlar : DockContent
    {

       private List<GenelToplam> geneltoplam;
       private Data<Fis> dt;
        private Data<Taksit> taksitdt;

        public GenelToplamlar()
        {
            InitializeComponent();
        }

        private void GenelToplamlar_Load(object sender, EventArgs e)
        {
            
            Sabitler.genelToplam = load;
        }

        public void load(Musteri musteri) {

            dt = new Data<Fis>();
            List<Fis> fisler = dt.GetAll().Where(x=>x.Musteri.ID.Equals(musteri.ID)).ToList();
            taksitdt = new Data<Taksit>();
            List<Taksit> taksitler = taksitdt.GetAll();
            geneltoplam = new List<GenelToplam>();
            double USDToplamBakiye = 0d, GBPToplamBakiye = 0d, EURToplamBakiye = 0d, TLToplamBakiye = 0d, ToplamKurFarki = 0d,GenelTLToplam=0d; 
            foreach (Fis fis in fisler) {
                switch (fis.TutarCinsi) {
                    case MoneyType.Money.TL:
                        if (fis.Fistipi.Equals(Fis.FisTipi.Alacak)) {
                            TLToplamBakiye += fis.KalanBakiye;
                            GenelTLToplam += fis.KalanBakiye;
                        }
                        else {
                            TLToplamBakiye -= fis.KalanBakiye;
                            GenelTLToplam  -= fis.KalanBakiye;
                        }
                        break;

                    case MoneyType.Money.USD:
                        if (fis.Fistipi.Equals(Fis.FisTipi.Alacak))
                        {
                            USDToplamBakiye += fis.KalanBakiye;
                            GenelTLToplam += fis.KurTutari;
                        }
                        else {
                           
                            USDToplamBakiye -= fis.KalanBakiye;
                            GenelTLToplam -= fis.KurTutari;

                        }
                        break;
                    case MoneyType.Money.EUR:
                        if (fis.Fistipi.Equals(Fis.FisTipi.Alacak))
                        {
                            EURToplamBakiye +=  fis.KalanBakiye;
                            GenelTLToplam += fis.KurTutari; 
                        }
                        else
                        {
                            EURToplamBakiye -= fis.KalanBakiye;
                            GenelTLToplam -= fis.KurTutari;
                        }
                        break;

                    case MoneyType.Money.GBP:
                        if (fis.Fistipi.Equals(Fis.FisTipi.Alacak))
                        {
                            GBPToplamBakiye +=  fis.KalanBakiye;
                            GenelTLToplam += fis.KurTutari;


                        }
                        else
                        {
                            GBPToplamBakiye -= fis.KalanBakiye;
                            GenelTLToplam -= fis.KurTutari;


                        }
                        break;
                }
           
              
                }


            geneltoplam.Add(
                      new GenelToplam
                      {
                          TLToplamBakiye = Math.Round(TLToplamBakiye, 2),
                          USDToplamBakiye = Math.Round(USDToplamBakiye, 2),
                          EURToplamBakiye = Math.Round(EURToplamBakiye, 2),
                          GBPToplamBakiye = Math.Round(GBPToplamBakiye, 2),

                          GenelTLToplamBakiye = Math.Round(GenelTLToplam, 2),
                          ToplamKurFarki = Math.Round(ToplamKurFarki, 2)
                      });

            dataGridView1.DataSource = geneltoplam;
    



        }
    }
}
