using System.Threading.Tasks;
using ModularTodoApp.Configuration.Dto;

namespace ModularTodoApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
