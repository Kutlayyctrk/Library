using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity.Models
{
    public class CategoryTags:BaseEntity
    {
        public int? CategoryId { get; set; }
        public int? TagId { get; set; }
        //Relational Properties
        public Category Category { get; set; }
        public Tag Tag { get; set; }
    }
}
