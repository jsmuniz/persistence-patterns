using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Store.Data.Persistence.DataContext;
using Store.Repository;
using ToDoList.Entity.Models;

namespace Store.Service.Services
{
    public class CategoryService : IService<Category>
    {
        private readonly UnitOfWork _unitOfWork;

        public CategoryService(DataContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }
        public Category Get(int id)
        {
            return _unitOfWork.Categories.Get(id);

        }

        public IQueryable<Category> GetAll()
        {
            return _unitOfWork.Categories.GetAll().AsQueryable();
        }

        public IQueryable<Category> Find(Expression<Func<Category, bool>> predicate)
        {
            return _unitOfWork.Categories.Find(predicate).AsQueryable();
        }

        public void Add(Category category)
        {
            _unitOfWork.Categories.Add(category);
            _unitOfWork.Complete();

        }

        public void AddRange(IEnumerable<Category> categories)
        {
            _unitOfWork.Categories.AddRange(categories);
            _unitOfWork.Complete();

        }

        public void Update(Category category)
        {
            _unitOfWork.Categories.Update(category);
            _unitOfWork.Complete();

        }

        public void Remove(Category category)
        {
            _unitOfWork.Categories.Remove(category);
            _unitOfWork.Complete();

        }

        public void RemoveRange(IEnumerable<Category> categories)
        {
            _unitOfWork.Categories.RemoveRange(categories);
            _unitOfWork.Complete();

        }
    }
}
