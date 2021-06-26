using AbpLteDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpLteDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpLteDemoPageModel : AbpPageModel
    {
        protected AbpLteDemoPageModel()
        {
            LocalizationResourceType = typeof(AbpLteDemoResource);
        }
    }
}