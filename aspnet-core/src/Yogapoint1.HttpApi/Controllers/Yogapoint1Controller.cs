using Yogapoint1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Yogapoint1.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Yogapoint1Controller : AbpControllerBase
{
    protected Yogapoint1Controller()
    {
        LocalizationResource = typeof(Yogapoint1Resource);
    }
}
