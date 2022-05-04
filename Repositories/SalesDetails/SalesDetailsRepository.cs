using Repositories.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    public class SalesDetailsRepository : ISalesDetailsRepository
    {
        clothes_storeContext context;

        public SalesDetailsRepository(clothes_storeContext context)
        {
            this.context = context;
        }
        public void insert(List<shooping_basket> sb)
        {
            for (int i = 0; i < sb.Count; i++)
            {
                context.TblSalesDetails.Add(new TblSalesDetails() { SaleDetailsId = 0, SaleId = context.TblSales.Max(s => s.SaleId), ClothId = sb[i].ClothingID, ClothAmount = sb[i].Amount });
            }
            context.SaveChanges();
        }
    }
}
