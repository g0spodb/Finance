using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Finance.Models;
using Finance.Views;
namespace Finance.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CostsPage : ContentPage
    {
        public CostsPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            collectionView.ItemsSource = await App.FinanceDB.GetCostsAsync();

            base.OnAppearing();
        }

        private async void AddButon_Clicked(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync(nameof(CostAddPage));
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                Cost cost = (Cost)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync(
                    $"{nameof(CostAddPage)}?{nameof(CostAddPage.ItemId)}={cost.Id.ToString()}");
            }
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CostAddPage());
        }
    }
}