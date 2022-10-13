namespace MVC_Crud.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_Crud.Models.Context.CrudDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;//true olarak değiştiryoruz
        }

        protected override void Seed(MVC_Crud.Models.Context.CrudDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
