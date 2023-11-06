using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void CreateCategory(Category category)
            => CategoryDAO.Instance.CreateCategory(category);

        public List<Category> GetCategories()
            => CategoryDAO.Instance.GetCategories();

        public Category GetCategoryByCategoryId(int id)
            => CategoryDAO.Instance.GetCategoryByCategoryId(id);

        public Category GetCategoryByCategory(string categoryName)
            => CategoryDAO.Instance.GetCategoryByCategory(categoryName);

        public void UpdateCategory(Category category)
            => CategoryDAO.Instance.UpdateCategory(category);
    }
}
