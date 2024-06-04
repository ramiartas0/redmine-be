using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Redmine.DAL.Abstract;
using Redmine.DAL.Concrete;

namespace Redmine.DAL.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        private readonly ApiContext _context;
        public GenericRepository(ApiContext context)
        {
            _context = context;
        }
        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            return filter != null ? _context.Set<T>().Where(filter).ToList() : _context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
