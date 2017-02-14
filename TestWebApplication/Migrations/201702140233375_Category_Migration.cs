namespace TestWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Category_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.id);

        }

        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
