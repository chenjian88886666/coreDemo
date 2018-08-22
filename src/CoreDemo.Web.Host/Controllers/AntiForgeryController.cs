using Microsoft.AspNetCore.Antiforgery;
using CoreDemo.Controllers;

namespace CoreDemo.Web.Host.Controllers
{
    public class AntiForgeryController : CoreDemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
