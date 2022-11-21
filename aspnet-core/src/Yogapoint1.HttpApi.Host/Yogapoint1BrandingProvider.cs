using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Yogapoint1;

[Dependency(ReplaceServices = true)]
public class Yogapoint1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Yogapoint1";
}
