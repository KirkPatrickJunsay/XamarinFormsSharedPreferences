using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinFormsSharedPref
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();          
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            try
            {
                var converter = new ColorTypeConverter();
                var testColorIfValid = (Color)converter.ConvertFromInvariantString(entryBackColor.Text);
                App.Setting.SaveColorSetting(entryBackColor.Text);
            }
            catch(InvalidOperationException ex)
            {
                await DisplayAlert("Error", "The Color you selected is not a valid color","OK");
            }

        }

        private void btnRefresh_Clicked(object sender, EventArgs e)
        {
            var converter = new ColorTypeConverter();
            this.BackgroundColor = (Color)converter.ConvertFromInvariantString(App.Setting.RetrieveColorSetting());
        }
    }
}
