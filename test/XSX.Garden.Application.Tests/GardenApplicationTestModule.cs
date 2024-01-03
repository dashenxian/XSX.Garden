using Volo.Abp.Modularity;

namespace XSX.Garden;

[DependsOn(
    typeof(GardenApplicationModule),
    typeof(GardenDomainTestModule)
)]
public class GardenApplicationTestModule : AbpModule
{

}
