using System;
using System.Data.Entity;

namespace Preview_Spa5.Models
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext()
            : base("DefaultConnection")
        {
        }

        public TodoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> TodoLists { get; set; }
    }
}
