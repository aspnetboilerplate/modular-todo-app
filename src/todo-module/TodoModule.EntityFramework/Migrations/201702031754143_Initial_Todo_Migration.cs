namespace TodoModule.EntityFramework.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Todo_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TodoItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenantId = c.Int(nullable: false),
                        Text = c.String(nullable: false, maxLength: 1024),
                        AssignedUserId = c.Long(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_TodoItem_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AbpUsers", t => t.AssignedUserId, cascadeDelete: true)
                .Index(t => t.AssignedUserId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TodoItems", "AssignedUserId", "dbo.AbpUsers");
            DropIndex("dbo.TodoItems", new[] { "AssignedUserId" });
            DropTable("dbo.TodoItems",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_TodoItem_MustHaveTenant", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
