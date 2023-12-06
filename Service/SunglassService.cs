using Repositories.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class SunglassService
    {
        private SunglassRepository _repo = new SunglassRepository();

        public List<Sunglass> GetAllSunglasses()
        {
            return _repo.GetAll();
        }
        public List<Sunglass> SearchSunglasses(string keyword)
        {
            return _repo.GetAll().Where(s => s.Material.ToLower().Contains(keyword.ToLower()) ||
                                             s.Feature.ToLower().Contains(keyword.ToLower())).ToList();
        }
        public void DeleteASunglass(int id)
        {
            _repo.Delete(id);
        }

        public Sunglass? GetASunglass(int id)
        {
            return _repo.Get(id);
        }

        public void UpdateASunglass(Sunglass sunglass)
        {
            _repo.Update(sunglass); //try-catch, validation
        }

        public void AddASunglass(Sunglass sunglass)
        {
            _repo.Create(sunglass); //try-catch, trùng mã số, bỏ trống ô nhập
        }
    }   
}
