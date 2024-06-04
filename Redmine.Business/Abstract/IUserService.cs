using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Redmine.Entity.Concrete;

namespace Redmine.Business.Abstract
{
    public interface IUserService:IGenericService<User>
    {
        User SGetByEmail(string email);
    }
}
