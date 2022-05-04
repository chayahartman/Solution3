using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    class Sales
    {
        public int SaleId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? SaleDate { get; set; }
        public double? SalePayment { get; set; }
    }
}
