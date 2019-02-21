using System.Collections.Generic;
using UnityExample.Common;
using UnityExample.Interfaces;

namespace UnityExample.Services
{
    public class WorkflowManager: IWorkflowManager
    {
        private readonly IWorkflowStep[] _steps;

        public WorkflowManager(IWorkflowStep[] steps)
        {
            _steps = steps;
        }

        public bool Initiate( IDictionary<string, object> parameters)
        {
            bool returnValue = false;

            foreach (var step in _steps)
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
