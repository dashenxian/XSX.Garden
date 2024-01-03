using XSX.Garden.Samples;
using Xunit;

namespace XSX.Garden.EntityFrameworkCore.Applications;

[Collection(GardenTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<GardenEntityFrameworkCoreTestModule>
{

}
