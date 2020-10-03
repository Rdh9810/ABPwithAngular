using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace WebWithAngular.Localization
{
    public static class WebWithAngularLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(WebWithAngularConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(WebWithAngularLocalizationConfigurer).GetAssembly(),
                        "WebWithAngular.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
