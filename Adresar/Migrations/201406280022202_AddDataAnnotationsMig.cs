namespace Adresar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationsMig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kontakts", "Ime", c => c.String(nullable: false));
            AlterColumn("dbo.Kontakts", "Prezime", c => c.String(nullable: false));
            AlterColumn("dbo.Kontakts", "Telefon", c => c.String(nullable: false, maxLength: 16));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kontakts", "Telefon", c => c.String());
            AlterColumn("dbo.Kontakts", "Prezime", c => c.String());
            AlterColumn("dbo.Kontakts", "Ime", c => c.String());
        }
    }
}
