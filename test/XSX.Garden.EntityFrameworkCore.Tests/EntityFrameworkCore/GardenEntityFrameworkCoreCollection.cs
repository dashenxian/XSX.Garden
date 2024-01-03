using Xunit;

namespace XSX.Garden.EntityFrameworkCore;

[CollectionDefinition(GardenTestConsts.CollectionDefinitionName)]
public class GardenEntityFrameworkCoreCollection : ICollectionFixture<GardenEntityFrameworkCoreFixture>
{

}
