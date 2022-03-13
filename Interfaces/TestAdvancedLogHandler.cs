using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XStuAdvancedLog.Arguments;

namespace XStuAdvancedLog.Interfaces
{
    public class TestAdvancedLogHandler : IAdvancedLogHandler
    {
        public MethodInfo FromMethod()
        {
            throw new NotImplementedException();
        }

        public void Process(FromMethodArgs args)
        {
            Console.WriteLine(JsonConvert.SerializeObject(args, Formatting.Indented));
        }
    }
}
