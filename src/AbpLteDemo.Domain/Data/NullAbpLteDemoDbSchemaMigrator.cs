using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpLteDemo.Data
{
    /* This is used if database provider does't define
     * IAbpLteDemoDbSchemaMigrator implementation.
     */
    public class NullAbpLteDemoDbSchemaMigrator : IAbpLteDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}