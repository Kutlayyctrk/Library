using Project.Bll.DesingPatterns.RepositoryPattern.Interfaces;
using Project.Bll.DesingPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.Bll.DesingPatterns.RepositoryPattern.EfBaseRepository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        readonly MyContext _context;
        readonly DbSet<T> _dbSet;

        public BaseRepository()
        {
            _context = DbTool.DbContext;
            _dbSet = _context.Set<T>();
        }
        protected void Save()
        {
            _context.SaveChanges();
        }
        public void Create(T entity)
        {
           _dbSet.Add(entity);
            Save();
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetActives()
        {
            return _dbSet.Where(x=>x.Status!=Entity.Enums.DataStatus.Deleted).ToList();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public List<T> GetPassives()
        {
            return _dbSet.Where(x => x.Status == Entity.Enums.DataStatus.Deleted).ToList();
        }

        public List<T> GetUpdates()
        {
            return _dbSet.Where(x => x.Status == Entity.Enums.DataStatus.Updated).ToList();
        }

        public void HardDelete(int id)
        {
           T value=_dbSet.Find(id);
            if(value!=null)
            {
                _dbSet.Remove(value);
                Save();
            }
        }

        public void SoftDelete(int id)
        {
            T value = _dbSet.Find(id);
            value.DeletedDate = DateTime.Now;
            value.Status = Entity.Enums.DataStatus.Deleted;
            Save();
        }

        public void Update(T entity)
        {
            T originalValue = _dbSet.Find(entity.Id);
            entity.UpdateDate = DateTime.Now;
            entity.Status=Entity.Enums.DataStatus.Updated;

            _context.Entry(originalValue).CurrentValues.SetValues(entity);
            Save();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _dbSet.Where(exp).ToList();
        }
    }
}
