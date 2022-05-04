using Repositories.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface IClothesRepository : IRepository<TblClothes>
    {
        List<TblClothes> GetByCategory(int CategoryId);
        void UpdateAmount(List<shooping_basket> sb);
        int CheckAmount(int id);

    }
}
