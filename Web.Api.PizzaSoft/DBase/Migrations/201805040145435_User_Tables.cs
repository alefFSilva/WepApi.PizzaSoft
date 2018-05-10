namespace DBase.EntityFrameWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User_Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserCredential",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 45),
                        LastName = c.String(nullable: false, maxLength: 45),
                        SignUpDate = c.DateTime(nullable: false),
                        UserCredentialId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserCredential", t => t.UserCredentialId, cascadeDelete: true)
                .Index(t => t.UserCredentialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInfo", "UserCredentialId", "dbo.UserCredential");
            DropIndex("dbo.UserInfo", new[] { "UserCredentialId" });
            DropTable("dbo.UserInfo");
            DropTable("dbo.UserCredential");
        }
    }
}
