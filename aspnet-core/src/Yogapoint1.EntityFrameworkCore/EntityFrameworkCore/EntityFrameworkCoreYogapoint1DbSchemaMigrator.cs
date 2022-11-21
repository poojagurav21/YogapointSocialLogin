using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Yogapoint1.Data;
using Volo.Abp.DependencyInjection;

namespace Yogapoint1.EntityFrameworkCore;

public class EntityFrameworkCoreYogapoint1DbSchemaMigrator
    : IYogapoint1DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreYogapoint1DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Yogapoint1DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Yogapoint1DbContext>()
            .Database
            .MigrateAsync();
    }
}
