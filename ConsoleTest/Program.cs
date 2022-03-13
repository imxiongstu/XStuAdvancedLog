using ConsoleTest;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using XStuAdvancedLog.Interfaces;

using (var application = AbpApplicationFactory.Create<ConsoleTestModule>(options =>
{
    options.UseAutofac();
}))
{
    application.Initialize();

    var aaa = typeof(TestHandler).GetInterfaces();
    var aaaa = typeof(IAdvancedLogHandler);

    application.Services.AddTransient<TestHandler>();

    var service = application.ServiceProvider.GetRequiredService<TestAdvancedLogService>();

    await service.RunAsync("123123123123s");

    application.Shutdown();

}