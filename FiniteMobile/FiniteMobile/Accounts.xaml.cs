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
            this.Title = "Finite";
            NavigationPage.SetHasBackButton(this, true);
            
            MyListView.ItemsSource = list;
        }
        private async void Voltar(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
