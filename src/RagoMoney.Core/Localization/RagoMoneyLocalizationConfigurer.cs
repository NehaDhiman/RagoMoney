using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace RagoMoney.Localization
{
    public static class RagoMoneyLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(RagoMoneyConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(RagoMoneyLocalizationConfigurer).GetAssembly(),
                        "RagoMoney.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
