using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoModule.Todos;
using TodoModule.Users;

namespace TodoModule.EntityFrameworkCore
{
    public class TodoModuleDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<TodoUser> TodoUsers { get; set; }

        public TodoModuleDbContext(DbContextOptions<TodoModuleDbContext> options) 
            : base(options)
        {

        }
    }
}
