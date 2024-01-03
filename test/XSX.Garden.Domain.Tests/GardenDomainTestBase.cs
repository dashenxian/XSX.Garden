using Volo.Abp.Modularity;

namespace XSX.Garden;

/* Inherit from this class for your domain layer tests. */
public abstract class GardenDomainTestBase<TStartupModule> : GardenTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
