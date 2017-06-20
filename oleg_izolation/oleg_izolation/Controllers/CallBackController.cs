using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using oleg_izolation.Models;
using oleg_izolation.Services;

namespace oleg_izolation.Controllers
{
    [Authorize]
    public class CallBackController : Controller
    {
        private CallBackService _callBackService = new CallBackService();

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

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

        [HttpGet]
        [AllowAnonymous]
        public ActionResult LogIn(string errorMessage = "")
        {
            ViewBag.ErrorMessage = errorMessage;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogIn(LoginModel model)
        {
            var successs = false;
            var errorMessage = "Неверный логин или пароль";
            successs = SignIn(model);
            if (successs)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("LogIn", new { errorMessage = errorMessage });
            }
        }

        protected bool SignIn(LoginModel model)
        {
            string login = "olegAdmin";
            string pass = "olegAdmin123!";

            if (model == null || model.Login.ToLower() != login.ToLower() || model.Password.ToLower() != pass.ToLower())
            {
                return false;
            }
            ClaimsIdentity claim = new ClaimsIdentity("ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            claim.AddClaim(new Claim(ClaimTypes.NameIdentifier, login, ClaimValueTypes.String));
            AuthenticationManager.SignIn(new AuthenticationProperties
            {
                IsPersistent = true
            }, claim);
            return true;
        }
    }
}