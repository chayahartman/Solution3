using System;
using System.Collections.Generic;

namespace Repositories.DBModels
{
    public partial class TblCustomers
    {
        public TblCustomers()
        {
            TblSales = new HashSet<TblSales>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPassword { get; set; }
        public string CreditCardNum { get; set; }
        public DateTime? CreditCardTokef { get; set; }
        public int? CreditCardNumBehind { get; set; }

        public ICollection<TblSales> TblSales { get; set; }
    }
}
