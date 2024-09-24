using CloudCraftsmenTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudCraftsmenTodo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<TodoItem> Todos { get; set; }
    }
}
