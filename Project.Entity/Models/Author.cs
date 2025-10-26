using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity.Models
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }

        //Relational Properties
        public List<Book> Books { get; set; }
    }
}
