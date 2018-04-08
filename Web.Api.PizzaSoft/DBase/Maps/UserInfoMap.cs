using DBase.EntityFrameWork.Models;
using System.Data.Entity.ModelConfiguration;

namespace DBase.EntityFrameWork.EntityFrameWork.Maps
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
            
        }

        
    }
}
