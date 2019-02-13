using System.Collections.Generic;
using UnityExample.Common;
using UnityExample.Interfaces;

namespace UnityExample.Services
{
    public class UpdateStockStep : IWorkflowStep
    {
        private readonly IFruitsRepository _fruitsRepository;

        public UpdateStockStep(IFruitsRepository fruitsRepository)
        {
            _fruitsRepository = fruitsRepository;
        }

        public bool Execute(IDictionary<string, object> parameters)
        {
            CustomLogger.Information("Update Stock start");

            CustomLogger.Information("Update Stock Complete");
            return true;
        }
    }
}
