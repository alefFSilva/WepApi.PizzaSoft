using AppCore.PizzaSoft.Web.Common.Response;
using AppCore.PizzaSoft.Web.Contracts.POCOs;
using AppCore.PizzaSoft.Web.Framework;
using DBase.EntityFrameWork.Context;
using DBase.EntityFrameWork.EntityFrameWork.Models;
using System;
using System.Linq;
using System.Text;

namespace AppCore.PizzaSoft.Web.Bussines.Auth
{
    public class AuthService 
    {
        private DataBaseContext _dbContext;

        public AuthService()
        {
            this._dbContext = new DataBaseContext();
        }

        public BaseResponse<UserInfoPOCO> DoLogin(string authorizationHeader, BaseResponse<UserInfoPOCO> result)
        {
           return CheckLogin(authorizationHeader, result);
        }

        private BaseResponse<UserInfoPOCO> CheckLogin(string authorizationHeader, BaseResponse<UserInfoPOCO> result)
        {
            result.success = false;
            string[] credentials = GetCredentialsFromHeader(authorizationHeader);
            UserCredential userCredential = MontarUserCredential(credentials);
            UserInfoPOCO userInfo =  GetUser(userCredential);

            if(userInfo != null)
            {
                result.success = true;
                result.Data = userInfo;
            }
            return result;
        }

        private string[] GetCredentialsFromHeader(string authorizationHeader)
        {
            string basicAuth = authorizationHeader.Split(' ')[1];
            byte[] bytesBase64 = Convert.FromBase64String(basicAuth);
            string[] credentials = Encoding.UTF8.GetString(bytesBase64).Split(':');

            return credentials;
        }

        private string GetPswHash(string psw)
        {
            byte[] pswBytes = Encoding.UTF8.GetBytes(psw);
            byte[] pswHash = MD5Hash.GetMD5Bytes(pswBytes);
            string hashPsw = BitConverter.ToString(pswHash);
            return hashPsw;
        }

        private UserCredential MontarUserCredential(string[] credentials)
        {
          return  new UserCredential
            {
                Email = credentials[0],
                Password = GetPswHash(credentials[1])
            };
        }

        private UserInfoPOCO GetUser( UserCredential user)
        {
            return _dbContext.UserInfo
                    .Where(u => u.UserCredential.Email == user.Email
                        && u.UserCredential.Password == user.Password)
                        .Select(u => new UserInfoPOCO
                        {
                            Nome = u.Name,
                            Sobrenome = u.LastName
                        }
                ).FirstOrDefault();
        }
    }
}
