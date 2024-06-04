using Microsoft.EntityFrameworkCore;
using Redmine.Entity.Concrete;

namespace Redmine.DAL.Concrete
{
    public class ApiContext:DbContext
    {
        public ApiContext(DbContextOptions options) : base(options)
        {}

        public DbSet<User> Users { get; set; }
    }
}
