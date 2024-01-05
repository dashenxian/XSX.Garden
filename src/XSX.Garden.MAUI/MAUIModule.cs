using Microsoft.Extensions.Logging;
using Volo.Abp;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace XSX.Garden.MAUI;

[DependsOn(typeof(AbpAutofacModule))]
public class MAUIModule : AbpModule
{

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddSingleton<ISecureStorage>(_ => SecureStorage.Default);
        base.ConfigureServices(context);
    }

    public override void OnPostApplicationInitialization(ApplicationInitializationContext context)
    {
        var logger = context.ServiceProvider.GetRequiredService<ILogger<MAUIModule>>();
        var isEnabled = logger.IsEnabled(LogLevel.Information);
        logger.LogInformation("这是日志");
        base.OnPostApplicationInitialization(context);
    }

    public override void OnApplicationShutdown(ApplicationShutdownContext context)
    {
        var logger = context.ServiceProvider.GetRequiredService<ILogger<MAUIModule>>();
        var isEnabled = logger.IsEnabled(LogLevel.Information);
        logger.LogInformation("这是日志2");
        base.OnApplicationShutdown(context);
    }

    public override Task OnApplicationShutdownAsync(ApplicationShutdownContext context)
    {
        return base.OnApplicationShutdownAsync(context);
    }

    public override void PostConfigureServices(ServiceConfigurationContext context)
    {
        base.PostConfigureServices(context);
    }
}
