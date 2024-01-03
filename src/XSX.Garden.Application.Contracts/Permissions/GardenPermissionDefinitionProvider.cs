using XSX.Garden.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace XSX.Garden.Permissions;

public class GardenPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GardenPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(GardenPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GardenResource>(name);
    }
}
