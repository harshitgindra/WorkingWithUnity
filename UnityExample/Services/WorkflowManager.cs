using System.Collections.Generic;
using UnityExample.Common;
using UnityExample.DAL;
using UnityExample.Interfaces;

namespace UnityExample.Services
{
    public class WorkflowManager
    {
        public bool Initiate(List<IWorkflowStep> steps, IDictionary<string, object> parameters)
        {
            bool returnValue = false;

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
