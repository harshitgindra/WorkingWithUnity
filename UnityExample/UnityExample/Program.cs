using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;
using UnityExample.Common;
using UnityExample.DAL;
using UnityExample.Interfaces;
using UnityExample.Services;

namespace UnityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string configFileName = args[0];
                CustomLogger.Information("Execution start");
                CustomLogger.Information($"Loading Unity from File:{configFileName}");
                IDictionary<string, object> parameters = new Dictionary<string, object>{
                    {"CallCarrier", "false" },
                    {"PackageFruits", "false" }
                };

                var container = _Bootstrapper(configFileName);

                IWorkflowManager mgr = container.Resolve<IWorkflowManager>("SimpleWorkflowManager");
                bool returnValue = mgr.Initiate(parameters);
            }
            catch (Exception ex)
            {
                CustomLogger.Exception(ex, "MAIN");
            }
            finally
            {
                Console.ReadKey();
                CustomLogger.Information("Execution complete");
            }
        }

        private static IUnityContainer _Bootstrapper(string configFileName)
        {
            var exeConfigFileMap = new ExeConfigurationFileMap()
            {
                ExeConfigFilename = configFileName
            };
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(exeConfigFileMap, ConfigurationUserLevel.None);
            var unitySection = (UnityConfigurationSection)configuration.GetSection("unity");

            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration(unitySection);
            return container;
        }
    }
}
