using System.Collections.Generic;
using UnityExample.Common;
using UnityExample.Interfaces;

namespace UnityExample.Services
{
    public class VerifyFruitCountStep : IWorkflowStep
    {
        public bool Execute(IDictionary<string, object> parameters)
        {
            CustomLogger.Information("Verify Fruit Count start");

            CustomLogger.Information("Verify Fruit Count Complete");
            return true;
        }
    }
}
