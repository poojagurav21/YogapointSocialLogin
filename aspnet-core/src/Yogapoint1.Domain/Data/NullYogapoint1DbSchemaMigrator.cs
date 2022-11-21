using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Yogapoint1.Data;

/* This is used if database provider does't define
 * IYogapoint1DbSchemaMigrator implementation.
 */
public class NullYogapoint1DbSchemaMigrator : IYogapoint1DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
