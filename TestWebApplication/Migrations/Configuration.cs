namespace TestWebApplication.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestWebApplication.Models.TestModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "TestWebApplication.Models.TestModel";
        }

        protected override void Seed(TestWebApplication.Models.TestModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            List<Models.Category> cat_List = new List<Models.Category>();
            cat_List.Add(new Models.Category() { id=1, CategoryName="Shoes", Category_desc="This is shoe." });
            cat_List.Add(new Models.Category() { id = 2, CategoryName = "Watch", Category_desc = "This is watch" });

            foreach (var item in cat_List)
            {
                context.Categories.AddOrUpdate(item);
            }

            context.SaveChanges();















        }
    }
}
