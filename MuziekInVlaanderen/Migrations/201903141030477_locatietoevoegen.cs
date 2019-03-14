namespace MuziekInVlaanderen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locatietoevoegen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Evenements", "Locatie", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Evenements", "Locatie");
        }
    }
}
