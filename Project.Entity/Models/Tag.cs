using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }

        //Relational Properties
        public List<CategoryTag> CategoryTag { get; set; }

    }
}
