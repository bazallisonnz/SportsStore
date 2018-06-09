﻿using System.Collections.Generic;

namespace SportsStore.Models
{
    public class CategoryRepository
        : ICategoryRepository
    {
        private DataContext context;

        public CategoryRepository(DataContext ctx) => context = ctx;
        public IEnumerable<Category> Categories => context.Categories;

        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
        }


        public void DeleteCategory(Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
        }
    }
}
