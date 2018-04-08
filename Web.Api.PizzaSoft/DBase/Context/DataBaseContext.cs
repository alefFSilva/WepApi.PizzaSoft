using DBase.EntityFrameWork.EntityFrameWork.Maps;
using DBase.EntityFrameWork.EntityFrameWork.Models;
using DBase.EntityFrameWork.Maps;
using DBase.EntityFrameWork.Models;
using System.Data.Entity;

namespace DBase.EntityFrameWork.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("DBPizzaSoft") { }

        public DbSet<UserCredential> UserCredentialsMap { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UserCredentialMap());
            modelBuilder.Configurations.Add(new UserInfoMap());
        }
    }
}
