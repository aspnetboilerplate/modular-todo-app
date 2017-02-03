using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using TodoModule.Users;

namespace TodoModule.Todos
{
    [Table("TodoItems")]
    public class TodoItem : CreationAuditedEntity, IMustHaveTenant
    {
        public int TenantId { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Text { get; set; }
        
        [ForeignKey(nameof(AssignedUserId))]
        public TodoUser AssignedUser { get; set; }

        public long AssignedUserId { get; set; }
    }
}
