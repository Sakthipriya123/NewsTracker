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
            //    Description = "NEW YORK (AP) � A year ago, no one could've pictured this. Yet here they were, Dallas Keuchel and the Houston Astros,  ",
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
                        Image = "http://img.bleacherreport.net/img/images/photos/003/541/204/hi-res-d3f2740b1e55a96750744acff408c6eb_crop_north.jpg?w=1260&h=840&q=100",
                 Title = "Fantasy Football Week 9 Cheat Sheet, Rankings Guide and Waiver Projections",
                 Author = " Steve Silverman ,",
                 Description = "Jameis Winston has become a major fantasy football factor, and the time has come to jump on him and add him to your roster if you need help at the quarterback position.",
                 FullArticle = "Jameis Winston has become a major fantasy football factor, and the time has come to jump on him and add him to your roster if you need help at the quarterback position.The NFL's No. 1 overall draft pick in 2015 is rounding into form, and his confidence is soaring after he led the Tampa Bay Buccaneers to a 23-20 road win over the Atlanta Falcons in Week 8.While Winston has gone through the growing pains nearly all rookie quarterbacks have to endure, he is starting to figure it out as he runs Lovie Smith's offense. The rookie is completing 58.6 percent of his passes and has thrown for an average of 222.0 yards per game. He has 10 touchdown passes and seven interceptions.Two of those numbers are quite notable. His yards-per-game mark is over 11 yards more than Aaron Rodgers' average of 210.1 yards per game. His interception total has not moved since throwing four picks against the Panthers in Week 4. He has played three consecutive games without getting picked.After running for a score and completing 16 of 29 passes for 177 yards and a touchdown against the Falcons, Winston could have his coming -out party this Sunday as the Bucs host the New York Giants."
                         },
                        new News
             {

                 Image = "http://cdn-jpg.si.com/sites/default/files/styles/si_gallery_slide/public/2015/11/03/brandonharristhefadetop.jpg?itok=Ldqkpjg5",
                 Title = "The Fade: Breaking down Week 10 college football odds, best bets",
                 Author = "WillGreen",
                 Description = "The Fade is your weekly college football column that breaks down some of the upcoming weekend�s best bets and takes a look at moves and news ",
                 FullArticle = "The Fade is your weekly college football column that breaks down some of the upcoming weekend�s best bets and takes a look at moves and news around the sports betting industry.With the thrilling endings of Michigan-Michigan State, Georgia Tech-Florida State and now the immortalized (Candy) Corn Elder Halloween return, college football just keeps on giving and giving. It gives us excitement, anger, confusion, joy; it gives us everything except predictability.But one of the surest ways of putting yourself in a position to predict, and therefore be profitable, is to fade big public bets and keep an eye on what sides �sharps,� or smarter bettors, are putting their money on."
             },

                        new News
             {

                 Image = "http://img.bleacherreport.net/img/images/photos/003/539/038/hi-res-750a656170f88520da1a3de33b586cb4_crop_north.jpg?w=630&h=420&q=75",
                 Title = "Seattle Seahawks vs. Dallas Cowboys Betting Odds, Analysis, NFL Pick",
                 Author = "Seth Wenig",
                 Description = "The Dallas Cowboys are a bad bet at the moment, with just one cover through their first six games of this season. The Seattle Seahawks aren't much better, with just two covers through their first seven games. Two teams that were supposed to contend in the NFC this season but own losing records at the moment meet when the Cowboys host the Seahawks on Sunday afternoon.",
                 FullArticle = "The Dallas Cowboys are a bad bet at the moment, with just one cover through their first six games of this season. The Seattle Seahawks aren't much better, with just two covers through their first seven games. Two teams that were supposed to contend in the NFC this season but own losing records at the moment meet when the Cowboys host the Seahawks on Sunday afternoon.Point spread: The Seahawks opened as six - point favorites; the total was 40.5 early in the week, according to sportsbooks monitored by Odds Shark (line updates and matchup report).NFL pick, via Odds Shark computer: 22.6 - 18.2 Seahawks Seattle isn't quite firing on all cylinders, but it's got Marshawn Lynch, a tough defense and a quarterback who can drive opposing defenses nuts.The Cowboys, on the other hand, are depending on Cassel and McFadden until Romo and Dez Bryant return.That's why the smart choice here is the Seahawks."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Technology",
                    News = new News[]
                    {
                        new News {
                        Image = "http://o.aolcdn.com/hss/storage/midas/d287178e036e95c01e9395f4b5b2ea4d/202914759/apple-hq-shutterstock.jpg",
                 Title = "Apple cuts a deal with failed sapphire screen supplier",
                 Author = "Mariella Moon ",
                 Description = "Apple and GT Advanced Technologies Inc. agreed to part ways back in 2014, after the latter filed for bankruptcy. ",
                 FullArticle = "Apple and GT Advanced Technologies Inc. agreed to part ways back in 2014, after the latter filed for bankruptcy. Now the two have reached a deal that will eradicate GT's $439 million loan from Cupertino, according to The Wall Street Journal. Apple originally tapped GT to make sapphire screens for its devices, but it became obvious that trouble was brewing when the iPhone 6 launched without one. It's unclear what really happened behind the scenes, but GT accused Apple of shifting specs and requiring the company to manufacture millions of units the iPhone-maker wasn't obligated to buy. Apple, on the other hand, said GT couldn't meet its goals. Either way, GT ended up not having any clients that can sustain its business. Under the terms of the deal, the manufacturer will have to auction pieces of equipment, including some of its 600 sapphire-making furnaces, by November 23rd. It will then hand everything it couldn't sell to Apple, which promised to nuke its debt completely"
                         },
                 new News
                   {

                 Image = "https://cdn.flipboard.com/wordpress.com/cb7f7e7acd87fb52648cf999c828a49726a0334c/large.jpg",
                 Title = "Chromecast Can Now Stream Live Television With Added Sling TV Support",
                 Author = " Sarah Perez ",
                 Description = "Sling TV, Dish�s streaming live TV service that offers a variety of cable TV channels, including ESPN, is now available on Google�s Chromecast.",
                 FullArticle = "Sling TV, Dish�s streaming live TV service that offers a variety of cable TV channels, including ESPN, is now available on Google�s Chromecast. The forthcoming addition of Sling TV support was first announced in September, when Google unveiled its updated Chromecast dongles which changed the design from a stick to a round and colorful disk in order to accommodate the device�s upgraded innards and its built-in HDMI cable.While Chromecast today supports dozen of apps, including Netflix, Hulu, Google Play Movies, HBO NOW, Pandora, Spotify, YouTube, and many more, Sling TV provides a way to watch live and on-demand television for the reduced price of $20 per month.With Sling�s entry - level package, you can access a core bundle of channels such as TBS, TNT, ESPN, Adult Swim, HGTV, A & E, History and more � essentially, many of the channels you may miss when you ditch your cable TV or satellite subscription.In addition, Sling TV allows you to add - on extra packages at $5 per month to further customize your programming lineup with things like more sports channels, Spanish - language television, kids� shows and more.You can also add on HBO for $15 per month.Sling TV previously supported a range of platforms, including desktop(Mac and PC), mobile(iOS, Android, and Amazon Fire devices), as well as Fire TV, Nexus Player and Roku, but the company said Chromecast support has been heavily in-demand among its user base.Google, meanwhile, has been steadily rolling an expanded selection of content that works with Chromecast, noting at the time of the Sling TV announcement that support for Showtime, NBA and MLB apps was also in the works."
                 },
                 new News
                   {

                 Image = "https://qzprod.files.wordpress.com/2015/10/google-billboards.jpg?quality=80&strip=all&w=1600",
                 Title = "Google is testing its ad technology on outdoor billboards",
                 Author = " Alice Truong",
                 Description = "Google�s advertising technology is currently powering outdoor billboards in some of London�s most high-traffic areas.",
                 FullArticle = "Google�s advertising technology is currently powering outdoor billboards in some of London�s most high-traffic areas.The search company is testing the automated selling and buying of digital billboard ads using technology from its DoubleClick subsidiary, reports Business Insider.Google purchased the ad space�including billboards in London�s Waterloo Station, Euston Road, and Vauxhall roundabout�and is using its technology to display different billboard ads relevant to passersby, depending on the time and location.�This test has highlighted a number of areas that are fundamentally different, and which will require further development and integration before this becomes a market reality,� Tim Coller, mobile solutions lead for DoubleClick, told the site.Google partnered with multiple outdoor advertising companies and creative agencies for its tests, which began this month and will end in November.Some of the challenges Coller highlighted so far include identifying the right engagement metrics and the collection of audience data.Unlike online advertising, it�s harder to quantify the precise impact�such as views and clicks�of more traditional formats, such as print or billboard ads.While this may only be a proof of concept, extending Google�s technology to outdoor ads could change what advertisers come to expect from the company.Not only can it put ads in front of people when they�re searching on their computers or using their mobile phones, but Google can also reach them when they�re away from their screens."

                 }
             }
            },

                        new Category
                {
                    CategoryName ="Business",
                    News = new News[]
                    {
                        new News {
                        Image = "http://cdn.geekwire.com/wp-content/uploads/2015/10/amazonshoppingtwtwo-620x465.jpg",
                 Title = "You can now shop on Amazon with your Fire TV",
                 Author = "Todd Bishop",
                 Description = "Amazon brings e-commerce to Fire TV and prepares to launch its own shopping channel",
                 FullArticle = "Amazon brings e-commerce to Fire TV and prepares to launch its own shopping channel.Last night, with just a few clicks of an Amazon Fire TV Stick remote, I bought a Hershey�s Halloween Snack Size Assortment 50-Count Bag of candy via my TV screen, for delivery to my house � without touching my phone or computer.This morning, the Amazon - powered TV interface was offering a Fitbit Charge for purchase in the same way, perhaps to help work off those extra calories. Is this all part of Amazon�s master plan? The answer is yes, but in a much bigger way than one person�s candy and exercise habits. Amazon has quietly rolled out e-commerce functionality on its Fire TV devices, the first step in a broader plan by the tech giant to integrate online shopping and product placement into the on-screen television experience.The test began two weeks ago, and is performing above expectations so far, according to a source with knowledge of the situation. Next up: GeekWire has learned that Amazon is developing its own shopping channel, like QVC but with the ability to purchase products directly from the screen.That channel is expected to roll out next year."
                         },
                        new News
             {

                 Image = "http://static4.businessinsider.com/image/5630e0e2bd86effb5b8ba3ac-763-572/screen%20shot%202015-10-06%20at%2011.27.46%20am.png",
                 Title = "Microsoft has trapped its biggest partners between a rock and a hard place",
                 Author = "Max Slater-Robinss",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "Sales in the PC industry are declining at around 11% per quarter, according to IDC, causing drops in profits for PC makers. Microsoft is somewhat insulated from this decline thanks to big enterprise sales, but the company's increased focus on hardware with the new Surface Book Pro � a high-end laptop with a touch screen � is making its partners anxious.[Surface] will bother OEMs and I know from conversations with OEMs they have mixed reactions,  says analyst Annette Zimmermann of Gartner. (Microsoft historically calls PC makers OEMs,  or original equipment manufacturers.)Business Insider spoke to one source at an PC maker who described Microsoft as a sleeping lion.For the time being, Microsoft still needs the PC makers to get to its goal of selling a billion Windows 10 PCs in the next few years.John Delaney, an analyst from IDC, told Business Insider that Microsoft is trying to bring excitement to the Windows vector with the Surface Book, and the company needs others on - board to help fuel the fire.Some PC makers, Dell and HP, have even set up deals to distribute the Surface Book to big companies through their enterprise consulting businesses.The truth is, we have entered a period in the industry where winning for the major players is no longer solely about capturing share, it�s about expanding the company�s footprint in the value chain,Huang told BI.Just how PC makers are going to continue creating value is, however, the multibillion dollar question. "
                        }
                    }
                },

                        new Category
                {
                    CategoryName ="Food",
                    News = new News[]
                    {
                        new News {
                 Image = "https://cdn3.vox-cdn.com/thumbor/94vaUAgzZsIddD-_kLmTEEMavFE=/165x0:2831x2000/800x600/filters:format(webp)/cdn0.vox-cdn.com/uploads/chorus_image/image/47561903/GettyImages-471371476.0.jpg",
                 Title = "Chipotle Linked to E. Coli Outbreak in Washington and Oregon",
                 Author = "Brenna Houck",
                 Description = "Chipotle has voluntarily closed 43 of its Washington and Oregon locations as health officials investigate an outbreak of E. coli food poisoning linked to the restaurant chain. At least 22 people � 19 in Washington and three in Portland, Oregon � have been sickened as a result of the bacteria, the Seattle Times reports. Of those, eight people have been hospitalized. Health officials are continuing to investigate the source of the E. coli.",
                 FullArticle = "Chipotle has voluntarily closed 43 of its Washington and Oregon locations as health officials investigate an outbreak of E. coli food poisoning linked to the restaurant chain. At least 22 people � 19 in Washington and three in Portland, Oregon � have been sickened as a result of the bacteria, the Seattle Times reports. Of those, eight people have been hospitalized. Health officials are continuing to investigate the source of the E. coli.In a statement, Chipotle spokesman Chris Arnold tells Eater, We immediately closed all of our restaurants in the area out of an abundance of caution, even though the vast majority of these restaurants have no reported problems. He adds: We are working with health department officials to determine the cause of this issue.We offer our deepest sympathies to those who have been affected by this situation.Despite its rising reputation as a healthy fast-casual option, 2015 hasn't been a great year for Chipotle from a Department of Health standpoint. In August, more than 60 customers were sickened after eating at a California Chipotle restaurant. Health officials later identified the cause of the poisoning as norovirus, a highly contagious food-borne illness spread through food, water, and contact with the infected. Then, in September, a salmonella outbreak related to tomatoes was linked to 17 Chipotle restaurants in Minnesota sickening at least 45 people."
                        },
                        new News
             {

                 Image = "http://images.huffingtonpost.com/2015-10-30-1446208086-3963664-cornongrill630x407-thumb.jpg",
                 Title = "A Smoked Side Dish for Thanksgiving: Creamed Corn",
                 Author = "Steven Raichlen",
                 Description = "I grew up in a boiled-corn culture (at least it was hypersweet corn from Maryland's Eastern Shore). So my first taste of grilled corn, in Trinidad and Tobago, came as a revelation. Grilling corn caramelizes its natural sugars--especially when you expose the kernels directly to the fire by grilling with the husk off.",
                 FullArticle = "I grew up in a boiled-corn culture (at least it was hypersweet corn from Maryland's Eastern Shore). So my first taste of grilled corn, in Trinidad and Tobago, came as a revelation. Grilling corn caramelizes its natural sugars--especially when you expose the kernels directly to the fire by grilling with the husk off.Taking it one step further, smoking corn gives this sweet vegetable a flavor that is familiar but otherworldly. The chile peppers in the recipe below (adapted from the forthcoming cookbook Project Smoke) provide a counterpoint to the sweetness. Think of this as a creamed corn casserole on steroids--an exciting side dish for Thanksgiving or any other meal.Don't own a grill or smoker? No problem. You can smoke the corn and onions using a handheld smoker or a stovetop smoker.Smoked Creamed Corn Yield: Serves 4 as a side dish Method: Stovetop smoking Equipment: Stovetop smoker; sawdust or small wood chips Ingredients: 4 ears of corn, shucked 1 small onion, peeled and quartered (leave the root end attached) Extra virgin olive oil Salt and freshly ground black pepper 4 tablespoons butter 1 poblano pepper, stemmed, seeded, and diced 1 jalape�o pepper, stemmed, seeded, and diced 1 1 / 2 tablespoons all-purpose flour(optional) 1 1 / 2 cups half and half, light cream, or, gasp, heavy cream 2 to 3 tablespoons brown sugar or granulated sugar (or to taste) 6 ounces grated cheddar or pepper Jack cheese(1 1 / 2 cups; optional) Freshly grated nutmeg Step 1: Set up the stovetop smoker according to the manufacturer's instructions. Step 2: Lightly brush the corn and onion pieces with olive oil and season generously with salt and pepper.Smoke the corn and onions on the stovetop smoker until darkly browned on all sides, 20 to 30 minutes.Transfer the corn and onions to a platter and let cool.The recipe can be prepared up to 48 hours ahead to this stage. Step 3: Cut the corn kernels off the cobs.The easiest way to do this is to lay the cobs flat on the cutting board and cut off the kernels with broad strokes of a chef's knife. Scrape the cobs with the back of the knife to capture the rest of the corn's flavorful juices.You should have about 3 cups.Scrape any burnt skin off the onions, trim off the root ends, and finely chop.Set the corn and onions aside. Step 4: In a medium saucepan, melt the butter over medium heat.Add the poblano and jalape�o peppers and saut� until softened. Sprinkle the flour over the peppers and continue to cook, stirring constantly, until the mixture thickens. Whisk in the half and half and sugar. Bring to a boil. Stir in the corn and onions. Reduce the heat, and simmer until the mixture is thick and richly flavored, about 5 minutes.Stir in the cheese. Correct the seasoning, adding salt and pepper to taste: the creamed corn should be highly seasoned.Transfer the creamed corn to a serving bowl and garnish with a whisper of grated nutmeg."
                        },

                         new News
             {

                 Image = "http://cdn-image.foodandwine.com/sites/default/files/styles/rd_home_hero_slide/public/unicorn1015-hd-wines-general.jpg?itok=6-UT3jSn",
                 Title = "What the Heck Is a Unicorn Wine, Anyway?",
                 Author = "Ray Isle",
                 Description = "For the past couple of years, folks in the wine business have been bandying about the term �unicorn wine.� It�s become a term of art within the biz for an elusive, rare, extraordinary wine�the sort of bottle you hope to see and rarely do.",
                 FullArticle = "For the past couple of years, folks in the wine business�primarily sommeliers�have been bandying about the term �unicorn wine.� (There�s even a hashtag for it on Twitter, #unicornwine.) It�s become a term of art within the biz for an elusive, rare, extraordinary wine�the sort of bottle you hope to see and rarely do, then plaster all over social media once you actually get the chance to try it.One does sort of wonder, though, why the unicorn? There are plenty of other rare, mythical creatures that probably deserve their own wines, like manticores, wendigos, hippogriffs, bonasusi and so on. (Though what wine would be appropriate for a bonasus, given that when attacked�at least according to Pliny the Elder�it squirts out three acres of burning dung at you, I really can�t say.).In any case, here are several not - exactly - official criteria for a true and proper unicorn wine.First, it has to exist in small quantities.Second, it has to be hard to find.Third, wine geeks have to get really excited when they come across it, rather like maidens who come across unicorns.It helps a lot if the winemaker was legendary and is now dead, though that�s not necessarily a requirement, ditto if the wine is extremely old and/ or from a region considered extremely cool by the sommelier crowd. The wine does not have to be expensive�elusiveness and coolness are more important�but regardless, most of them are.A quick glance at Twitter reveals people posting bottles such as the 1991 Gentaz - Dervieux C�te R�tie from the northern Rh�ne(dead winemaker, check; cool region, check; damn near impossible to find, check); a 1929 Domaine de la Roman�e Conti Les Gaudichots 1er Cru (old as hell, check; Burgundy, check; last wine ever from this cru from a legendary producer and absolutely, totally impossible to find; check); and Bartolo Mascarello's 1971 Barolo (dead guy, cool region, extremely old, check, check, check).Of course, not everyone can afford wines like these, even if they can find them�I certainly know I can't. So maybe there needs to be another category for more earthbound or less mythically obsessed wine drinkers. It would include wines you haven�t had yet that you�d really like to taste, but ones where that possibility isn�t just a complete absurdity. Almost-unicorn wines, say, or #myunicornwines. Make a list and start hunting. With some diligence and the willingness to drop a little cash here and there (and the help of wine-searcher.com), it shouldn't be impossible to track down a whole herd."
             }

    }
                },

                        new Category
                {
                    CategoryName ="Politics",
                    News = new News[]
                    {
                        new News {
                        Image = "http://static2.politico.com/dims4/default/227ed14/2147483647/resize/1160x%3E/quality/90/?url=http%3A%2F%2Fstatic.politico.com%2F91%2F9f%2Ffd5029244ff3a817a3e9f48cd972%2F20151103-frank-votersdysfunction-getty.jpg",
                 Title = "How Voters Cause Washington�s Gridlock",
                 Author = "BARNEY FRANK",
                 Description = "It�s all too common today to portray regular Americans as the victims of dysfunctional politicians. It�s certainly true that in recent years ",
                 FullArticle = "It�s all too common today to portray regular Americans as the victims of dysfunctional politicians. It�s certainly true that in recent years those in public office seem unable to make the combination of tough choices and difficult compromises necessary for our government to function. But elected decision makers don�t operate in a vacuum; they�re not self-selected autonomous actors who willfully refuse to work together as matters of personal choice or political temperament.Those decision makers, after all, were chosen by the very voters now complaining of dysfunction. And there is no basis for harshly condemning the elected while expressing sympathy for the electorate whose decisions put politicians in office.After all, the desires of the voters are a major influence on how officeholders behave once they are in power.The electorate as a whole has established the basis for gridlock by its biennial display of schizophrenia. In 2008, the people put Barack Obama in power, with a Democratic congressional majority. Two years later they gave the House to people who had made clear their determination to both do everything possible to stop Obama from achieving anything he wanted to accomplish and also to undo everything he had already done. Two years later, in 2012, they switched back to Barack Obama, renewing his mandate�only to revert to empowering his unrelenting opponents in 2014.To repeat a point I have made here earlier, this alternation of electoral winners has been particularly stressful because our Constitution staggers terms of federal officeholders. Had the winner in each cycle gained with their victory the ability to enact their agendas, we would not have suffered from gridlock, although we might have seen its opposite�policy whiplash. But with our Constitution calling for senators serving six - year terms, the president four, and House members two, it usually takes two successive biennial election victories to get the power to make major changes.Those who win every two years only to lose two years later do get the power to block further action. But this two - year - long time in power rarely carries with it the ability to undo previously enacted policy."
                        },
                        new News
             {

                 Image = "http://cdn.theatlantic.com/assets/media/img/mt/2015/11/RTS7K3/lead_960.jpg?1446663483",
                 Title = "Liberals Are Losing the Culture Wars",
                 Author = "DAVID M. HERSZENHORN",
                 Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
                 FullArticle = "In Tuesday�s elections, voters rejected recreational marijuana, transgender rights, and illegal-immigrant sanctuaries; they reacted equivocally to gun-control arguments; and they handed a surprise victory to a Republican gubernatorial candidate who emphasized his opposition to gay marriageDemocrats have become increasingly assertive in taking liberal social positions in recent years, believing that they enjoy majority support and even seeking to turn abortion and gay rights into electoral wedges against Republicans. But Tuesday�s results�and the broader trend of recent elections that have been generally disastrous for Democrats not named Barack Obama�call that view into question.Indeed, they suggest that the left has misread the electorate�s enthusiasm for social change, inviting a backlash from mainstream voters invested in the status quo.Democrats have increasingly seized the offensive on social issues in recent years, using opposition to abortion rights and gay marriage to paint Republican candidates as extreme and backward. In some cases, this has been successful: Red-state GOP Senate candidates Todd Akin and Richard Mourdock lost after making incendiary comments about abortion and rape in 2012, a year when Obama successfully leaned into cultural issues to galvanize the Democratic base. �The Republican Party from 1968 up to 2008 lived by the wedge, and now they are politically dying by the wedge,� Democratic consultant Chris Lehane told the New York Times last year, a view echoed by worried Republicans urging their party to get with the times.But the Democrats� culture-war strategy has been less successful when Obama is not on the ballot. Two campaigns that made abortion rights their centerpiece in 2014, Wendy Davis�s Texas gubernatorial bid and Mark Udall�s Senate reelection campaign in Colorado, fell far short. In most of the country, particularly between the coasts, it�s far from clear that regular voters are willing to come to the polls for social change. Gay marriage won four carefully selected blue - state ballot campaigns in 2012 before the Supreme Court took the issue to the finish line this year.Recreational marijuana has likewise been approved only in three blue states plus Alaska.Gun - control campaigners have repeatedly failed to outflank the N.R.A. in down - ballot elections that turned on the issue.Republicans in state offices have liberalized gun laws and restricted abortion, generating little apparent voter backlash."
                        }
                    }
                },

                        new Category
                {
                    CategoryName ="Auto",
                    News = new News[]
                    {
                        new News {
                        Image = "http://blogs-images.forbes.com/brookecrothers/files/2015/10/model-s-blue-small.jpg",
                 Title = "Tesla Model S Autopilot Appears To Self-Improve, Some Owners Say",
                 Author = "Russell Brandom",
                 Description = "The Model S Autopilot �learns,� improving the Autopilot experience, according to anecdotal accounts at Tesla Motors Club, a Tesla owners forum. One owner describes the Model S �diving� for an exit ramp initially but improving over a period of days.The owner says that days later, �I did not have to correct it at all.I find it remarkable that it is improving this rapidly.",
                 FullArticle = "The Model S Autopilot �learns,� improving the Autopilot experience, according to anecdotal accounts at Tesla Motors Club, a Tesla owners forum. One owner describes the Model S �diving� for an exit ramp initially but improving over a period of days.The owner says that days later, �I did not have to correct it at all.I find it remarkable that it is improving this rapidly.� Another owner had a similar experience. �I noticed that�the first time it took the curve at full speed and wasn�t able to stay in lane resulting in a �take control immediately� alert.After a few more times on this curve with firm pressure on the steering wheel it�s now learned to slow down and today had no issue taking the curve.Definitely learning,� the owner writes.Though it�s not clear what exactly is going on(and note there are some on the Tesla Motors Club forum who question the accounts), it is something that CEO Elon Musk discussed last month in a conference call. �The whole Tesla fleet operates as a network,� Musk said. �When one car learns something, the whole fleet learns something.� Musk also said that updates will happen regularly and the �car should improve each week�you�ll probably notice difference after a week or a few weeks.�Let�s see if Elon Musk addresses these anecdotal accounts in a future conference call."
                         },
                        new News
             {

                 Image = "http://o.aolcdn.com/hss/storage/midas/cf03bc27639c5e6ec1906db0bf6a30eb/202896944/nissan-intelligent-driving.jpg",
                 Title = "Nissan unleashes its autonomous car prototype in Japan",
                 Author = "Mariella Moon",
                 Description = "Nissan has begun testing its Leaf-based autonomous car prototype, not on private property, but on Japanese inner city roads and highways. To be exact, the automaker wants to put its Piloted Drive mode (part of its Intelligent Driving System) to the test, which can take control of the car in certain conditions. ",
                 FullArticle = "Nissan has begun testing its Leaf-based autonomous car prototype, not on private property, but on Japanese inner city roads and highways.To be exact, the automaker wants to put its Piloted Drive mode (part of its Intelligent Driving System) to the test, which can take control of the car in certain conditions.The mode's first version, which Nissan wants to add to production models by the end of 2016, enables a car to drive autonomously in heavy traffic on the highway. The company hopes to roll out the ability to change lanes by 2018, as well as the power to navigate city roads and intersections without human input by 2020.To make driving on busy urban roads possible, the Japanese corporation created a high-spec laser scanner that uses 3D measurement to determine the vehicle's distance from objects in the environment. It designed an eight-way camera with a 360-degree view of its surroundings to help the system make a decision when crossing intersections, as well. Just recently, Nissan also unveiled its IDS concept vehicle: an EV loaded with all these autonomous functions and can offer restaurant recommendations."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Photography",
                    News = new News[]
                    {
                        new News {
                        Image = "http://api.ning.com/files/wPLxwzT3RH*-99sCWv23w4gVXGnLYMibks9KLQ9SByDVzhTDFNI4Wiy35Q*9mjCtA7x*q-CPmTx058gnfl6nz1MeODjux3zm/FloatingMosqueweb.jpg?width=737&height=492",
                 Title = "Sharp Photography Tips & Techniques",
                 Author = "Klaus Herrmann",
                 Description = "There are lots of ingredients that go into making a spectacular photograph, but the most important is for the picture to be in sharp focus.",
                 FullArticle = "There are lots of ingredients that go into making a spectacular photograph, but the most important is for the picture to be in sharp focus. Even the slightest blur takes away from the picture, no matter how good the subject, lighting, and color. Photographers have somewhat varying opinions on what constitutes a tack sharp picture, but generally, a tack sharp photograph has good, clean lines. The picture has clear definition instead of a soft blending of lines�or even downright blurriness.There are several things you can do to increase your chances of getting that coveted tack sharp picture. Hand-Held Digital Photography Tips .If you�re hand-holding your camera, brace your arms against your sides to help steady the camera. If your camera has anti-shake technology, such as Vibration Reduction (VR) or Image Stabilization (IS) that can be switched on and off, this is the time to have it turned on.You can also lean against a wall or tree or whatever sturdy object that�s handy, and help keep yourself and your camera steady. Alternatively, lean or lay your camera or lens on some readily available sturdy object to help steady the camera.Steadying your camera by hooking the strap under your elbow and wrapping the rest around your forearm will also help stabilize the camera and hold it steady in your hand.Getting those tack sharp photos while hand - holding your camera can be difficult, so to increase your chances of getting that perfect shot, use the burst or continuous shooting mode to take several shots at once. That increases your chances that at least one of the pictures will be in sharp focus.  "                         },
                        new News
             {

                 Image = "http://api.ning.com/files/tx3GxNHqMI1Vy2WgwOhJcWEojxGndrPBLWvi40CXv0n4-cG-qKdtxatZd3gYIgd9bfUdUFDUH39XVErM*U28EGuzoe38dM-L/IMG_47741.jpg?width=737&height=490",
                 Title = "Photographing the Micro Landscape",
                 Author = "Klaus Herrmenn",
                 Description = " When I began making pictures of the landscape, it was always the big picture that mattered. And I suppose it�s the same for most of us. It was a case of taking a few exposures and then moving on to the next grand view. ",
                 FullArticle = "When I began making pictures of the landscape, it was always the big picture that mattered. And I suppose it�s the same for most of us. It was a case of taking a few exposures and then moving on to the next grand view.Then came the day when I needed to make some pictures�photographers will know what I mean�and the weather was against me. Uniformly grey clouds and lousy light are no recipe for great landscape shots."
                        }
                    }
                },

                        new Category
                {
                    CategoryName ="Design",
                    News = new News[]
                    {
                        new News {
                 Image = "http://assets.dwell.com/sites/default/files/styles/article_photo/public/2014/09/04/august-smart-lock-open-symbol.jpg?itok=jXZuz3bb",
                 Title = "Best of #ModernMonday: Digital and Analog Innovation in Design",
                 Author = "Luke Hopping",
                 Description = "SABO was invited to rethink the Paris apartment of a young fashion designer looking to maximize her space. ",
                 FullArticle = "SABO was invited to rethink the Paris apartment of a young fashion designer looking to maximize her space. The design consist of several partition removals and the insertion of a multi function thick wall acting as stair, office, display, closet, fabric storage, natural and artificial light source or sliding partitioning. The porous furniture allows for natural light to reach a central corridor as well as framing views between the new bedroom and the living room.The swaying steps of an alternate tread stair celebrates the surrounding hills and climbing culture of Montmartre.In the kitchen, a mini vertical garden provides fresh aromatic herbs thanks to a mix of direct sun exposure and specialized artificial lighting. A steel countertop with custom integrated drainer is welded in place to stretch over 15 foot seamlessly. In contrast is a whimsy floor composed of a 25 natural rubber strips of 14 different colors."
                         },
                        new News
             {

                 Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                 Title = "Architrecture",
                 Author = "Paul Keskeys",
                 Description = "Architecture starts when you carefully put two bricks together. There it begins.Mies van der Rohe�s words succinctly allude to the raw, fundamental qualities of masonry ",
                 FullArticle = "Architecture starts when you carefully put two bricks together. There it begins.Mies van der Rohe�s words succinctly allude to the raw, fundamental qualities of masonry that have made it one of architecture�s most loved building materials. From Louis Khan to Frank Lloyd Wright, some of the greatest architects of the past century have captured the collective imagination of the world with their remarkable uses of brick, creating some truly iconic buildings with the most humble of mediums.Despite its ancient origins, the varied texture, color, and shape of brick causes architects to continuously explore new and unexpected applications that harness this versatile material for the evolving needs of clients.Many of these innovative uses of masonry are detailed via stunning photography in Phaidon�s book of serious architectural eye candy simply entitled Brick.Many of the fa�ades featured can teach us how brick can be utilized to create a building envelope full of color, texture, and formal delight.Here, we explore seven approaches adopted by architects in recent times that channel the spirit of the classics while providing a modern twist.This is the best of brick:"
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Style",
                    News = new News[]
                    {
                        new News {
                        Image = "http://cdn-img.instyle.com/sites/default/files/styles/684xflex/public/1445373874/102015-nov-fragrance-lead.jpg?itok=MC-vZ_41",
                 Title = "Scents and Sensitivities: Why Your Nose Says No to Some Perfumes",
                 Author = "Amy Synnot",
                 Description = "Two friends walk into the fragrance aisle at a crowded department store. One shudders and makes a beeline for the shoe section while the other barely notices the tsunami of aromas.Been there? Turns out a person's scent receptiveness has a huge impact on the perception (and appreciation) of fragrance. InStyle's executive editor Amy Synnott sniffs out the best blends across the spectrum.",
                FullArticle =  "Two friends walk into the fragrance aisle at a crowded department store. One shudders and makes a beeline for the shoe section while the other barely notices the tsunami of aromas. Been there? Turns out a person's scent receptiveness has a huge impact on the perception (and appreciation) of fragrance. InStyle's executive editor Amy Synnott sniffs out the best blends across the spectrum.I've always known there was something a little unusual about my sense of smell. It is (and has always been) twitchy, like a raw, exposed nerve. When I was a child, the prospect of being stuck in a small elevator with an old lady and her noxious cloud of perfume was enough to make me break out in hives. I had a particularly hard time with spicy fragrances and powdery florals. On the other hand, there were some scents�the wild roses that blanketed the rocky shoreline near our beach house in Ogunquit, Maine, or the sweet lilies of the valley that grew in a dark corner of our backyard in Wellesley, Mass.�that had the opposite effect on me. They were my own Breakfast at Tiffany's, a sensory refuge where I could take a few intoxicating whiffs and begin to feel calm and centered again.In high school my aversion to heavy, synthetic fragrances intensified. This was the '80s, the era of bold, brash perfumes like Giorgio and Yves Saint Laurent's Opium ($67, yslbeautyus.com). My best friend wore Poison ($98; dior.com), and it grew like a black mold between us.I literally could not stand to be in the same room with her when she was wearing that famously sweet and potent perfume. (I later found out she was equally repulsed by the clean fragrances I gravitated toward.How, I wondered in my sensory self - absorption, could anyone be repulsed by the smell of fresh grapefruit ? Or Aveda's Shampure, to this day one of my all-time favorite scents?)"

                        },
                        new News
             {

                 Image = "http://cdn-img.instyle.com/sites/default/files/styles/684xflex/public/images/2015/10/103015-kylie-jenner-beauty.jpg?itok=W2AIHLwP",
                 Title = "Kylie Jenner Shares Her Favorite Travel Beauty Products",
                 Author = "Marianne Mychaskiw",
                 Description = "Though traveling like a Kardashian�private jet and all�isn't exactly realistic for the rest of us mere mortals, Kylie Jenner is at least helping us achieve that goal in the beauty departement. In the latest video posted to the star's website, Jenner shared some of her favorite travel beauty essentials, which includes a mix of affordable and luxury products we can only pray the TSA won't swipe.",
                 FullArticle = "Though traveling like a Kardashian�private jet and all�isn't exactly realistic for the rest of us mere mortals, Kylie Jenner is at least helping us achieve that goal in the beauty departement. In the latest video posted to the star's website, Jenner shared some of her favorite travel beauty essentials, which includes a mix of affordable and luxury products we can only pray the TSA won't swipe.First up, Kylie swears by the Suvara Spray On Sun (suvaraspraytan.com for locations) to keep her faux glow intact, noting that she particularly likes to use it on her face.I always get spray tans, and if you get spray tans, you know that it kind of comes off on your face first, so this is a little rejuvenation, she explains. You spray it and leave it overnight, and it kind of just makes your face tan again.Along with her dermatologist Christie Kidd's face cleanser, La Mer's iconic Creme de La Mer ($170; cremedelamer.com) is another skin care product Jenner always takes along for the ride.Throughout the day, she'll mist on Mario Badescu's Facial Spray with Aloe, Herbs and Rosewater($7; nordstrom.com) to keep her complexion hydrated; and as for her trademark pout, Jenner relies on the Mizzi Cosmetics Lip Luxe Honey Kiss Lip Balm($12; mizzicosmetics.com). The Victoria's Secret Coconut Passion Fragrance Mist ($18; victoriassecret.com) is her signature travel scent, though it's her tiny bottle of Purell ($2; drugstore.com) that ranks at the top of her must-have list.I always travel with Purell because when you're on planes and stuff, they say the bathroom water is not sanitary,says Jenner. So, I never wash my hands in the bathroom.The jury is still out on whether all of her staples will fit into a TSA-approved clear plastic bag stashed in our carry-on bag, but we're willing to give it the old college try. "
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Travel",
                    News = new News[]
                    {
                        new News {
                        Image = "http://www.travelandleisure.com/sites/default/files/styles/tnl_redesign_article_landing_page/public/bay-lake-tower-at-disney.jpg?itok=-FukDFME",
                 Title = "How to Save 55% on a Luxury Disney Vacation",
                 Author = "Laura Kreder",
                 Description = "Disney World's Deluxe Resorts appear to be out of reach for the average traveler; even a short stay can cost thousands of dollars�not to mention ",
                 FullArticle = "Disney World's Deluxe Resorts appear to be out of reach for the average traveler; even a short stay can cost thousands of dollars�not to mention the increasing cost of park tickets. But by renting vacation points from Disney Vacation Club (DVC) members, you can enjoy Disney at a discount.It's impossible to go to Disney without seeing the glossy ads for the Disney Vacation Club (DVC). Each year, members receive points that allow them to book accommodations at any deluxe resort with DVC rooms. This includes the majority of luxury resorts at Disney. When these points aren't used, members have the ability to rent (sell) their points to anyone, either directly or through a third-party service like the DVC Rental Store.The splurge for a Disney property is worthwhile.It allows visitors to live within the magical illusion of Disney for their entire vacations, and take advantage of added perks that are unavailable off - site.In recent years, Disney has added FastPass +, which allows resort guests to reserve a limited number of experiences up to 60 days in advance.That's right: Toy Story Mania without the 90-minute wait! Similarly, resort guests are able to make dining reservations up to 180 days in advance and enjoy extended magic hours in the park. Disney also provides complimentary airport transportation through their motor coach service, Disney Express. Disney's luxury resorts offer convenience, first-class service, and impeccable accomodations. There's only one problem: they're expensive. If you rent points from a DVC member, however, you can experience Disney savings well beyond any advertised special.The amount of points you'll be required to rent (purchase) will depend on several factors, including the resort and room type selected, season, and day of the week you visit. You may also be required to pay additional points if you are booking your accommodations more than seven months in advance. Once you've determined how many points are necessary, this figure is converted to a dollar amount."
                         },
                        new News
             {

                 Image = "http://skift.com/wp-content/uploads/2015/02/homeaway.jpg",
                 Title = "Expedia Acquires HomeAway For $3.9 Billion",
                 Author = "Dennis Schaal, ",
                 Description = "Skift Take: With more than 1 million paid listings in more than 190 countries, Expedia's pending acquisition of HomeAway is a game-changer in that it saves",
                 FullArticle = "Skift Take: With more than 1 million paid listings in more than 190 countries, Expedia's pending acquisition of HomeAway is a game-changer in that it saves Expedia years of building up its own vacation rental supply in an increasingly important lodging sector.� Dennis Schaal . Here we go: After years of speculation about whether it would be Expedia, TripAdvisor, the  Priceline Group or Google to do it, Expedia Inc. agreed to acquire HomeAway for $3.9 billion in cash and stock.Expedia Inc., which has over the last year acquired Travelocity, Orbitz Worldwide and Australia�s Wotif, obviously wasn�t done with its acquisition spree as it competes with the likes of the Priceline Group�s Booking.com and Airbnb in hotels and vacation rentals with Priceline, and apartments and increasingly vacation rentals in the case of Airbnb.HomeAway announced that its board of directors unanimously approved the acquisition by Expedia, which will include all of HomeAway�s global brands, including VRBO, HomeAway.com, and VacationRentals.com in the United States; HomeAway.co.uk and OwnersDirect.co.uk in the United Kingdom; HomeAway.de in Germany; Abritel.fr and Homelidays.com in France; HomeAway.es and Toprural.es in Spain; AlugueTemporada.com.br in Brazil; HomeAway.com.au and Stayz.com.au in Australia; and Bookabach.co.nz in New Zealand. Asia Pacific short-term rental site, travelmob.com.Expedia has been experimenting over the last year in the U.S.and Europe with integrating HomeAway�s vacation rentals, especially its online bookable properties, into Expedia�s hotel listings when consumers looked for stays around a week or more but Expedia was taking its time with the implementation.In the past, Expedia officials stated that while they were certainly interested in vacation rentals, and would aggressively onboard apartment listings in coming years, hotels would remain the priority.With more than 1 million paid listings in more than 190 countries, Expedia�s pending acquisition of HomeAway is a game - changer in that it saves Expedia years of building up its own vacation rental supply in an increasingly important lodging sector."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Film",
                    News = new News[]
                    {
                        new News {
                        Image = "https://pbs.twimg.com/media/CS_GvIaXIAA1Lbg.jpg:small",
                 Title = "New Star Wars: The Force Awakens Posters Feature Finn, Han, Leia, and More",
                 Author = "Kevin P. Sullivan ",
                 Description = "Fresh posters feature old and new faces and offer a glimpse at the mysterious film",
                 FullArticle = "Fresh posters feature old and new faces and offer a glimpse at the mysterious film.When a major film release is a month and a half away and you still don�t know what it�s actually about, that�s Mystery Box master J.J. Abrams� secret keeping at its fiercest. That�s why it�s so unexpected when something as standard as character posters drop for Star Wars: The Force Awakens.We still have no idea what Luke is up to, but new posters feature Finn(John Boyega), Rey(Daisy Ridley), Kylo Ren(Adam Driver), Han Solo(Harrison Ford), and Leia(Carrie Fisher).And it will have to do until The Force Awakens on Dec. 18."
                         },
                        new News
             {

                 Image = "https://uproxx.files.wordpress.com/2015/08/colin_trevorrow_jurassic_world.jpg?quality=90&w=650&h=384",
                 Title = "Steven Spielberg And Colin Trevorrow Are Turning �Jurassic World� Into A Trilogy",
                 Author = "DARIEL FIGUEROA",
                 Description = "Universal Pictures went HAM this year, scoring four of the top-ten highest grossing films of 2015. Currently occupying the top two spots with Jurassic World ($1.6 billion) ",
                 FullArticle = "Universal Pictures went HAM this year, scoring four of the top-ten highest grossing films of 2015. Currently occupying the top two spots with Jurassic World ($1.6 billion), and Furious 7 ($1.5 billion), the studio is mapping out plans on how to lay down enough track so the gravy train wraps itself around the decade. In a recent roundtable for The Hollywood Reporter, Universal executive, Donna Langley, commented on the successes of the smaller films as well as the big ones.Part of Universal�s plan lies in the able hands of Steven Spielberg and Jurassic World director Colin Trevorrow. While we already knew that one more Jurassic World film was on its way, Langley let us know that it�s not the only film in the current dinosaur saga that we�ll be subjected to.[Director] Colin Trevorrow is busy working on an outline. He�s been working with Steven [Spielberg]. And they have an idea for the next two movies actually.It was designed as a trilogy, unbeknown to us.It�s a happy surprise.Trevorrow is not attached to the second Jurassic World film, he has a commitment to Star Wars: Episode IX, but he is writing it, and stars Bryce Dallas Howard and Chris Pratt will be reprising their roles.The dinosaurs will be invading theaters once again on June 22, 2018."
             }
                    }
                },

                        new Category
                {
                    CategoryName ="Gaming",
                    News = new News[]
                    {
                        new News {
                        Image = "http://i2.wp.com/venturebeat.com/wp-content/uploads/2015/06/Halo-5-Guardians-E3-2015-Master-Chief-05.jpg?fit=930%2C9999",
                 Title = "Halo 5: Guardians sales top $400M in first week",
                 Author = "DEAN TAKAHASHI",
                 Description = "Microsoft didn�t say exactly how many copies it sold. But based on a $60 retail price, the number could be over 6.6 million sold so far",
                 FullArticle = "Microsoft didn�t say exactly how many copies it sold. But based on a $60 retail price, the number could be over 6.6 million sold so far. Halo 5: Guardians has a rating of 85 out of 100 on game review aggregator Metacritic. It is the highest-rated Xbox One exclusive title to date.So far, fans of the game, developed by Microsoft�s 343 Industries studio, have logged more than 21 million hours in the game, including 12 million hours in the campaign mode. The multiplayer modes have been played 9 million total hours with nearly 7 million multiplayer matches across Arena and the new Warzone mode. This is all according to Microsoft.Halo 5 has a new Requisition System, where you can earn points to get better equipment in Warzone battles. Players have gotten more than 45 million REQ packs and 568 million REQ cards.Halo 5: Live also earned a Guinness World Records �title� for the most-watched video game launch broadcast, with more than 330, 000 unique streams on the evening of the broadcast.Content from the broadcast generated 5.5 million total views throughout the week.That led to the game becoming the best - selling digital game ever in the Xbox store for an opening week.On Twitch, people watched more than 3 million hours of Halo 5.Again, these stats are from Microsoft.�The success of Halo 5: Guardians is a testament to the innovative work from the entire team at 343 Industries to bring this installment to Xbox One and the incredible community of fans who have come to love the story, characters and gameplay central to the franchise,� said Phil Spencer, head of Xbox, in a statement. �The game represents all the possibilities of Xbox One and has earned its place as the anchor title in the greatest holiday games lineup in Xbox history.� "                      
                        },
                        new News
             {

                 Image = "http://static4.gamespot.com/uploads/scale_super/536/5360430/2879022-image.img.jpg",
                 Title = "Star Wars Battlefront's Xbox One Early Release Includes 10 Hours of Gameplay",
                 Author = "Eddie Makuch ",
                 Description = "Star Wars Battlefront launches on Xbox One through EA Access on November 12, a full five days before the game's official release date. ",
                 FullArticle = "Star Wars Battlefront launches on Xbox One through EA Access on November 12, a full five days before the game's official release date. Now, EA has confirmed that gameplay will be capped at 10 hours. That's the typical gameplay duration for EA Access games, including the most recent release, Need for Speed.You can play Star Wars Battlefront for a total of 10 hours, EA said on Twitter. That includes any single - player missions or multiplayer battles.EA Access memberships are available for $5 / month or $30 / year.In addition to early play for upcoming games, members have access to a continually growing library of free games and can save 10 percent on all EA digital content.There is no word yet if EA Access will come to PlayStation 4."
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
                    FullName ="Priya",
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
