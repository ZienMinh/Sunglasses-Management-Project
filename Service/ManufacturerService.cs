using Repositories.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ManufactureService
    {
        private ManufacturerRepository repo;
        public List<Manufacturer> GetAllCategories()
        {
            repo = new ManufacturerRepository();
            return repo.GetAll();
        }
    }
}
