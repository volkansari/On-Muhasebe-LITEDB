using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{
    public class GenelToplam
    {

        [DisplayName("USD Toplam")]
        public double USDToplamBakiye { get; set; }
        [DisplayName("EUR Toplam")]
        public double EURToplamBakiye { get; set; }
        [DisplayName("GBP Toplam")]
        public double GBPToplamBakiye { get; set; }
        [DisplayName("TL Toplam")]
        public double TLToplamBakiye { get; set; }
        [DisplayName("Genel TL Toplam")]
        public double GenelTLToplamBakiye { get; set; }
        [DisplayName("Toplam Kur Farkı")]
        public double ToplamKurFarki { get; set; }

    }
}
