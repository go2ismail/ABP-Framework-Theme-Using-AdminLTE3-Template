using AbpLteDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpLteDemo
{
    [DependsOn(
        typeof(AbpLteDemoEntityFrameworkCoreTestModule)
        )]
    public class AbpLteDemoDomainTestModule : AbpModule
    {

    }
}