using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ModularTodoApp.Authorization.Roles;
using ModularTodoApp.Authorization.Users;
using ModularTodoApp.MultiTenancy;

namespace ModularTodoApp.EntityFrameworkCore
{
    public class ModularTodoAppDbContext : AbpZeroDbContext<Tenant, Role, User, ModularTodoAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ModularTodoAppDbContext(DbContextOptions<ModularTodoAppDbContext> options)
            : base(options)
        {
        }
    }
}
