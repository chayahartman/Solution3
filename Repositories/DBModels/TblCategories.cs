using System;
using System.Collections.Generic;

namespace Repositories.DBModels
{
    public partial class TblCategories
    {
        public TblCategories()
        {
            TblClothes = new HashSet<TblClothes>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public TblCategories(string name)
        {
            this.CategoryName = name;
        }

        public ICollection<TblClothes> TblClothes { get; set; }
    }
}
