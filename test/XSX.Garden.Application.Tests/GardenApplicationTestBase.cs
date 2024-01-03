using Volo.Abp.Modularity;

namespace XSX.Garden;

public abstract class GardenApplicationTestBase<TStartupModule> : GardenTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
