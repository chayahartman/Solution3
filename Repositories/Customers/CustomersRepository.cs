using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositories.DBModels;

namespace Repositories
{
    public class CustomersRepository : ICustomersRepository
    {
        clothes_storeContext context;
        public CustomersRepository(clothes_storeContext context)
        {
            this.context = context;
        }
        public void Create(TblCustomers Obj)
        {
            if (!isExists(Obj.CustomerName, Obj.CustomerPassword))
            {
                context.TblCustomers.Add(Obj);
                context.SaveChanges();
            }
            
        }

        public bool isExists(string name, string password)
        {
            foreach (var itm in context.TblCustomers)
            {
                if (itm.CustomerPassword.Equals(password) && itm.CustomerName.Equals(name))
                    return true;
            }
            return false;
        }

        public int getByName(string name)
        {

            return context.TblCustomers.FirstOrDefault(u => u.CustomerName.Equals(name)).CustomerId;
        }

       
    }
}
