using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Redmine.DAL.Abstract;
using Redmine.DAL.Concrete;
using Redmine.DAL.Repositories;
using Redmine.Entity.Concrete;

namespace Redmine.DAL.Entity
{
    public class EfUserDal:GenericRepository<User>,IUserDal
    {
        public EfUserDal(ApiContext context): base (context)
        {
            
        }
    }
}
