using System.Reflection;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Serilog;
using Volo.Abp;
using Volo.Abp.Autofac;

namespace XSX.Garden.MAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(Configuration)
            .CreateLogger();
        Log.Information("Starting");
        try
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }).Logging.AddSerilog();
            builder.ConfigureContainer(new AbpAutofacServiceProviderFactory(new Autofac.ContainerBuilder()));

            ConfigureConfiguration(builder);
            builder.Services.AddApplication<MAUIModule>(options =>
            {
                options.Services.ReplaceConfiguration(builder.Configuration);
            });
            var app = builder.Build();

            app.Services.GetRequiredService<IAbpApplicationWithExternalServiceProvider>().Initialize(app.Services);
            return app;
        }
        catch (Exception e)
        {
            Log.Fatal(e, "Start Failed");
            throw;
        }
    }

    private static void ConfigureConfiguration(MauiAppBuilder builder)
    {
        var assembly = typeof(App).GetTypeInfo().Assembly;
        builder.Configuration.AddJsonFile(new EmbeddedFileProvider(assembly), "appsettings.json", optional: false, false);
    }

    public static IConfiguration Configuration =>
        new ConfigurationBuilder()
            .AddJsonFile(
                new EmbeddedFileProvider(typeof(App).GetTypeInfo().Assembly), "appsettings.json", optional: false, false)
            //.AddEnvironmentVariables()
            .Build();
}