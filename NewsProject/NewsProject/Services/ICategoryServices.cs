using System.Collections.Generic;
using NewsProject.Models;

namespace NewsProject.Services
{
    public interface ICategoryServices
    {
        ICollection<News> GetNews(int id);
        IList<Category> ListCategories();
    }
}