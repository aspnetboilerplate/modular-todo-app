using System.ComponentModel.DataAnnotations;

namespace ModularTodoApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}