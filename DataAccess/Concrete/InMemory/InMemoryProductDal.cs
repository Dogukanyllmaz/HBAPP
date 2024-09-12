using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {

        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{CategoryId=1, ProductId=1, ProductName="Bardak", UnitsInStock=15, UnitPrice=15},
                new Product{CategoryId=1, ProductId=2, ProductName="Tabak", UnitsInStock=587, UnitPrice=145},
                new Product{CategoryId=2, ProductId=3, ProductName="Klavye", UnitsInStock=15000, UnitPrice=1435},
                new Product{CategoryId=3, ProductId=4, ProductName="Telefon", UnitsInStock=345, UnitPrice=125}
            };
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Remove(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
