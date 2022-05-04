using System;
using System.Collections.Generic;

namespace Repositories.DBModels
{
    public partial class TblClothes
    {
        public TblClothes()
        {
            TblSalesDetails = new HashSet<TblSalesDetails>();
        }

        public int ClothId { get; set; }
        public string ClothName { get; set; }
        public int? CategoryId { get; set; }
        public double? ClothPrice { get; set; }
        public string ClothPic { get; set; }
        public string ClothColor { get; set; }
        public int? ClothSize { get; set; }
        public int ClothAmount { get; set; }

        public TblCategories Category { get; set; }
        public ICollection<TblSalesDetails> TblSalesDetails { get; set; }
    }
}
