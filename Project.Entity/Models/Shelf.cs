using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entity.Models
{
    public class Shelf : BaseEntity
    {

        public string Name { get; set; }
        public int? RoomId { get; set; }

        //Relational Properties
        public List<Book> Books { get; set; }
        public Room Room { get; set; }
    }
}
