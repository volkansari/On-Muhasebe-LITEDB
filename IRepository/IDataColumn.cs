using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{
   public interface IDataColumn
    {
        [Browsable(false)]
        LiteDB.ObjectId ID { get; set; }
        DateTime Tarih { get; set; }
         double Tutar { get; set; }
        MoneyType.Money TutarCinsi { get; set; }
         double Kur { get; set; }
       double KurTutari { get; set; }
        double KurFarki { get; set; }


    }
}
