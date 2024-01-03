using XSX.Garden.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace XSX.Garden.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class GardenController : AbpControllerBase
{
    protected GardenController()
    {
        LocalizationResource = typeof(GardenResource);
    }
}
