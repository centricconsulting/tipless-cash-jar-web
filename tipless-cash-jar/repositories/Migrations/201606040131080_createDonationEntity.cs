namespace tiplessCashJar.repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDonationEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DonationEntities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BeaconNumber = c.String(),
                        Amount = c.Int(nullable: false),
                        GiverId = c.Guid(nullable: false),
                        WhenCreated = c.DateTime(nullable: false),
                        WhenModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DonationEntities");
        }
    }
}
