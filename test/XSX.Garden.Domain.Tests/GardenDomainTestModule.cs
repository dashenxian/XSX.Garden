using Volo.Abp.Modularity;

namespace XSX.Garden;

[DependsOn(
    typeof(GardenDomainModule),
    typeof(GardenTestBaseModule)
)]
public class GardenDomainTestModule : AbpModule
{

}
