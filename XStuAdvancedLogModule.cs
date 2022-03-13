using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Volo.Abp;
using Volo.Abp.Modularity;
using XStuAdvancedLog.Interceptors;
using XStuAdvancedLog.Interfaces;

namespace XStuAdvancedLog
{

    public class XStuAdvancedLogModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.OnRegistred(context =>
            {
                var aaaa = context.ImplementationType.GetTypeInfo();
                Console.WriteLine(context.ImplementationType.GetTypeInfo());
                if (context.ImplementationType == typeof(IAdvancedLogHandler))
                {
                    Console.WriteLine(111111);
                    var aaa = context.ImplementationType;
                }
                //if (context.ImplementationType.GetCustomAttribute<AdvancedLogAttribute>() != null)
                //{
                //    context.Interceptors.TryAdd<AdvacedLogInterceptor>();
                //}
            });
        }
    }
}