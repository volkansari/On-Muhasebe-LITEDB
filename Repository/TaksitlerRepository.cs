
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{
    public  class DataRepository<Taksitler>
    {

        Data<Taksit> taksit = new Data<Taksit>();
        Data<Fis> fis= new Data<Fis>();
        List<Taksit> taksitler = new List<Taksit>();
        List<Fis> fisler = new List<Fis>();

        public  List<Taksit> getAllTaksitler(Fis fis) {
            taksitler = taksit.GetAll().Where(x => x.Fis.ID.Equals(fis.ID)).ToList();
            return taksitler;
        }

        public List<Taksit> getAllTaksitler(Musteri musteri)
        {
            fisler = fis.GetAll().Where(x => x.Musteri.ID.Equals(musteri.ID)).ToList();

            foreach(Fis fis in fisler) { 
           foreach(Taksit t in taksit.GetAll().Where(x=>x.Fis.ID.Equals(fis.ID))){

                taksitler.Add(t);
            };
            };

            return taksitler;
        }





    }
}
