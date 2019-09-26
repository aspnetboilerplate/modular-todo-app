using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ModularTodoApp.Configuration.Dto;

namespace ModularTodoApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ModularTodoAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
