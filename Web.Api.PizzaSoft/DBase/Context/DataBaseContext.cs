using DBase.Maps;
using DBase.Models;
using System.Data.Entity;

namespace DBase.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("DBPizzaSoft") { }

        public DbSet<UserCredentials> UserCredentialsMap { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UserCredentialsMap());
            modelBuilder.Configurations.Add(new UserInfoMap());
        }
    }
}
