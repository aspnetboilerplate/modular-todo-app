using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ModularTodoApp.Configuration;
using ModularTodoApp.Web;

namespace ModularTodoApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ModularTodoAppDbContextFactory : IDesignTimeDbContextFactory<ModularTodoAppDbContext>
    {
        public ModularTodoAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ModularTodoAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ModularTodoAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ModularTodoAppConsts.ConnectionStringName));

            return new ModularTodoAppDbContext(builder.Options);
        }
    }
}
