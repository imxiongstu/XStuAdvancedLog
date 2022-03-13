using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XStuAdvancedLog.Arguments;
using XStuAdvancedLog.Interfaces;

namespace ConsoleTest
{
    public class TestHandler : IAdvancedLogHandler
    {
        public MethodInfo FromMethod() => typeof(TestAdvancedLogService).GetMethod(nameof(TestAdvancedLogService.RunAsync));

        public void Process(FromMethodArgs args)
        {
            Console.WriteLine(JsonConvert.SerializeObject(args, Formatting.Indented));
        }
    }
}
