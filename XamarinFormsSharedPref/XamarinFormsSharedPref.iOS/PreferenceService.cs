using Foundation;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsSharedPref.iOS
{
    public class PreferenceService : IPreferences
    {
        public bool InsertColorSetting(string setting)
        {
            bool result = false;

            NSUserDefaults.StandardUserDefaults.SetString("BackgroundColor", setting);

            result = NSUserDefaults.StandardUserDefaults.Synchronize();

            return result;
        }

        public string RetrieveColorSetting()
        {
            return "";
        }
    }
}
