namespace tiplessCashJar.repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBeacon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BeaconEntities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        UUID = c.String(),
                        Major = c.String(),
                        Minor = c.String(),
                        WhenCreated = c.DateTime(nullable: false),
                        WhenModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BeaconEntities");
        }
    }
}
