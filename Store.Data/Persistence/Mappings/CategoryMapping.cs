using System.Data.Entity.ModelConfiguration;
using ToDoList.Entity.Models;

namespace Store.Data.Persistence.Mappings
{
    public class CategoryMapping : EntityTypeConfiguration<Category>
    {

        public CategoryMapping()
        {
            ToTable("Category");

            HasKey(x => x.Id);
            Property(x => x.Description).HasMaxLength(60).IsRequired();

        }
    }
}
