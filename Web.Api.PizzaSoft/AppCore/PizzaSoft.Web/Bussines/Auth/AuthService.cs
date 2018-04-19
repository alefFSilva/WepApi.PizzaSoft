using AppCore.PizzaSoft.Web.Common.Response;
using AppCore.PizzaSoft.Web.Contracts.POCOs;
using System;
using System.Text;

namespace AppCore.PizzaSoft.Web.Bussines.Auth
{
    public class AuthService 
    {

        public BaseResponse<UserInfo> DoLogin(string authorizationHeader)
        {
           return CheckLogin(authorizationHeader);
        }

        private BaseResponse<UserInfo> CheckLogin(string authorizationHeader)
        {
            string[] credentials = GetCredentials(authorizationHeader);
            var response = new BaseResponse<UserInfo>();
            response.Success = false;

            if(credentials[0] == "alefs93@gmail.com" && credentials[1] == "123")
            {
                response.Success = true;
                UserInfo userInfo = new UserInfo();
                userInfo.Nome = "Alef";
                userInfo.Sobrenome = "Silva";
                response.Data = userInfo;
            }
            return response;
        }

        private string[] GetCredentials(string authorizationHeader)
        {
            string basicAuth = authorizationHeader.Split(' ')[1];
            byte[] bytesBase64 = Convert.FromBase64String(basicAuth);
            string[] credentials = Encoding.UTF8.GetString(bytesBase64).Split(':');

            return credentials;
        }
    }
}
