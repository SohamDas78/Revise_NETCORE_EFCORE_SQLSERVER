using Microsoft.EntityFrameworkCore;

namespace TodoBackend.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; } //actual table to be created
        public DbSet<TodoReadModel> TodoReadModels { get; set; } // Read Dto, no table to be created, modify migration script.
    }
}
