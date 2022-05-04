using Repositories.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
   public interface ICategoriesRepository:IRepository<TblCategories>
    {
        void Create(string name);
       // List<TblCategories>()
    }
}
