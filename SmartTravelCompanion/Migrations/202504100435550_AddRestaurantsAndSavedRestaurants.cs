namespace SmartTravelCompanion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRestaurantsAndSavedRestaurants : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CuisineType = c.String(),
                        Location = c.String(),
                        PriceRange = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SavedRestaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RestaurantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.UserPreferences", "DietaryPreferences", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserPreferences", "DietaryPreferences");
            DropTable("dbo.SavedRestaurants");
            DropTable("dbo.Restaurants");
        }
    }
}
