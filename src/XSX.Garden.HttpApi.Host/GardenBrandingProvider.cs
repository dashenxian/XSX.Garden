using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace XSX.Garden;

[Dependency(ReplaceServices = true)]
public class GardenBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Garden";
}
