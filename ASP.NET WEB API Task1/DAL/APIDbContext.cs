

using ASP.NET_WEB_API_Task1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_WEB_API_Task1.DAL
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
