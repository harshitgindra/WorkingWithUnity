using System.Collections.Generic;
using UnityExample.Common;
using UnityExample.DAL;
using UnityExample.Interfaces;

namespace UnityExample.Services
{
    public class GetFruitsStep : IWorkflowStep
    {
        public bool Execute(IDictionary<string, object> parameters)
        {
            CustomLogger.Information("Get Fruits Step start");

            IFruitsRepository _fruitsRepository = new CompanyFarmFruitRepository();

            CustomLogger.Information("Get Fruits Step Complete");
            return true;
        }
    }
}
