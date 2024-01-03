using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using XSX.Garden.Data;
using Volo.Abp.DependencyInjection;

namespace XSX.Garden.EntityFrameworkCore;

public class EntityFrameworkCoreGardenDbSchemaMigrator
    : IGardenDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreGardenDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the GardenDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<GardenDbContext>()
            .Database
            .MigrateAsync();
    }
}
