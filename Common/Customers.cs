using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
  public  class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPassword { get; set; }
        public string CreditCardNum { get; set; }
        public DateTime? CreditCardTokef { get; set; }
        public int? CreditCardNumBehind { get; set; }

    }
}
