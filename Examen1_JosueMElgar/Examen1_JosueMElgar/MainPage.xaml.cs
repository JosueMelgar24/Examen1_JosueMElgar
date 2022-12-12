using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen1_JosueMElgar
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            IniApp();



        }


        void IniApp()
        {
            // throw new NotImplementedException();
            // List<Pais> pais = new List<PaisItem>();
        }

        private async void btnsalvar_Clicked(object sender, EventArgs e)
        {

            var conta = new Models.Contactos
            {
                nombres = txtnombre.Text,
                telefono = Convert.ToInt32(txtelefono.Text),
                edad = Convert.ToInt32(txtedad.Text),
                nota = txtnota.Text,


            };

            var picker = new Picker { Title = "Selecciones Un Pais", TitleColor = Color.White };
            picker.Items.Add("Honduras(504)");
            picker.Items.Add("Costa Rica");
            picker.Items.Add("Guatemala");
            picker.Items.Add("El Salvador");

            var page = new Views.PageContacto();
            page.BindingContext = conta;
            await Navigation.PushAsync(page);


        }


        private void OnPicker_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
    }
}
