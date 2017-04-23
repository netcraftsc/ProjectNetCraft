using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace NetCraft.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : NetCraftControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}