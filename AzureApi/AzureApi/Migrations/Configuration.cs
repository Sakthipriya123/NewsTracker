namespace AzureApi.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AzureApi.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AzureApi.Models.ApplicationDbContext context)
        {
            var animals = new Animal[]
            {
                new Animal {Name ="Bear", Sound = "Roar" },
                new Animal {Name ="Mouse", Sound = "Squeek" },
                new Animal { Name ="Eagle", Sound = "Kree"}
            };
            context.Animal.AddOrUpdate(a => a.Name,animals);
            //when the publish folder came into the folder put the .gitignore file in that folder
        }
    }
}
