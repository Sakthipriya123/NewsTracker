using System.Collections.Generic;

namespace NewsProject.Models
{
    public interface IEFRepository
    {
        void Insert(News news);
        IList<News> ListNews();
    }
}