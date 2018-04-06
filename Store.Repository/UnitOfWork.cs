using Store.Data.Persistence.DataContext;
using Store.Repository.Repositories;

namespace Store.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
            Categories = new CategoryRepository(_context);
        }

        public IProductRepository Products { get; }
        public ICategoryRepository Categories { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
