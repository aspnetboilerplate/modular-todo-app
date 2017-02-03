using System.Data.Entity.Migrations;
using EntityFramework.DynamicFilters;

namespace TodoModule.EntityFramework.Migrations
{
    public class Configuration : DbMigrationsConfiguration<TodoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TodoModule";
        }

        protected override void Seed(TodoDbContext context)
        {
            context.DisableAllFilters();

            //TODO: add seed data...

            context.SaveChanges();
        }
    }
}
