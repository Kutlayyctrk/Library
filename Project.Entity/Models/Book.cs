using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }

        public int NumberOfPages { get; set; }
        public int? CategoryId { get; set; }
        public int? AuthorId { get; set; }
        public int? ShelfId { get; set; }

        //Relational Properties
        public Category Category { get; set; }
        public Author Author { get; set; }
        public Shelf Shelf { get; set; }
    }
}
