using System.Collections.Generic;
using UnityExample.Common;
using UnityExample.DAL;
using UnityExample.Interfaces;

namespace UnityExample.Services
{
    public class GetFruitsStep : IWorkflowStep
    {
        private readonly IFruitsRepository _fruitsRepository;

        public GetFruitsStep(IFruitsRepository fruitsRepository)
        {
            _fruitsRepository = fruitsRepository;
        }

        public bool Execute(IDictionary<string, object> parameters)
        {
            CustomLogger.Information("Get Fruits Step start");

            CustomLogger.Information("Get Fruits Step Complete");
            return true;
        }
    }
}
