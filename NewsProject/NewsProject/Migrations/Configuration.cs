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
                        Image = "http://img.bleacherreport.net/img/images/photos/003/539/038/hi-res-750a656170f88520da1a3de33b586cb4_crop_north.jpg?w=630&h=420&q=75",
                 Title = "Seattle Seahawks vs. Dallas Cowboys Betting Odds, Analysis, NFL Pick",
                 Author = "Seth Wenig",
                 Description = "The Dallas Cowboys are a bad bet at the moment, with just one cover through their first six games of this season. The Seattle Seahawks aren't much better, with just two covers through their first seven games. Two teams that were supposed to contend in the NFC this season but own losing records at the moment meet when the Cowboys host the Seahawks on Sunday afternoon.",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "https://i.ytimg.com/vi/ATG96McESIE/hqdefault.jpg",
                 Title = "Blake Griffin showed the complete package against the Kings",
                 Author = "Jesus Gomez",
                 Description = "Don't ever say Blake Griffin is just a dunker. His season-opening performance against the Kings further drives that point home. In his first game of the season, Blake Griffin proved why his name belongs on the short list for possible MVP candidates. He destroyed Sacramento's defense to the tune of …",
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
                        Image = "https://timedotcom.files.wordpress.com/2015/10/arrow1.png?w=488",
                 Title = "Microsoft Created an Android App That Intelligently Organizes Your Phone",
                 Author = "Russell Brandom",
                 Description = "Microsoft's Arrow for Android arranges apps based on how frequently they're used. Microsoft promises that its latest Android app will make it easier than ever to find commonly used apps without having to dig through your phone.",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                 new News
                   {

                 Image = "http://rack.3.mshcdn.com/media/ZgkyMDE1LzEwLzI5LzQwL1Byb2plY3RMb29uLjI4Mjg3LmpwZwpwCXRodW1iCTk1MHg1MzQjCmUJanBn/5586bb0b/80c/Project-Loon.jpg",
                 Title = "Google to bring balloon-powered Internet to Indonesia's 17,000 islands",
                 Author = "Stan Shroedder",
                 Description = "Delivering reliable Internet access to a country that has more than 17,000 islands, which are scattered across a vast area of the Indian and Pacific ocean, is a challenge.",
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
                        Image = "http://www.gannett-cdn.com/-mm-/6396456d9c64b32271ba281facbc93eb30f07301/c=199-0-3302-2333&r=x404&c=534x401/local/-/media/2015/10/29/USATODAY/USATODAY/635817015317935515-WALL-STREET.10.23.15.A.JPG",
                 Title = "Stocks drop on slower GDP growth, possible Dec. rate hike",
                 Author = "Adam Shell",
                 Description = "The stock market's yo-yo reaction to the Fed's hints that they still might pull the trigger on an interest rate increase at its final meeting of the year continued in today's session. Yesterday, stocks first tumbled on the Fed's suggestion that rate increases remain on the table for 2015, only to rally into the close leaving the Dow up nearly 200 points, or 1.1%.",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "https://qzprod.files.wordpress.com/2015/10/ibm-weather.jpeg?quality=80&strip=all&w=1600",
                 Title = "IBM is going to change how we forecast the weather with Watson",
                 Author = "Mike Murphy",
                 Description = "IBM’s Watson might soon be your new weatherman. The company’s deal, said to be worth $2 billion plus, to buy the digital and technology pieces of the Weather Company’s business—the company that runs the Weather Channel—marks IBM’s first consumer-facing purchase in years.",
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
                        Image = "http://images.food52.com/OjgFEF92jQbIzY8l0osrZ5YAuzI=/753x502/698c3e7e-b5ec-468c-8755-cbec90f4cddf--2015-0720_chile-roasted-chicken-and-sweet-potatoes-with-cilantro-rice_mark-weinberg_543.jpg",
                 Title = "8 Chicken Dishes to Eat Out of a Bowl (That Aren't Soup)",
                 Author = "Leslie Stephens",
                 Description = "If we had to pick a favorite piece of dinnerware, it would be the bowl. There's something so comforting about being able to cradle our entire meal in the palm of our hands—without fear of runaway peas or unclaimed sauce. When plates just won't do and you're looking for something with a little more chutzpah than chicken noodle soup, turn to these 8 bowl-friendly, hearty chicken dishes: ",
                 FullArticle = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
                         },
                        new News
             {

                 Image = "http://i.huffpost.com/gen/3600560/images/n-SCRAMBLED-EGGS-large570.jpg",
                 Title = "McDonald's 'Test Lab' Gets a New Menu",
                 Author = "Russell Brandom",
                 Description = "McDonald's says The Corner café that it opened in Australia last December is proving to be a successful incubator for new menu items but the company doesn't intend to open another location. The concept's new menu, launched October 22, moves even farther away from burgers and fries, which means some interesting food items could work their way onto the McDonald's or McCafé menus there.",
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

