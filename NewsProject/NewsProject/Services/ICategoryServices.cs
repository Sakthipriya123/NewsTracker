using System.Collections.Generic;
using NewsProject.Models;

namespace NewsProject.Services
{
    public interface ICategoryServices
    {
        CategoryListView GetNews(int id);
        IList<CategoryView> ListCategories();
    }
}