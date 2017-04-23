using System.Web.Mvc;

namespace NetCraft.Web.Controllers
{
    public class AboutController : NetCraftControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}