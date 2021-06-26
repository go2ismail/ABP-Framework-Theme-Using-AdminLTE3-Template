using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpLteDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpLteDemoEntityFrameworkCoreModule)
        )]
    public class AbpLteDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpLteDemoMigrationsDbContext>();
        }
    }
}
