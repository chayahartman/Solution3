using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
   public interface ICategoriesService
    {
        List<Categories> GetList();
        Categories GetCategoryById(int id);
        void Create(Categories c);
        void Update(Categories c);
        void DeleteById(int id);

    }
}
