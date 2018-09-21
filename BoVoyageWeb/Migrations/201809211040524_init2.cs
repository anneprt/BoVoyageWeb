namespace BoVoyageWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "Email", c => c.String());
        }
    }
}
