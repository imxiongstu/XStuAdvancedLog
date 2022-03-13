using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using XStuAdvancedLog.Arguments;

namespace XStuAdvancedLog.Interfaces
{
    public interface IAdvancedLogHandler : ITransientDependency
    {
        MethodInfo FromMethod();
        void Process(FromMethodArgs args);
    }
}
