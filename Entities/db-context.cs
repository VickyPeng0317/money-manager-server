using Microsoft.EntityFrameworkCore;
namespace money_manager_server.Entities
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        { }

        public DbSet<Test> test { get; set; }
    }
}