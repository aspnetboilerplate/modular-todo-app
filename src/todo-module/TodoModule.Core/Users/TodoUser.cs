using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace TodoModule.Users
{
    [Table("AbpUsers")]
    public class TodoUser : Entity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}