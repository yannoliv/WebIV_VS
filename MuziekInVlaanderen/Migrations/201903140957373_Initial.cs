namespace MuziekInVlaanderen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Evenements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titel = c.String(nullable: false),
                        Categorie = c.Int(nullable: false),
                        Locatie = c.String(nullable: false),
                        Beschrijving = c.String(nullable: false),
                        Datum = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Evenements");
        }
    }
}
