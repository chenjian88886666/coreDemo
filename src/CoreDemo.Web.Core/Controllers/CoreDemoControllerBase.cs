using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CoreDemo.Controllers
{
    public abstract class CoreDemoControllerBase: AbpController
    {
        protected CoreDemoControllerBase()
        {
            LocalizationSourceName = CoreDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
