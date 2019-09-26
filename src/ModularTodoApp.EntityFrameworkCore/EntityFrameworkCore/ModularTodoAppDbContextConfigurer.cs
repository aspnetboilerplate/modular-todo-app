using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ModularTodoApp.EntityFrameworkCore
{
    public static class ModularTodoAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ModularTodoAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ModularTodoAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
