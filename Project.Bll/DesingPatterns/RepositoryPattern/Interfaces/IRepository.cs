using Project.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Bll.DesingPatterns.RepositoryPattern.Interfaces
{
    internal interface IRepository<T> where T : BaseEntity
    {
        //Queries
        List<T> GetAll();
        T Get(int id);
        List<T> GetActives();
        List<T> GetUpdates();
        List<T> GetPassives();
        List<T> Where(Expression<Func<T, bool>> exp);

        //Commands

        void Create(T entity);
        void Update(T entity);
        void SoftDelete(int id);
        void HardDelete(int id);
    }
}
