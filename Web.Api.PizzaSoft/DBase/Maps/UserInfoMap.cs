using DBase.Models;
using System.Data.Entity.ModelConfiguration;

namespace DBase.Maps
{
    public class UserInfoMap : EntityTypeConfiguration<UserInfo>
    {
        public UserInfoMap()
        {
            HasKey(p => p.Id);

            Property(p => p.Name)
                .HasMaxLength(45)
                .IsRequired();

            Property(p => p.LastName)
                .HasMaxLength(45)
                .IsRequired();

            Property(p => p.SignUpDate)
                .IsRequired();

            HasRequired(u => u.UserCredentials)
                .WithRequiredDependent(u => u.UserInfo);              
        }
    }
}
