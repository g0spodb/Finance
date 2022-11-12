using Finance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Finance.Views
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class CostAddPage : ContentPage
    {
        public string ItemId
        {
            set
            {
                LoadCost(value);
            }
        }

        public CostAddPage()
        {
            InitializeComponent();

            BindingContext = new Cost();
        }
        private async void LoadCost(string value)
        {
            try
            {
                int Id = Convert.ToInt32(value);
                Cost cost = await App.FinanceDB.GetCostAsync(Id);
                BindingContext = cost;
            }
            catch { }
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            Cost cost = (Cost)BindingContext;
            cost.Date = DateTime.UtcNow;

            if (!string.IsNullOrWhiteSpace(cost.Type))
            {
                await App.FinanceDB.SaveCostAsunc(cost);
            }
            await Shell.Current.GoToAsync("..");
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            Cost cost = (Cost)BindingContext;

            await App.FinanceDB.DeleteCostAsync(cost);
            await Shell.Current.GoToAsync("..");
        }
    }
}