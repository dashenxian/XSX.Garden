using XSX.Garden.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace XSX.Garden.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GardenEntityFrameworkCoreModule),
    typeof(GardenApplicationContractsModule)
    )]
public class GardenDbMigratorModule : AbpModule
{
}
