using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public List<Book> Books { get; set; }
        public List<CategoryTag> CategoryTag { get; set; }

    }
}
