using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Redmine.DAL.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        T GetById(int id);
    }
}
