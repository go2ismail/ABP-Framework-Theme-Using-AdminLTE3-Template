using Volo.Abp.Modularity;

namespace AbpLteDemo
{
    [DependsOn(
        typeof(AbpLteDemoApplicationModule),
        typeof(AbpLteDemoDomainTestModule)
        )]
    public class AbpLteDemoApplicationTestModule : AbpModule
    {

    }
}