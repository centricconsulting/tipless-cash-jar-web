namespace tiplessCashJar.repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingAbandon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbandonEntities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        GiverId = c.Guid(nullable: false),
                        RecipientId = c.Guid(nullable: false),
                        BeaconName = c.String(),
                        WhenCreated = c.DateTime(nullable: false),
                        WhenModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AbandonEntities");
        }
    }
}
