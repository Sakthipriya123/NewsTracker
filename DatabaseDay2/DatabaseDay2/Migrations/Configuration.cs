namespace DatabaseDay2.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseDay2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseDay2.Models.ApplicationDbContext context)
        {
            var categories = new Category[]
            {
                new Category
                {
                    Name = "SciFi",
                    Movies = new Movie[]
                    {
                        new Movie {Title="Ex Machina" },
                        new Movie {Title="Blade" }
                    }
                },
                new Category
                {
                    Name = "Drama",
                    Movies = new Movie[]
                    {
                        new Movie {Title="The GodFather" },
                    }
                }
            };

            context.Categories.AddOrUpdate(c => c.Name, categories);
        }
    }
}
