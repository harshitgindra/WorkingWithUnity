using System.Collections.Generic;
using UnityExample.Common;
using UnityExample.Interfaces;

namespace UnityExample.Services
{
    public class CallCarrierStep : IWorkflowStep
    {
        public bool Execute(IDictionary<string, object> parameters)
        {
            CustomLogger.Information("Call Carrier start");

            if (parameters["CallCarrier"].ToString().ToLower() == "false")
            {
                CustomLogger.Information("Call Carrier is not needed. Skipping this step");
            }

            CustomLogger.Information("Call Carrier Complete");
            return true;
        }
    }
}
