using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XStuAdvancedLog.Arguments;

namespace XStuAdvancedLog.Abstractions
{
    public abstract class AdvancedLogHandlerBase
    {
        public abstract void Process(AdvancedLogArgs args);
    }
}
