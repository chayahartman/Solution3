using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Repositories.DBModels;

namespace Repositories
{
    public class CategoryRepository : ICategoriesRepository
    {
        clothes_storeContext Context;
        public CategoryRepository(clothes_storeContext Context)
        {
            this.Context = Context;
        }
        public void Create(string name)
        {
            //  Context.TblCategories.Add(Obj);
            Context.TblCategories.Add(new TblCategories(name));
            var result = Context.SaveChanges();
        }

        public void Create(TblCategories Obj)
        {
            Context.TblCategories.Add(Obj);
            var result = Context.SaveChanges(); 
        }

        

        public void DeleteById(int id)
        {
            try
            { 
            Context.TblCategories.Remove(Context.TblCategories.First(c => c.CategoryId == id));
            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally { 
                var result = Context.SaveChanges();
            }
        }

        public List<TblCategories> GetAll()
        {
            return Context.TblCategories.ToList();
        }

        public TblCategories GetById(int id)
        {
            return Context.TblCategories.First(c=>c.CategoryId==id);
        }

        public void Update(TblCategories Obj)
        {
            Context.TblCategories.Update(Obj);
           
            //foreach (var item in Context.TblCategories)
            //{
            //    if (item.CategoryId == Obj.CategoryId)
            //    {
            //        item.CategoryName = Obj.CategoryName;
            //        item.CategoryId = Obj.CategoryId;
            //        break;
            //    }


            //}
            Context.SaveChanges();
        }
      }
    
}
