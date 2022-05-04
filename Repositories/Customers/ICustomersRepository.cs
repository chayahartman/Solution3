using Repositories.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
   public interface ICustomersRepository
    {
        bool isExists(string name, string password);
        void Create(TblCustomers Obj);
        int getByName(string name);

    }
}
