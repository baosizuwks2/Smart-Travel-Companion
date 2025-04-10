namespace SmartTravelCompanion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Destination = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TimeAvailable = c.DateTime(nullable: false),
                        Link = c.String(),
                        Source = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserPreferences",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        MaxPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Destinations = c.String(),
                        NotificationEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserPreferences");
            DropTable("dbo.Deals");
        }
    }
}
