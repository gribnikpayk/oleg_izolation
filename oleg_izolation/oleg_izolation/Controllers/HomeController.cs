using System.IO.MemoryMappedFiles;
using System.Web.Mvc;

namespace oleg_izolation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Index.cshtml");
        }
        public ActionResult Price()
        {
            return View("~/Views/Price.cshtml");
        }
        public ActionResult Photo()
        {
            return View("~/Views/Photo.cshtml");
        }
        public ActionResult Recomendation()
        {
            return View("~/Views/Recomendation.cshtml");
        }
        public ActionResult Contacts()
        {
            return View("~/Views/Contacts.cshtml");
        }
        public ActionResult callBackForm()
        {
            return View("~/Views/callBackForm.cshtml");
        }

        public ActionResult LandingPage(string pageName)
        {
            var pagePath = $"~/Views/LandingPages/{pageName}.cshtml";
            return View(pagePath);
        }
    }
}
