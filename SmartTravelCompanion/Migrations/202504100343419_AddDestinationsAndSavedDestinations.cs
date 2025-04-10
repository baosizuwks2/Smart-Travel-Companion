namespace SmartTravelCompanion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDestinationsAndSavedDestinations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        UniqueReason = c.String(),
                        SafetyTips = c.String(),
                        ActivityType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SavedDestinations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        DestinationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.UserPreferences", "PreferredActivities", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserPreferences", "PreferredActivities");
            DropTable("dbo.SavedDestinations");
            DropTable("dbo.Destinations");
        }
    }
}
