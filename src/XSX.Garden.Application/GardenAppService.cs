using System;
using System.Collections.Generic;
using System.Text;
using XSX.Garden.Localization;
using Volo.Abp.Application.Services;

namespace XSX.Garden;

/* Inherit your application services from this class.
 */
public abstract class GardenAppService : ApplicationService
{
    protected GardenAppService()
    {
        LocalizationResource = typeof(GardenResource);
    }
}
