using System.Threading.Tasks;

namespace Yogapoint1.Data;

public interface IYogapoint1DbSchemaMigrator
{
    Task MigrateAsync();
}
