using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using CoreDemo.Controllers;

namespace CoreDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : CoreDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
