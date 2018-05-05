using AppCore.PizzaSoft.Web.Bussines.Auth;
using AppCore.PizzaSoft.Web.Common.Response;
using AppCore.PizzaSoft.Web.Contracts.POCOs;
using System;
using System.Web.Mvc;

namespace Web.Api.PizzaSoft.Controllers
{
    public class AuthController : Controller
    {
        [AllowAnonymous]
        public JsonResult DoLogin()
        {
            var result = new BaseResponse<UserInfoPOCO>();
            string autorizationHeader = Request.Headers["Authorization"];

            if (!String.IsNullOrEmpty(autorizationHeader))
            {
                var authService = new AuthService();
                authService.DoLogin(autorizationHeader, result);
            }           

            return Json(result , JsonRequestBehavior.AllowGet);
        }
    }
}
