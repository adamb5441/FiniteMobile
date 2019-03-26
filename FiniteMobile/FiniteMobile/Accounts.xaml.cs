using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FiniteMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Accounts : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public Accounts(IEnumerable<Account> list)
        {
            InitializeComponent();
			
			MyListView.ItemsSource = list;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
