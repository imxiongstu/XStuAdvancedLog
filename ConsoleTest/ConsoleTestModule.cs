using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using XStuAdvancedLog;

namespace ConsoleTest
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(XStuAdvancedLogModule)
        )]
    public class ConsoleTestModule : AbpModule
    {
    }
}
