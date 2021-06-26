using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpLteDemo.Data;
using Volo.Abp.DependencyInjection;

namespace AbpLteDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpLteDemoDbSchemaMigrator
        : IAbpLteDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpLteDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpLteDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpLteDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}