using Abp.AspNetCore.Mvc.ViewComponents;

namespace CoreDemo.Web.Views
{
    public abstract class CoreDemoViewComponent : AbpViewComponent
    {
        protected CoreDemoViewComponent()
        {
            LocalizationSourceName = CoreDemoConsts.LocalizationSourceName;
        }
    }
}
