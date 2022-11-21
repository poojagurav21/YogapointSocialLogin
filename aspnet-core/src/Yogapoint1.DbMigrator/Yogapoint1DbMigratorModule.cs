using Yogapoint1.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Yogapoint1.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Yogapoint1EntityFrameworkCoreModule),
    typeof(Yogapoint1ApplicationContractsModule)
    )]
public class Yogapoint1DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
