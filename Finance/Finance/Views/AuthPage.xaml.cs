using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Finance.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthPage : ContentPage
    {
        public AuthPage() 
        {
            InitializeComponent();
        }
        private void Eye_CLick(object sender, EventArgs e)
        {
            if (pass.IsPassword == true)
            {
                pass.IsPassword = false;
            }
            else pass.IsPassword = true;

        }

        private async void RegClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegPage());
        }
    }
}