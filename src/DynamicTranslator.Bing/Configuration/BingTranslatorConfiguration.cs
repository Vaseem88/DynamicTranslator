﻿using System.Collections.Generic;

using DynamicTranslator.Configuration.Startup;
using DynamicTranslator.Constants;
using DynamicTranslator.LanguageManagement;

namespace DynamicTranslator.Bing.Configuration
{
    public class BingTranslatorConfiguration : AbstractTranslatorConfiguration, IBingTranslatorConfiguration
    {
        public override IList<Language> SupportedLanguages { get; set; }

        public override TranslatorType TranslatorType => TranslatorType.Bing;

        public override string Url { get; set; }
    }
}