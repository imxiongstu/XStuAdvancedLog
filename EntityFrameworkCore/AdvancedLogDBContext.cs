using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;

namespace XStuAdvancedLog.EntityFrameworkCore
{
    public class XStuAdvancedLogDBContext : AbpDbContext<XStuAdvancedLogDBContext>
    {
        public XStuAdvancedLogDBContext(DbContextOptions<XStuAdvancedLogDBContext> options) : base(options)
        {
        }
    }
}
