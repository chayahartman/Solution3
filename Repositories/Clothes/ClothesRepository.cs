using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repositories.DBModels;
using Xceed.Wpf.Toolkit;

namespace Repositories
{
    public class ClothesRepository : IClothesRepository
    {
        clothes_storeContext context;
        public ClothesRepository(clothes_storeContext context)
        {
            this.context = context;
        }
        public void Create(TblClothes Obj)
        {
            context.TblClothes.Add(Obj);
            context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            context.TblClothes.Remove(context.TblClothes.First(c => c.ClothId == id));
            var result = context.SaveChanges();
           
        }

        public List<TblClothes> GetAll()
        {
            return context.TblClothes.ToList();
            //Include(cat=>cat.Category.CategoryName)
        }

        public List<TblClothes> GetByCategory(int Categoryid)
        {
            List<TblClothes> l = new List<TblClothes>();
            foreach(var itm in context.TblClothes)
            {
                if (itm.CategoryId == Categoryid)
                {
                    l.Add(itm);
                    
                }

            }
           // l.Add(context.TblClothes.Where(c => c.CategoryId == id);
            return l;
        }

        public TblClothes GetById(int id)
        {
            return context.TblClothes.FirstOrDefault(c=>c.ClothId==id) ;
        }

        public void Update(TblClothes Obj)
        {
            context.TblClothes.Update(Obj);
            context.SaveChanges();
     
        }

        public void UpdateAmount(List<shooping_basket> sb)
        {
            for (int i = 0; i < sb.Count; i++)
            {
                
                context.TblClothes.FirstOrDefault(c => c.ClothId == sb[i].ClothingID).ClothAmount-=sb[i].Amount;
                    

            }

            context.SaveChanges();
        }

        public int CheckAmount(int id)
        {
            int sum = 0;
           
            sum= context.TblClothes.FirstOrDefault(cl => cl.ClothId == id).ClothAmount;


            return sum;
             

           

           
        }
    }
}
