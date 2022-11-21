using Yogapoint1.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Yogapoint1;

[DependsOn(
    typeof(Yogapoint1EntityFrameworkCoreTestModule)
    )]
public class Yogapoint1DomainTestModule : AbpModule
{

}
