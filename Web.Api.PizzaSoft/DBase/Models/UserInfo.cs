using System;

namespace DBase.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime SignUpDate { get; set; }

        public virtual UserCredentials UserCredentials { get; set; }
    }
}
