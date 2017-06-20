using System.Web.Mvc;
using oleg_izolation.Models;
using oleg_izolation.Services;

namespace oleg_izolation.Controllers
{
    public class CallBackController : Controller
    {
        private CallBackService _callBackService = new CallBackService();

        public JsonResult AddCallBack(CallBackModel model)
        {
            _callBackService.AddCallBackToDB(model);
            return Json(new { success = true });
        }

        public ActionResult Index()
        {
            var model = _callBackService.GetCallBackModels();
            return View(model);
        }
    }
}