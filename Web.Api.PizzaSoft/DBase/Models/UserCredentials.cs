using System;

namespace DBase.Models
{
    public class UserCredentials
    {
        public int Id { get; set; }
        public int userInfoId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual UserInfo UserInfo { get; set;}
    }
}
