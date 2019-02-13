using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityExample.Common;
using UnityExample.Interfaces;

namespace UnityExample.Services
{
    public class PackageFruitsStep : IWorkflowStep
    {
        public bool Execute(IDictionary<string, object> parameters)
        {
            CustomLogger.Information("Package Fruits start");

            if (parameters["PackageFruits"].ToString().ToLower() == "false")
            {
                CustomLogger.Information("Package Fruits is not needed. Skipping this step");
            }

            CustomLogger.Information("Package Fruits Complete");
            return true;
        }
    }
}
