namespace itproekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dnevniks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        datum = c.DateTime(nullable: false),
                        prvcas = c.String(nullable: false),
                        vtorcas = c.String(nullable: false),
                        tretcas = c.String(),
                        cetvrticas = c.String(),
                        petticas = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Ucenicis",
                c => new
                    {
                        broj = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        prezime = c.String(nullable: false),
                        makedonski = c.Int(nullable: false),
                        matematika = c.Int(nullable: false),
                        angliski = c.Int(nullable: false),
                        prirodninauki = c.Int(nullable: false),
                        muzicko = c.Int(nullable: false),
                        fizicko = c.Int(nullable: false),
                        likovno = c.Int(nullable: false),
                        izostanoci = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.broj);
            
            CreateTable(
                "dbo.Zabeleskas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        datum = c.DateTime(nullable: false),
                        zabeleska = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Zabeleskas");
            DropTable("dbo.Ucenicis");
            DropTable("dbo.Dnevniks");
        }
    }
}
