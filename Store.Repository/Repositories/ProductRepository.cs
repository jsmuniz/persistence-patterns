using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Data.Persistence.DataContext;
using ToDoList.Entity.Models;

namespace Store.Repository.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }

        public Product GetFirstProduct()
        {
            return Context.Products.FirstOrDefault();
        }
    }
}
