using DBase.EntityFrameWork.EntityFrameWork.Models;
using System.Data.Entity.ModelConfiguration;

namespace DBase.EntityFrameWork.Maps
{
    public class UserCredentialMap : EntityTypeConfiguration<UserCredential>
    {
        public UserCredentialMap()
        {
            HasKey(p => p.Id);

            Property(p => p.Email)
                .IsRequired();

            Property(p => p.Password)
                .IsRequired();
        }
    }
}
