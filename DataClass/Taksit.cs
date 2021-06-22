using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{
  public  class Taksit:IDataColumn
    {
        [Browsable(false)]
        public LiteDB.ObjectId ID { get; set; }
        public DateTime Tarih { get; set; }
        public MoneyType.Money TutarCinsi { get; set; }
        public double Kur { get; set; }
        public double Tutar { get; set; }

        [Browsable(false)]
        public  Fis Fis{ get; set; }
        public double KurTutari { get; set; }
        public double KurFarki { get; set; }
    }
}
