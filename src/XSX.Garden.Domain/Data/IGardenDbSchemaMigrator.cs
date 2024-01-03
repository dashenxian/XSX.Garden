using System.Threading.Tasks;

namespace XSX.Garden.Data;

public interface IGardenDbSchemaMigrator
{
    Task MigrateAsync();
}
