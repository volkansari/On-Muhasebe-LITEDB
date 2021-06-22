using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Muhasebe
{
   public class Musteri
    { 
      
        public ObjectId ID { get; set; }
        public string sirket{ get; set; }
        public string TCKN { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string VergiNo{ get; set; }
        public string vergiDairesi { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
   
    }
}
