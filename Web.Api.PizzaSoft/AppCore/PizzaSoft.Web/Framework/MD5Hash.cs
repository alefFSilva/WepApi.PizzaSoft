using System.Security.Cryptography;
namespace AppCore.PizzaSoft.Web.Framework
{
    public static class MD5Hash
    {
        public static byte[] GetMD5Bytes(byte[] byteValue)
        {
           using(MD5 md5Hash = MD5.Create())
            {
                return md5Hash.ComputeHash(byteValue);
            }
        }
    }
}
