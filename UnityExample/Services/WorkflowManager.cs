using System.Collections.Generic;
using UnityExample.Common;
using UnityExample.DAL;
using UnityExample.Interfaces;

namespace UnityExample.Services
{
    public class WorkflowManager
    {
        public bool Initiate(IDictionary<string, object> parameters)
        {
            bool returnValue = false;

            List<IWorkflowStep> steps = new List<IWorkflowStep>()
            {
                new GetFruitsStep(),
                new VerifyFruitCountStep(),
                new PackageFruitsStep(),
                new CallCarrierStep(),
                new SendFruitsStep(),
                new UpdateStockStep(),
            };

            foreach (var step in steps)
            {
                returnValue = step.Execute(parameters);
                if (!returnValue)
                {
                    CustomLogger.Error("Something went wrong. Execution interrupted");
                    break;
                }
            }

            return returnValue;
        }
    }
}
