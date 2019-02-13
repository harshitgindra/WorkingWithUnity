using System;
using System.Collections.Generic;
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
                CustomLogger.Information("Execution start");
                IDictionary<string, object> parameters = new Dictionary<string, object>{
                    {"CallCarrier", "false" },
                    {"PackageFruits", "false" }
                };

                var container = _Bootstrapper();

                List<IWorkflowStep> steps = new List<IWorkflowStep>()
                {
                    container.Resolve<IWorkflowStep>("GetFruitsStep"),
                    container.Resolve<IWorkflowStep>("VerifyFruitCountStep"),
                    container.Resolve<IWorkflowStep>("PackageFruitsStep"),
                    container.Resolve<IWorkflowStep>("SendFruitsStep"),
                    container.Resolve<IWorkflowStep>("CallCarrierStep"),
                    container.Resolve<IWorkflowStep>("UpdateStockStep"),
                };

                WorkflowManager mgr = new WorkflowManager();
                bool returnValue = mgr.Initiate(steps, parameters);

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

        private static IUnityContainer _Bootstrapper()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IFruitsRepository, CompanyFarmFruitRepository>("CompanyFarmFruitRepository");
            container.RegisterType<IFruitsRepository, PrivateFarmFruitRepository>("PrivateFarmFruitRepository");
            container.RegisterType<IFruitsRepository, StorageFruitRepository>("StorageFruitRepository");

            container.RegisterType<IWorkflowStep, CallCarrierStep>("CallCarrierStep");
            container.RegisterType<IWorkflowStep, GetFruitsStep>("GetFruitsStep", new InjectionConstructor(new ResolvedParameter<IFruitsRepository>("PrivateFarmFruitRepository")));
            container.RegisterType<IWorkflowStep, PackageFruitsStep>("PackageFruitsStep");
            container.RegisterType<IWorkflowStep, SendFruitsStep>("SendFruitsStep");
            container.RegisterType<IWorkflowStep, UpdateStockStep>("UpdateStockStep", new InjectionConstructor(new ResolvedParameter<IFruitsRepository>("CompanyFarmFruitRepository")));
            container.RegisterType<IWorkflowStep, VerifyFruitCountStep>("VerifyFruitCountStep");
            return container;
        }
    }
}
