using DBase.EntityFrameWork.EntityFrameWork.Maps;
using DBase.EntityFrameWork.EntityFrameWork.Models;
using DBase.EntityFrameWork.Maps;
using DBase.EntityFrameWork.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DBase.EntityFrameWork.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("DBPizzaSoft") { }

        public IDbSet<UserCredential> UserCredential { get; set; }
        public IDbSet<UserInfo> UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new UserCredentialMap());
            modelBuilder.Configurations.Add(new UserInfoMap());
        }
    }
}
