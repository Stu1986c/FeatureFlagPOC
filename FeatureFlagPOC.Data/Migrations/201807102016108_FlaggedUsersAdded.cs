namespace FeatureFlagPOC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FlaggedUsersAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FlaggedUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FlaggedUsers");
        }
    }
}
