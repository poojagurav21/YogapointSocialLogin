using Volo.Abp.Modularity;

namespace Yogapoint1;

[DependsOn(
    typeof(Yogapoint1ApplicationModule),
    typeof(Yogapoint1DomainTestModule)
    )]
public class Yogapoint1ApplicationTestModule : AbpModule
{

}
