using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class CategoryDAO
    {
        private static CategoryDAO instance = null;
        private static object instanceLock = new object();
        private CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                return instance;
            }
        }

        public List<Category> GetCategories()
        {
            using var db = new DoCaPrnContext();
            return db.Categories.ToList();
        }

        public Category GetCategoryByCategory(string categoryName)
        {
            var tmp = GetCategories().SingleOrDefault(c => c.Name.Equals(categoryName));
            return tmp;
        }

        public Category GetCategoryByCategoryId(int id)
        {
            var tmp = GetCategories().SingleOrDefault(c => c.Id == id);
            return tmp;
        }

        public void CreateCategory(Category category)
        {
            using var db = new DoCaPrnContext();
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            using var db = new DoCaPrnContext();
            db.Categories.Update(category);
            db.SaveChanges();
        }
    }
}
