using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ConsoleTest
{
    public class TestAdvancedLogService : ITransientDependency
    {

        public async Task RunAsync(string test)
        {
            Console.WriteLine(test);

            await Task.CompletedTask;
        }



    }
}
