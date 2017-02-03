using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using Microsoft.Extensions.Configuration;
using ModularTodoApp.Configuration;
using ModularTodoApp.Web;
using TodoModule.Todos;
using TodoModule.Users;

namespace TodoModule.EntityFramework
{
    //[DbConfigurationType(typeof(TodoModuleDbConfiguration))]
    public class TodoDbContext : AbpDbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<TodoUser> TodoUsers { get; set; }

        /* Default constructor is needed for EF command line tool. */
        public TodoDbContext()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder()
                );

            return configuration.GetConnectionString(
                "Default"
                );
        }

        /* This constructor is used by ABP to pass connection string.
         * Notice that, actually you will not directly create an instance of ModularTodoAppDbContext since ABP automatically handles it.
         */
        public TodoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection. */
        public TodoDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }

        public TodoDbContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {

        }
    }

    //public class TodoModuleDbConfiguration : DbConfiguration
    //{
    //    public TodoModuleDbConfiguration()
    //    {
    //        SetProviderServices(
    //            "System.Data.SqlClient",
    //            System.Data.Entity.SqlServer.SqlProviderServices.Instance
    //        );
    //    }
    //}
}
