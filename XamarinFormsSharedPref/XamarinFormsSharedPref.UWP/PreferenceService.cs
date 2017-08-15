using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinFormsSharedPref.UWP;

namespace XamarinFormsSharedPref.UWP
{
    public class PreferenceService : IPreferences
    {
        public bool InsertColorSetting(string setting)
        {
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

            localSettings.Values["BackgroundColor"] = setting;

            return true;
        }

        public string RetrieveColorSetting()
        {
            var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

            return (string)localSettings.Values["BackgroundColor"];           
        }
    }
}
