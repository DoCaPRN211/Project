using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
        Category GetCategoryByCategory(string categoryName);
        Category GetCategoryByCategoryId(int id);
        void CreateCategory(Category category);
        void UpdateCategory(Category category);
    }
}
