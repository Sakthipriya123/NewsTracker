using System.Collections.Generic;
using NewsProject.Models;

namespace NewsProject.Services
{
    public interface ICategoryServices
    {
        CategoryView GetNews(int id);
        IList<Category> ListCategories();
    }
}