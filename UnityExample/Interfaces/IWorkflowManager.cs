using System.Collections.Generic;

namespace UnityExample.Interfaces
{
    public interface IWorkflowManager
    {
        bool Initiate(IDictionary<string, object> parameters);
    }
}
