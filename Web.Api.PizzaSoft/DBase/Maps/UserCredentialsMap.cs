using DBase.Models;
using System.Data.Entity.ModelConfiguration;

namespace DBase.Maps
{
    public class UserCredentialsMap : EntityTypeConfiguration<UserCredentials>
    {
        public UserCredentialsMap()
        {
            HasKey(p => p.Id);

            Property(p => p.Email)
                .IsRequired();

            Property(p => p.Password)
                .IsRequired();
        }
    }
}
