using System.Collections.Generic;
using UnityExample.Common;
using UnityExample.Interfaces;

namespace UnityExample.DAL
{
    public class StorageFruitRepository : IFruitsRepository
    {
        public List<FruitModel> GetAll()
        {
            List<FruitModel> fruits = new List<FruitModel>()
            {
                new FruitModel(){FruitId = 1, Count = 10, FruitName = "Strawberry" },
                new FruitModel(){FruitId = 2, Count = 15, FruitName = "Watermelon" },
                new FruitModel(){FruitId = 3, Count = 13, FruitName = "Yellow Passion Fruit" },
                new FruitModel(){FruitId = 4, Count = 5, FruitName = "Raspberry" },
                new FruitModel(){FruitId = 5, Count = 2, FruitName = "Orange" }
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
