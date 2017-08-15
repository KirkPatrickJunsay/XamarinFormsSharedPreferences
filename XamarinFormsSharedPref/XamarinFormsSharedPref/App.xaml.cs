using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormsSharedPref
{
    public partial class App : Application
    {
        private static SettingService _Setting;
        public static SettingService Setting
        {
            get
            {
                if (_Setting == null)
                {
                    _Setting = new SettingService();
                }

                return _Setting;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new XamarinFormsSharedPref.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
