using Abp.Application.Navigation;
using Abp.Localization;

namespace TodoModule.Web.Navigation
{
    public class TodoNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu.AddItem(
                new MenuItemDefinition(
                    TodoAppPageNames.Tasks,
                    new FixedLocalizableString("Tasks"),
                    icon: "fa fa-tasks",
                    url: "Todos",
                    requiresAuthentication: true
                )
            );
        }
    }
}
