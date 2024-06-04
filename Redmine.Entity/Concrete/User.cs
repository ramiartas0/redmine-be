using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redmine.Entity.Concrete
{
    public class User
    {
        public int ID { get; set; }
        public string? UserName { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? UserRole { get; set; }
        public bool? UserStatus { get; set; }
        public DateTime? UserCreateDate { get; set; }
        public DateTime UserModifiedDate { get; set; }
        public string? UserPassword { get; set; }
    }
}
