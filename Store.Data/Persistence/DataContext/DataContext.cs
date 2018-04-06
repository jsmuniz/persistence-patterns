using System.Data.Entity;
using Store.Data.Persistence.Mappings;
using ToDoList.Entity.Models;

namespace Store.Data.Persistence.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ConnectionString")
        {
            Database.SetInitializer(new DataContextInitializer());

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());

            base.OnModelCreating(modelBuilder);
        }
    }

    public class DataContextInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {

    }
}
