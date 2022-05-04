using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
   public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T Obj);
        void Update(T Obj);
       // void Delete(T obj);
       void DeleteById(int id);
    }
}
