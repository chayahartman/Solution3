using Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
  public interface IBuyingService
    {
        void InsertSale(int custId,List<shooping_basket> sb);
        void InsertSaleDetails(List<shooping_basket> sb);
        void UpdateAmount(List<shooping_basket> sb);
    }
}
