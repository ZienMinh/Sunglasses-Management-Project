using Microsoft.EntityFrameworkCore;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class SunglassRepository
    {
        private Sunglasses2023DBContext context;

        public Sunglass? Get(int SunglassesId)
        {
            context = new Sunglasses2023DBContext();

            return context.Sunglasses.Find(SunglassesId);
        }

        public List<Sunglass> GetAll()
        {
            context = new Sunglasses2023DBContext();

            return context.Sunglasses.Include(cat => cat.Manufacturer).ToList();
        }

        public void Create(Sunglass sunglass)
        {
            context = new Sunglasses2023DBContext();
            context.Sunglasses.Add(sunglass);
            context.SaveChanges();
        }

        public void Update(Sunglass sunglass)
        {
            context = new Sunglasses2023DBContext();
            context.Sunglasses.Update(sunglass);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context = new Sunglasses2023DBContext();
            var sunglass = context.Sunglasses.FirstOrDefault(b => b.SunglassesId == id);

            if (sunglass != null)
            {
                context.Sunglasses.Remove(sunglass);
                context.SaveChanges();
            }
        }
    }
}
