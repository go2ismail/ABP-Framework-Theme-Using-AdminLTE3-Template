using Volo.Abp.Settings;

namespace AbpLteDemo.Settings
{
    public class AbpLteDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpLteDemoSettings.MySetting1));
        }
    }
}
