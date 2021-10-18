namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "CreationTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "CreationTime", c => c.DateTime(nullable: false));
        }
    }
}
