using System;
using System.Collections.Generic;
using System.Text;
using AbpLteDemo.Localization;
using Volo.Abp.Application.Services;

namespace AbpLteDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpLteDemoAppService : ApplicationService
    {
        protected AbpLteDemoAppService()
        {
            LocalizationResource = typeof(AbpLteDemoResource);
        }
    }
}
