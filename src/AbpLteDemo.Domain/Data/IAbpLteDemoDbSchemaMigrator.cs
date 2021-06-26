using System.Threading.Tasks;

namespace AbpLteDemo.Data
{
    public interface IAbpLteDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
