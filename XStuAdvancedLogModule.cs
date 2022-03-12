using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Volo.Abp;
using Volo.Abp.Modularity;
using XStuAdvancedLog.Attributes;
using XStuAdvancedLog.Interceptors;

namespace XStuAdvancedLog
{

    public class XStuAdvancedLogModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            /*
             * 给所有标记了AdvancedLog特性的类，添加拦截器
             */
            context.Services.OnRegistred(context =>
            {
                if (context.ImplementationType.GetCustomAttribute<AdvancedLogAttribute>() != null)
                {
                    context.Interceptors.TryAdd<AdvacedLogInterceptor>();
                }
            });
        }
    }
}