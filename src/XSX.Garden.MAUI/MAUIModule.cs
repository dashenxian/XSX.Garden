using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace XSX.Garden.MAUI;

[DependsOn(typeof(AbpAutofacModule))]
public class MAUIModule : AbpModule
{
}
