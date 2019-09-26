using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ModularTodoApp.Configuration;
using ModularTodoApp.Web;

namespace TodoModule.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else  */
    public class TodoModuleDbContextFactory : IDesignTimeDbContextFactory<TodoModuleDbContext>
    {
        public TodoModuleDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TodoModuleDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(TodoModuleCoreConsts.ConnectionStringName)
            );

            return new TodoModuleDbContext(builder.Options);
        }
    }
}