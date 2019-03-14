namespace MuziekInVlaanderen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Evenements", "Locatie");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Evenements", "Locatie", c => c.String(nullable: false));
        }
    }
}
