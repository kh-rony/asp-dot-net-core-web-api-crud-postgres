using asp_dot_net_core_web_api_crud_postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_dot_net_core_web_api_crud_postgres.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}