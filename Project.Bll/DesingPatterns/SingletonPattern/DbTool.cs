using Project.DAL.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Bll.DesingPatterns.SingletonPattern
{
    public class DbTool
    {
        DbTool() { }
        static MyContext _dbContext;

        public static MyContext DbContext
        {
            get
            {
                if (_dbContext == null) _dbContext = new MyContext();
                return _dbContext;
            }
        }
    }
}
