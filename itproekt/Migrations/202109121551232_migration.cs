namespace itproekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Zabeleskas", "zabeleska", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Zabeleskas", "zabeleska", c => c.String());
        }
    }
}
