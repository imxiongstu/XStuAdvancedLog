using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XStuAdvancedLog.Arguments;

namespace XStuAdvancedLog.Abstractions
{
    public abstract class AdvancedLogHandlerBase
    {
        public abstract MethodInfo AssignedTo();
        public abstract void Process(AdvancedLogArgs args);

        public virtual MethodInfo GetMethodInfo<service>(service service, string )
            where service : Type
        {
            return typeof(StrategyAppService).GetMethod(nameof(StrategyAppService.GetWithStringAsync));
        }
    }
}
