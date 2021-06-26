using AbpLteDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpLteDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpLteDemoEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpLteDemoApplicationContractsModule)
        )]
    public class AbpLteDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
