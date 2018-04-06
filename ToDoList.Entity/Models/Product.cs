using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Entity.Models
{
    public class Product
    {
        public Product()
        {
            this.AcquireDate = DateTime.Now;

        }

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime AcquireDate { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


    }
}
