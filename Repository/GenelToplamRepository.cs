using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.Repository
{
    public class GenelToplamRepository
    {
        private List<GenelToplam> geneltoplam;
        private Data<Fis> dt;
        private Data<Taksit> taksitdt;


        public List<GenelToplam>  GenelToplamlar(Musteri musteri) {

            dt = new Data<Fis>();
            List<Fis> fisler = dt.GetAll().Where(x => x.Musteri.ID.Equals(musteri.ID)).ToList();
            taksitdt = new Data<Taksit>();
            List<Taksit> taksitler = taksitdt.GetAll();
            geneltoplam = new List<GenelToplam>();
            double USDToplamBakiye = 0d, GBPToplamBakiye = 0d, EURToplamBakiye = 0d, TLToplamBakiye = 0d, ToplamKurFarki = 0d, GenelTLToplam = 0d;
            foreach (Fis fis in fisler)
            {
                switch (fis.TutarCinsi)
                {
                    case MoneyType.Money.TL:
                        if (fis.Fistipi.Equals(Fis.FisTipi.Alacak))
                        {
                            double a = fis.Tutar - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.Tutar);
                            TLToplamBakiye += a;
                            GenelTLToplam += a;
                        }
                        else
                        {
                            double a = fis.Tutar - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.Tutar);
                            TLToplamBakiye -= a;
                            GenelTLToplam -= a;
                        }
                        break;

                    case MoneyType.Money.USD:
                        if (fis.Fistipi.Equals(Fis.FisTipi.Alacak))
                        {
                            USDToplamBakiye += fis.Tutar - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.Tutar);
                            GenelTLToplam += fis.KurTutari - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.KurTutari);
                            ToplamKurFarki += Math.Abs(fis.KurTutari - (Helper.generalMoneyList.Find(x => x.moneyType.Equals(MoneyType.Money.USD)).price * fis.Tutar));
                        }
                        else
                        {

                            USDToplamBakiye -= fis.Tutar - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.Tutar);
                            GenelTLToplam -= fis.KurTutari - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.KurTutari);
                            ToplamKurFarki -= Math.Abs(fis.KurTutari - (Helper.generalMoneyList.Find(x => x.moneyType.Equals(MoneyType.Money.USD)).price * fis.Tutar));
                        }
                        break;
                    case MoneyType.Money.EUR:
                        if (fis.Fistipi.Equals(Fis.FisTipi.Alacak))
                        {
                            EURToplamBakiye += fis.Tutar - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.Tutar);
                            GenelTLToplam += fis.KurTutari - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.KurTutari);
                            ToplamKurFarki += Math.Abs(fis.KurTutari - (Helper.generalMoneyList.Find(x => x.moneyType.Equals(MoneyType.Money.EUR)).price * fis.Tutar));
                        }
                        else
                        {
                            EURToplamBakiye -= fis.Tutar - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.Tutar);
                            GenelTLToplam -= fis.KurTutari - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.KurTutari);
                            ToplamKurFarki -= Math.Abs(fis.KurTutari - (Helper.generalMoneyList.Find(x => x.moneyType.Equals(MoneyType.Money.EUR)).price * fis.Tutar));
                        }
                        break;

                    case MoneyType.Money.GBP:
                        if (fis.Fistipi.Equals(Fis.FisTipi.Alacak))
                        {
                            GBPToplamBakiye += fis.Tutar - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.Tutar);
                            GenelTLToplam += fis.KurTutari - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.KurTutari);
                            ToplamKurFarki += Math.Abs(fis.KurTutari - (Helper.generalMoneyList.Find(x => x.moneyType.Equals(MoneyType.Money.GBP)).price * fis.Tutar));


                        }
                        else
                        {
                            GBPToplamBakiye -= fis.Tutar - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.Tutar);
                            GenelTLToplam -= fis.KurTutari - taksitler.Where(x => x.Fis.ID.Equals(fis.ID)).Sum(x => x.KurTutari);
                            ToplamKurFarki -= Math.Abs(fis.KurTutari - (Helper.generalMoneyList.Find(x => x.moneyType.Equals(MoneyType.Money.GBP)).price * fis.Tutar));


                        }
                        break;
                }


            }

            return null;

        }


    }
}
