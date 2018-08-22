using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace CoreDemo.Web.Views
{
    public abstract class CoreDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CoreDemoRazorPage()
        {
            LocalizationSourceName = CoreDemoConsts.LocalizationSourceName;
        }
    }
}
