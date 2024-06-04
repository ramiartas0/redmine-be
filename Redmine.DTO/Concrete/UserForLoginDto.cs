using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redmine.DTO.Concrete
{
    public class UserForLoginDto
    {
        public string Email { get; set; }
        public string UserPassword { get; set; }
    }
}
