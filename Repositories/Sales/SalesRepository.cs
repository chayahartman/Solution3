using System;
using System.Collections.Generic;
using System.Text;
using Repositories.DBModels;

namespace Repositories
{
   public  class SalesRepository : ISalesRepository
    {
        clothes_storeContext con;
        public SalesRepository(clothes_storeContext con)
        {
            this.con = con;
        }
       
        public void insert(int custId, List<shooping_basket> sb)
        {
            double sum = 0;
            for (int i = 0; i < sb.Count; i++)
            {
                  sum += sb[i].FinalPrice;
            }
           
            con.TblSales.Add(new TblSales() { CustomerId=custId,SaleDate=DateTime.Now,SalePayment=sum}) ;
            con.SaveChanges();  
           
        }
        
      
    }
}
