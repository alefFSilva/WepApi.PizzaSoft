using AppCore.PizzaSoft.Web.Bussines.Auth;
using AppCore.PizzaSoft.Web.Common.Response;
using AppCore.PizzaSoft.Web.Contracts.POCOs;
using System;
using System.Text;
using System.Web.Mvc;

namespace Web.Api.PizzaSoft.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public JsonResult Index()
        {
            var tst = Request.Headers["email"];
            AuthService authService = new AuthService();

            return Json(tst, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public JsonResult DoLogin()
        {
            var response = new BaseResponse<UserInfo>();
            string autorizationHeader = Request.Headers["Authorization"];
            if (!String.IsNullOrEmpty(autorizationHeader))
            {
                var authService = new AuthService();
                response = authService.DoLogin(autorizationHeader);
            }

            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}
