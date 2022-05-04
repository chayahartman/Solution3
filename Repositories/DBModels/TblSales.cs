using System;
using System.Collections.Generic;

namespace Repositories.DBModels
{
    public partial class TblSales
    {
        public TblSales()
        {
            TblSalesDetails = new HashSet<TblSalesDetails>();
        }


        public int SaleId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? SaleDate { get; set; }
        public double? SalePayment { get; set; }

        public TblCustomers Customer { get; set; }
        public ICollection<TblSalesDetails> TblSalesDetails { get; set; }
    }
}
