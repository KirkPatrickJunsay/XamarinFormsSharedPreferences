using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFormsSharedPref
{
    public class SettingService
    {
        private IPreferences setting;

        public SettingService()
        {
            setting = Xamarin.Forms.DependencyService.Get<IPreferences>();   
        }

        public bool SaveColorSetting(string param)
        {
            bool result = false;

            result = setting.InsertColorSetting(param);

            return result;
        }

        public string RetrieveColorSetting()
        {
            return setting.RetrieveColorSetting();
        }
    }
}
