using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redmine.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void SInsert(T t);
        void SDelete(T t);
        void SUpdate(T t);
        List<T> SGetList();

        T SGetById(int id);

        // Kullanıcı adına göre kullanıcı getiren metot
        T SGetByUsername(string username);

    }
}
