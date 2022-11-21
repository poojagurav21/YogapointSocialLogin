using Yogapoint1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Yogapoint1.Permissions;

public class Yogapoint1PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Yogapoint1Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Yogapoint1Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Yogapoint1Resource>(name);
    }
}
