using System.Collections.Generic;
using UnityExample.Common;
using UnityExample.DAL;
using UnityExample.Interfaces;

namespace UnityExample.Services
{
    public class UpdateStockStep : IWorkflowStep
    {
        public bool Execute(IDictionary<string, object> parameters)
        {
            CustomLogger.Information("Update Stock start");
             
            IFruitsRepository _fruitsRepository = new CompanyFarmFruitRepository();

            CustomLogger.Information("Update Stock Complete");
            return true;
        }
    }
}
