using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product{Id=1,CategoryId=1,ProductName="Fare",UnitPrice=125},
                new Product{Id=2,CategoryId=1,ProductName="Klavye",UnitPrice=100},
                new Product{Id=3,CategoryId=2,ProductName="Elbise",UnitPrice=185},
                new Product{Id=4,CategoryId=2,ProductName="Pantolon",UnitPrice=100},
                new Product{Id=5,CategoryId=3,ProductName="Semsiye",UnitPrice=30}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.Id==product.Id);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int category)
        {
            return _products.Where(p=>p.CategoryId==category).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(c => c.Id == product.Id);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            
        }
    }
}
