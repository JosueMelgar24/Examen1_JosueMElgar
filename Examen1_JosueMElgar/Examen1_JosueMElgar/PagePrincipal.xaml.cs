using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1_JosueMElgar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipalxaml : ContentPage
    {
        public PagePrincipalxaml()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listcontac.ItemsSource = await App.dbcontac.listacontactos();
            
        }

        private async void tooladd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageContacto());
        }

        private async void toolmap_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Pagemap());
        }

        private async void tooladd_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageContacto());
        }

        
    }
}