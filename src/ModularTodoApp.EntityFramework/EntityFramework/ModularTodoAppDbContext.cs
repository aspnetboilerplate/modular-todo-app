using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Microsoft.Extensions.Configuration;
using ModularTodoApp.Authorization.Roles;
using ModularTodoApp.Configuration;
using ModularTodoApp.MultiTenancy;
using ModularTodoApp.Users;
using ModularTodoApp.Web;

namespace ModularTodoApp.EntityFramework
{
    [DbConfigurationType(typeof(ModularTodoAppDbConfiguration))]
    public class ModularTodoAppDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        /* Default constructor is needed for EF command line tool. */
        public ModularTodoAppDbContext()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder()
                );

            return configuration.GetConnectionString(
                ModularTodoAppConsts.ConnectionStringName
                );
        }

        /* This constructor is used by ABP to pass connection string.
         * Notice that, actually you will not directly create an instance of ModularTodoAppDbContext since ABP automatically handles it.
         */
        public ModularTodoAppDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection. */
        public ModularTodoAppDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }

        public ModularTodoAppDbContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {

        }
    }

    public class ModularTodoAppDbConfiguration : DbConfiguration
    {
        public ModularTodoAppDbConfiguration()
        {
            SetProviderServices(
                "System.Data.SqlClient",
                System.Data.Entity.SqlServer.SqlProviderServices.Instance
            );
        }
    }
}
