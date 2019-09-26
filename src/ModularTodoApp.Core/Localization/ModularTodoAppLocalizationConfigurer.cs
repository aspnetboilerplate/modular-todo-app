using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ModularTodoApp.Localization
{
    public static class ModularTodoAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ModularTodoAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ModularTodoAppLocalizationConfigurer).GetAssembly(),
                        "ModularTodoApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
