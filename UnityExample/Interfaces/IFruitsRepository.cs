using System.Collections.Generic;
using UnityExample.Common;

namespace UnityExample.Interfaces
{
    public interface IFruitsRepository
    {
        List<FruitModel> GetAll();

        bool Update(List<FruitModel> fruits);
    }
}
