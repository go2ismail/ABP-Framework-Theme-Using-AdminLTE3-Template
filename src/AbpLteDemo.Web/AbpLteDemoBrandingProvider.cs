using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpLteDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpLteDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpLteDemo";
    }
}
