using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity.Models
{
    public class Room : BaseEntity
    {
        public string Name { get; set; }

        //Relational Properties
        public List<Shelf> Shelves { get; set; }
    }
}
