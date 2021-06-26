using AbpLteDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpLteDemo.Permissions
{
    public class AbpLteDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpLteDemoPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpLteDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpLteDemoResource>(name);
        }
    }
}
