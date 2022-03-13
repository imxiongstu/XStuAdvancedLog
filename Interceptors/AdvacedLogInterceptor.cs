using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.DynamicProxy;

namespace XStuAdvancedLog.Interceptors
{
    public class AdvacedLogInterceptor : AbpInterceptor, ITransientDependency
    {
        public override Task InterceptAsync(IAbpMethodInvocation invocation)
        {
            throw new NotImplementedException();
        }
    }
}
