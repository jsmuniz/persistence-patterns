using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entity.Models;

namespace Store.Data.Persistence.Mappings
{
    public class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            ToTable("Product");
            HasKey(x => x.Id);
            Property(x => x.Description).HasMaxLength(160).IsRequired();
            Property(x => x.AcquireDate).IsRequired();

            HasRequired(x => x.Category);
        }
    }
}
