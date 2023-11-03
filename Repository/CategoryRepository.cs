﻿using BusinessObject.Models;
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
        public List<Category> GetCategories()
            => CategoryDAO.Instance.GetCategories();

        public Category GetCategoryByCategory(string categoryName)
            => CategoryDAO.Instance.GetCategoryByCategory(categoryName);
    }
}