using Finance.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Finance
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegPage : ContentPage
    {
        public RegPage()
        {
            InitializeComponent();
        }
        private void Eye_CLick(object sender, EventArgs e)
        {
            if (pass.IsPassword == true)
            {
                pass.IsPassword = false;
                pass2.IsPassword = false;
            }
            else
            {
                pass.IsPassword = true;
                pass2.IsPassword = true;
            }

            }

        private async void Button_Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AuthPage());
        }

        private async void Button_Reg(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.CostsPage());
        }
    }
}