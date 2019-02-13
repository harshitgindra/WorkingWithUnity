using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityExample.Common;
using UnityExample.Services;

namespace UnityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CustomLogger.Information("Execution start");
                IDictionary<string, object> parameters = new Dictionary<string, object>{
                    {"CallCarrier", "false" },
                    {"PackageFruits", "false" }
                };
                WorkflowManager mgr = new WorkflowManager();
                bool returnValue = mgr.Initiate(parameters);

            }
            catch (Exception ex)
            {
                CustomLogger.Exception(ex, "MAIN");
            }
            finally
            {
                CustomLogger.Information("Execution complete");
            }
        }
    }
}
