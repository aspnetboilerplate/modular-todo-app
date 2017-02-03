using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace TodoModule.Todos.Dto
{
    [AutoMapFrom(typeof(TodoItem))]
    public class TodoItemDto : EntityDto
    {
        public string Text { get; set; }

        public long AssignedUserId { get; set; }

        public string AssignedUserUserName { get; set; }
    }
}