using Project.Conf.Options;
using Project.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BookConfiguration());
            modelBuilder.Configurations.Add(new RoomConfiguration());
            modelBuilder.Configurations.Add(new AuthorConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());
            modelBuilder.Configurations.Add(new CategoryTagsConfiguration());
            modelBuilder.Configurations.Add(new ShelfConfiguration());
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryTags> CategoryTags { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
