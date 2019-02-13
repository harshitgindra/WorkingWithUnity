using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityExample.Common;
using UnityExample.Interfaces;

namespace UnityExample.Services
{
    public class SendFruitsStep : IWorkflowStep
    {
        public bool Execute(IDictionary<string, object> parameters)
        {
            CustomLogger.Information("Send Fruits start");

            CustomLogger.Information("Send Fruits Complete");
            return true;
        }
    }
}
