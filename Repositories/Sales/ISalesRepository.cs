using Repositories.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
  public interface ISalesRepository
    {
        void insert(int custId, List<shooping_basket> sb);
    }
}
