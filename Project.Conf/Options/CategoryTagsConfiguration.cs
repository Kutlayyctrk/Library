using Project.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project.Conf.Options
{
    public class CategoryTagsConfiguration : BaseConfiguration<CategoryTags>
    {
        public CategoryTagsConfiguration()
        {
            Ignore(x => x.Id).HasKey(x => new
            {
                x.CategoryId,
                x.TagId
            });
        }
    }
}
