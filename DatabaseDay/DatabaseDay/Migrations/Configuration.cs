namespace DatabaseDay.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseDay.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DatabaseDay.Models.ApplicationDbContext context)
        {
            var movies = new Movie[]
            {
                 new Movie {Title="Terminator" , Director="Cameron" },
                 new Movie {Title="KingKong" , Director = "Jackson" },
                 new Movie {Title="Memento",Director = "Nolan" }
            };

            context.Movies.AddOrUpdate(m => m.Title, movies);
        }
    }
}
