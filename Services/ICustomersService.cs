using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
   public interface ICustomersService
    {
        bool IsExists(string name,string password);
        void create(Customers c);

        int GetByname(string name);
    }
}
