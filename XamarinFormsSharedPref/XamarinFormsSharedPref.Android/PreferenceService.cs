using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinFormsSharedPref.Droid;

[assembly:Xamarin.Forms.Dependency(typeof(PreferenceService))]
namespace XamarinFormsSharedPref.Droid
{
    public class PreferenceService : IPreferences
    {
        public bool InsertColorSetting(string setting)
        {
            bool result = false;

            var colorSetting = Application.Context.GetSharedPreferences("PreferenceTestApplication", FileCreationMode.Private);
            var colorEdit = colorSetting.Edit();

            colorEdit.PutString("BackgroundColor", setting);
            result = colorEdit.Commit();

            return result;
        }

        public string RetrieveColorSetting()
        {
            var colorSetting = Application.Context.GetSharedPreferences("PreferenceTestApplication", FileCreationMode.Private);
            return colorSetting.GetString("BackgroundColor","Black");
        }
    }
}