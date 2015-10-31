namespace NewsProject.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Claims;

    internal sealed class Configuration : DbMigrationsConfiguration<NewsProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NewsProject.Models.ApplicationDbContext context)
        {
            //var news = new News[]
            //{
            //   new News
            //{

            //    Image = "https://cdn.flipboard.com/flipboard.com/ac738020f2e7cf9dc7fe366a1994adebf2f4feb6/large.jpg",
            //    Title = "Keuchel sharp, Astros beat Yankees 3-0 in AL wild-card game",
            //    Author = "Kwame Opam",
            //    Description = "NEW YORK (AP) — A year ago, no one could've pictured this. Yet here they were, Dallas Keuchel and the Houston Astros,  ",
            //    FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            //},
            // new News
            // {

            //     Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
            //     Title = "Facebook Is Following You",
            //     Author = "Russell Brandom",
            //     Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
            //     FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            // },
            //  new News
            //  {

            //      Image = "http://o.aolcdn.com/hss/storage/midas/abca7b756bb17b5015c4a893cf22dc7b/202759823/Surface+Pro+4+fullbleed.jpg",
            //      Title = "UK pricing for Microsoft's Surface Pro 4, Lumia 950 phones ",
            //      Author = "Dan Seifert",
            //      Description = "It's fair to say that Microsoft's latest launch event was its most interesting for a long time. We finally learned that  ",
            //      FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            //  },
            //   new News
            //   {

            //       Image = "http://static4.businessinsider.com/image/562a6fd09dd7cc1e008c4448-1428-760/screen%20shot%202015-10-23%20at%201.34.13%20pm.png",
            //       Title = "I went to a seminar with one of the world's largest banks and almost everything said there was really bearish",
            //       Author = "Akin Oyedele",
            //       Description = "At HSBC's global-investment seminar in New York last week, some of the top strategists from Europe's largest bank laid out their outlook for global markets and economies.",
            //       FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            //   },
            //    new News
            //    {

            //        Image = "https://cdn.flipboard.com/businessinsider.com/558fa02299c854100961653524f142ec96cd6ea0/original.jpg",
            //        Title = "Google has bought abcdefghijklmnopqrstuvwxyz.com",
            //        Author = "Alexei Oreskovic",
            //        Description = "Now that Google is Alphabet, it's going to need some extra URLs to match its new identity. But the company may be  ",
            //        FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            //    },
            //     new News
            //     {

            //         Image = "https://cdn.flipboard.com/businessinsider.com/558fa02299c854100961653524f142ec96cd6ea0/original.jpg",
            //         Title = "Google has bought abcdefghijklmnopqrstuvwxyz.com",
            //         Author = "Alexei Oreskovic",
            //         Description = "Now that Google is Alphabet, it's going to need some extra URLs to match its new identity. But the company may be  ",
            //         FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            //     },
            //      new News
            //      {

            //          Image = "https://cdn.flipboard.com/businessinsider.com/558fa02299c854100961653524f142ec96cd6ea0/original.jpg",
            //          Title = "Google has bought abcdefghijklmnopqrstuvwxyz.com",
            //          Author = "Alexei Oreskovic",
            //          Description = "Now that Google is Alphabet, it's going to need some extra URLs to match its new identity. But the company may be  ",
            //          FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            //      },
            //       new News
            //       {

            //           Image = "https://cdn.flipboard.com/businessinsider.com/558fa02299c854100961653524f142ec96cd6ea0/original.jpg",
            //           Title = "Google has bought abcdefghijklmnopqrstuvwxyz.com",
            //           Author = "Alexei Oreskovic",
            //           Description = "Now that Google is Alphabet, it's going to need some extra URLs to match its new identity. But the company may be  ",
            //           FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            //       }
            //};



            var categories = new Category[]
            {
                new Category
                {
                    CategoryName ="Sports",
                    News = new News[]
                    {
                        new News {
                        Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Technology",
                    News = new News[]
                    {
                        new News {
                        Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                 new News
                   {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
             }


             }
            },

                        new Category
                {
                    CategoryName ="Business",
                    News = new News[]
                    {
                        new News {
                        Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Food",
                    News = new News[]
                    {
                        new News {
                 Image = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRJMMsBL7yFw4ign84MKfQF5eK1-zBM8lkhattKFSb2mL-Kt4a5WA",
                 Title = "Food",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Politics",
                    News = new News[]
                    {
                        new News {
                        Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Auto",
                    News = new News[]
                    {
                        new News {
                        Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Photography",
                    News = new News[]
                    {
                        new News {
                        Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Design",
                    News = new News[]
                    {
                        new News {
                        Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Style",
                    News = new News[]
                    {
                        new News {
                        Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Travel",
                    News = new News[]
                    {
                        new News {
                        Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Film",
                    News = new News[]
                    {
                        new News {
                        Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Gaming",
                    News = new News[]
                    {
                        new News {
                        Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Facebook Is Following You",
                 Author = "Russell Brandom",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
             }
                    }
                },


            };

            //context.News.AddOrUpdate(n => n.Title, news);
            context.Categories.AddOrUpdate(c => c.CategoryName, categories);



            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new ApplicationUserManager(userStore);
            // Ensure Stephen
            var user = userManager.FindByName("Priya@gmail.com");
            if (user == null)
            {
                // create user
                user = new ApplicationUser
                {
                    UserName = "Priya@gmail.com",
                    Email = "Priya@gmail.com"
                };
                userManager.Create(user, "codercamp123");
                // add claims
                userManager.AddClaim(user.Id, new Claim("ViewNews", "true"));
                userManager.AddClaim(user.Id, new Claim("CanEditProducts", "true"));
                userManager.AddClaim(user.Id, new Claim(ClaimTypes.DateOfBirth, "11/05/1985"));
            }
        }
    }
}
