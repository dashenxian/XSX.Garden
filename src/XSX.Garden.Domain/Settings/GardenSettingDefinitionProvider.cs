using Volo.Abp.Settings;

namespace XSX.Garden.Settings;

public class GardenSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(GardenSettings.MySetting1));
    }
}
