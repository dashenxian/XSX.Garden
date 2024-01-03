using XSX.Garden.Samples;
using Xunit;

namespace XSX.Garden.EntityFrameworkCore.Domains;

[Collection(GardenTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<GardenEntityFrameworkCoreTestModule>
{

}
