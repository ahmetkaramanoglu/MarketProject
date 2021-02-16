using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public InMemoryCategoryDal()
        {
            _categories = new List<Category>()
            {
                new Category{Id=1,CategoryName="Teknoloji"},
                new Category{Id=2,CategoryName="Tekstil"},
                new Category{Id=3,CategoryName="Evlik"}
            };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = _categories.SingleOrDefault(c=>c.Id==category.Id);
            _categories.Remove(categoryToDelete);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.SingleOrDefault(c => c.Id == category.Id);
            categoryToUpdate.CategoryName = category.CategoryName;
        }
    }
}
