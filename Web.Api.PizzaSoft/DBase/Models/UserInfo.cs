using DBase.EntityFrameWork.EntityFrameWork.Models;
using System;

namespace DBase.EntityFrameWork.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime SignUpDate { get; set; }

        public int UserCredentialId { get; set; }

        public virtual UserCredential UserCredential { get; set; }
    }
}
