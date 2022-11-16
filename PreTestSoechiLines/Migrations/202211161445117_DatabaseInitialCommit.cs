namespace PreTestSoechiLines.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseInitialCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UOMs",
                c => new
                    {
                        IdUOM = c.Int(nullable: false, identity: true),
                        Satuan = c.String(),
                        Rate = c.Int(nullable: false),
                        Status = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdUOM);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UOMs");
        }
    }
}
