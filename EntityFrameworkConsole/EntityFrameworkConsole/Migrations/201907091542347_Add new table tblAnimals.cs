namespace EntityFrameworkConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddnewtabletblAnimals : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAnimals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Weight = c.Single(nullable: false),
                        Say = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblAnimals");
        }
    }
}
