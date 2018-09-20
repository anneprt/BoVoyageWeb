namespace BoVoyageWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agences",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NomAgence = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Civilite = c.String(nullable: false, maxLength: 4),
                        Nom = c.String(nullable: false, maxLength: 30),
                        Prenom = c.String(nullable: false, maxLength: 30),
                        Adresse = c.String(maxLength: 50),
                        Telephone = c.String(maxLength: 10),
                        DateNaissance = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Pays = c.String(nullable: false, maxLength: 30),
                        Continent = c.String(nullable: false, maxLength: 30),
                        Description = c.String(maxLength: 250),
                        AgenceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Agences", t => t.AgenceID, cascadeDelete: true)
                .Index(t => t.AgenceID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumeroDossier = c.String(nullable: false, maxLength: 30),
                        DestinationID = c.Int(nullable: false),
                        DateDepart = c.DateTime(nullable: false),
                        DateRetour = c.DateTime(nullable: false),
                        Prix = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateFin = c.DateTime(),
                        Statut = c.Boolean(nullable: false),
                        NombreParticipants = c.Int(),
                        ClientID = c.Int(nullable: false),
                        Assurance = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .ForeignKey("dbo.Destinations", t => t.DestinationID, cascadeDelete: true)
                .Index(t => t.DestinationID)
                .Index(t => t.ClientID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "DestinationID", "dbo.Destinations");
            DropForeignKey("dbo.Reservations", "ClientID", "dbo.Clients");
            DropForeignKey("dbo.Destinations", "AgenceID", "dbo.Agences");
            DropIndex("dbo.Reservations", new[] { "ClientID" });
            DropIndex("dbo.Reservations", new[] { "DestinationID" });
            DropIndex("dbo.Destinations", new[] { "AgenceID" });
            DropTable("dbo.Reservations");
            DropTable("dbo.Destinations");
            DropTable("dbo.Clients");
            DropTable("dbo.Agences");
        }
    }
}
