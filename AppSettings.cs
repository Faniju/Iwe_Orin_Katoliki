using System;
using System.Collections.Generic;
using System.Text;

namespace YorubaCatholicHymn
{
    class AppSettings
    {
        private const string LanguageKey = "AppLanguage";

        public static string CurrentLanguage
        {
            get => Preferences.Get(LanguageKey, "en"); // default English
            set => Preferences.Set(LanguageKey, value);
        }

    }
}
