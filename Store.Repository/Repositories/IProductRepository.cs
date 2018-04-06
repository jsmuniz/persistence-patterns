using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entity.Models;

namespace Store.Repository.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetFirstProduct();
    }
}
