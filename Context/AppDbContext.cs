using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
