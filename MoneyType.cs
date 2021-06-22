using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{

 public class MoneyType
    {


        public enum Money
        {
  
            TL = 0,
            USD = 1,
            EUR = 2,
            GBP = 3
        
        }

        public Money moneyType { get; set; }
        public double price { get; set; }


    }
}
