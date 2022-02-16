namespace itproekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migra : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zabeleskas", "zabeleska", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zabeleskas", "zabeleska", c => c.String(nullable: false));
        }
    }
}
