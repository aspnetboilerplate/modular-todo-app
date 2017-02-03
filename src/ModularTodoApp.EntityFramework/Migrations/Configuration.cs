using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using ModularTodoApp.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace ModularTodoApp.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<ModularTodoApp.EntityFramework.ModularTodoAppDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ModularTodoApp";
        }

        protected override void Seed(ModularTodoApp.EntityFramework.ModularTodoAppDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
