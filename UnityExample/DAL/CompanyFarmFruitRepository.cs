using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityExample.Common;
using UnityExample.Interfaces;

namespace UnityExample.DAL
{
    public class CompanyFarmFruitRepository : IFruitsRepository
    {
        public List<FruitModel> GetAll()
        {
            List<FruitModel> fruits = new List<FruitModel>()
            {
                new FruitModel(){FruitId = 1, Count = 10, FruitName = "Honeydew" },
                new FruitModel(){FruitId = 2, Count = 15, FruitName = "Jackfruit" },
                new FruitModel(){FruitId = 3, Count = 13, FruitName = "Kiwi" },
                new FruitModel(){FruitId = 4, Count = 5, FruitName = "Lychee" },
                new FruitModel(){FruitId = 5, Count = 2, FruitName = "Mango" }
            };
            return fruits;
        }

        public bool Update(List<FruitModel> fruits)
        {
            //*** Some repository to update datastore
            return true;
        }
    }
}
