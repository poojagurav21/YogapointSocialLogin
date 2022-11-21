using System;
using System.Collections.Generic;
using System.Text;
using Yogapoint1.Localization;
using Volo.Abp.Application.Services;

namespace Yogapoint1;

/* Inherit your application services from this class.
 */
public abstract class Yogapoint1AppService : ApplicationService
{
    protected Yogapoint1AppService()
    {
        LocalizationResource = typeof(Yogapoint1Resource);
    }
}
