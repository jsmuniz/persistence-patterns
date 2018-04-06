using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Store.Data.Persistence.DataContext;
using Store.Repository;
using ToDoList.Entity.Models;

namespace Store.Service.Services
{
    public class ProductService : IService<Product>
    {
        private readonly UnitOfWork _unitOfWork;

        public ProductService(DataContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }
        public Product Get(int id)
        {
            return _unitOfWork.Products.Get(id);
        }

        public IQueryable<Product> GetAll()
        {
            return _unitOfWork.Products.GetAll().AsQueryable();
        }

        public IQueryable<Product> Find(Expression<Func<Product, bool>> predicate)
        {
            return _unitOfWork.Products.Find(predicate).AsQueryable();
        }

        public void Add(Product category)
        {
           _unitOfWork.Products.Add(category);
            _unitOfWork.Complete();
        }

        public void AddRange(IEnumerable<Product> products)
        {
            _unitOfWork.Products.AddRange(products);
            _unitOfWork.Complete();
        }

        public void Update(Product product)
        {
            _unitOfWork.Products.Update(product);
            _unitOfWork.Complete();
        }

        public void Remove(Product product)
        {
            _unitOfWork.Products.Remove(product);
            _unitOfWork.Complete();

        }

        public void RemoveRange(IEnumerable<Product> products)
        {
            _unitOfWork.Products.RemoveRange(products);
            _unitOfWork.Complete();

        }
    }
}
