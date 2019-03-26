using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using FiniteMobile;
using FiniteMobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FiniteMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Households : ContentPage
    {

        public Households()
        {
            InitializeComponent();
            getHouseholdsbtn.Clicked += getHouseholds;

        }
        public async void getHouseholds(object sender, EventArgs e)
        {
            //Items = new ObservableCollection<string>
            //{
            //    "Item 1",
            //    "Item 2",
            //    "Item 3",
            //    "Item 4",
            //    "Item 5"
            //};
            Core core = new Core();
            var houses = await core.GetHouseholds();
            MyListView.ItemsSource = houses;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var id = ((Household)e.Item).Id;

            Core core = new Core();
            var accounts = await core.GetAccounts(id);
            await Navigation.PushModalAsync(new NavigationPage(new Accounts(accounts)));
        }
    }
}
