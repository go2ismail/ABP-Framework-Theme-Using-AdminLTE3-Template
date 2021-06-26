using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpLteDemo.EntityFrameworkCore
{
    public static class AbpLteDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpLteDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpLteDemoConsts.DbTablePrefix + "YourEntities", AbpLteDemoConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}