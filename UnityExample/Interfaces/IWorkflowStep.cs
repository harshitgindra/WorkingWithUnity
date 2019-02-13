using System.Collections.Generic;

namespace UnityExample.Interfaces
{
    public interface IWorkflowStep
    {
        bool Execute(IDictionary<string, object> parameters);
    }
}
