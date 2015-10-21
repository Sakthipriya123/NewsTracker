using NewsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsProject.API
{
    public class NewsAppController : ApiController
    {


        private static List<News> _news = new List<News>
        {
            new News {
                Id =1,
                Image = "https://cdn.flipboard.com/flipboard.com/ac738020f2e7cf9dc7fe366a1994adebf2f4feb6/large.jpg",
                Title = "Keuchel sharp, Astros beat Yankees 3-0 in AL wild-card game",
                Author = "Kwame Opam",
                Description = "NEW YORK (AP) — A year ago, no one could've pictured this. Yet here they were, Dallas Keuchel and the Houston Astros,  ",
               Category = "Sports",
               FullArticle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            },
             new News {
                Id =2,
                Image = "http://assets.bwbx.io/images/iwX6Mv5tU9Vs/v1/640x-1.jpg",
                Title = "Facebook Is Following You",
                Author = "Russell Brandom",
                Description = "You knew that, right? How else would Facebook know to serve that panda video straight into your newsfeed,  ",
               Category = "Technology",
               FullArticle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            },
              new News {
                Id =3,
                Image = "http://o.aolcdn.com/hss/storage/midas/abca7b756bb17b5015c4a893cf22dc7b/202759823/Surface+Pro+4+fullbleed.jpg",
                Title = "UK pricing for Microsoft's Surface Pro 4, Lumia 950 phones ",
                Author = "Dan Seifert",
                Description = "It's fair to say that Microsoft's latest launch event was its most interesting for a long time. We finally learned that  ",
               Category = "Technology",
               FullArticle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            },
               new News {
                Id = 4,
                Image = "https://cdn.flipboard.com/businessinsider.com/558fa02299c854100961653524f142ec96cd6ea0/original.jpg",
                Title = "Google has bought abcdefghijklmnopqrstuvwxyz.com",
                Author = "Alexei Oreskovic",
                Description = "Now that Google is Alphabet, it's going to need some extra URLs to match its new identity. But the company may be  ",
               Category = "Technology",
               FullArticle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            },
                new News {
                Id = 5,
                Image = "https://cdn.flipboard.com/businessinsider.com/558fa02299c854100961653524f142ec96cd6ea0/original.jpg",
                Title = "Google has bought abcdefghijklmnopqrstuvwxyz.com",
                Author = "Alexei Oreskovic",
                Description = "Now that Google is Alphabet, it's going to need some extra URLs to match its new identity. But the company may be  ",
               Category = "Technology",
               FullArticle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            },
                 new News {
                Id = 6,
                Image = "https://cdn.flipboard.com/businessinsider.com/558fa02299c854100961653524f142ec96cd6ea0/original.jpg",
                Title = "Google has bought abcdefghijklmnopqrstuvwxyz.com",
                Author = "Alexei Oreskovic",
                Description = "Now that Google is Alphabet, it's going to need some extra URLs to match its new identity. But the company may be  ",
               Category = "Technology",
               FullArticle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            },
                  new News {
                Id = 7,
                Image = "https://cdn.flipboard.com/businessinsider.com/558fa02299c854100961653524f142ec96cd6ea0/original.jpg",
                Title = "Google has bought abcdefghijklmnopqrstuvwxyz.com",
                Author = "Alexei Oreskovic",
                Description = "Now that Google is Alphabet, it's going to need some extra URLs to match its new identity. But the company may be  ",
               Category = "Technology",
               FullArticle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            },
                   new News {
                Id = 8,
                Image = "https://cdn.flipboard.com/businessinsider.com/558fa02299c854100961653524f142ec96cd6ea0/original.jpg",
                Title = "Google has bought abcdefghijklmnopqrstuvwxyz.com",
                Author = "Alexei Oreskovic",
                Description = "Now that Google is Alphabet, it's going to need some extra URLs to match its new identity. But the company may be  ",
               Category = "Technology",
               FullArticle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam eget sapien sapien. Curabitur in metus urna. In hac habitasse platea dictumst. Phasellus eu sem sapien, sed vestibulum velit. Nam purus nibh, lacinia non faucibus et, pharetra in dolor. Sed iaculis posuere diam ut cursus. Morbi commodo sodales nisi id sodales. Proin consectetur, nisi id commodo imperdiet, metus nunc consequat lectus, id bibendum diam velit et dui. Proin massa magna, vulputate nec bibendum nec, posuere nec lacus. Aliquam mi erat, aliquam vel luctus eu, pharetra quis elit. Nulla euismod ultrices massa, et feugiat ipsum consequat eu."
            }

        };
        
        
        
        
        // GET: api/NewsApp
        public List<News> Get()
        {
            return _news;
        }

        // GET: api/NewsApp/5
        public News Get(int id)
        {
            return _news.Find(m => m.Id == id);
        }

        // POST: api/NewsApp
        public void  Post(News value)
        {

            //return;
        }
  
        // PUT: api/NewsApp/5
        public string Put(int id, News value)
        {
             var news = _news.Find(m => m.Id == id);
            news.Title = value.Title;
            news.Image = value.Image;
            news.Author = value.Author;
            news.Description = value.Description;

            return news.Title + news.Image + news.Author + news.Description;
        }

        // DELETE: api/NewsApp/5
        public void Delete(int id)
        {
        }
    }
}
