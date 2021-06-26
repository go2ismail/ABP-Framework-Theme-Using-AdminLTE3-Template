using AbpLteDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpLteDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpLteDemoController : AbpController
    {
        protected AbpLteDemoController()
        {
            LocalizationResource = typeof(AbpLteDemoResource);
        }
    }
}