using System;
using System.Collections.Generic;

namespace Repositories.DBModels
{
    public partial class TblSalesDetails
    {
        public int SaleDetailsId { get; set; }
        public int? SaleId { get; set; }
        public int? ClothId { get; set; }
        public int? ClothAmount { get; set; }

        public TblClothes Cloth { get; set; }
        public TblSales Sale { get; set; }
    }
}
