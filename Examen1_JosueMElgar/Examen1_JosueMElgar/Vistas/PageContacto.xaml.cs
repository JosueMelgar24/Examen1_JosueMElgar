using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1_JosueMElgar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageContacto : ContentPage
    {
      
        public PageContacto()
        {
            InitializeComponent();
            
        }

        public void llenardatos()
        {
            var contac = new Models.Contactos
            {
                Id = Convert.ToInt32(txtcodigo.Text),
                nombres = txtnombre.Text,
                telefono = Convert.ToInt32(txtelefono.Text),
                edad = Convert.ToInt32(txtedad.Text),
                nota = txtnota.Text,
            };
            

        }


        public async void DisplayAlert(object obj, EventArgs eventArgs)
        {
           var ans = await DisplayAlert("Warning", "This alert demo", "Yes", "No");
          
        }

        private  async void btnsalvar_Clicked(object sender, EventArgs e)
        {
            var contac = new Models.Contactos
            {
                 Id = Convert.ToInt32(txtcodigo.Text),
                nombres = txtnombre.Text,
                telefono = Convert.ToInt32(txtelefono.Text),
                edad = Convert.ToInt32(txtedad.Text),
                nota = txtnota.Text,
            };
            this.txtnombre.Text = contac.ToString();
            {
                this.txtnombre.Text = "";
                {
                    var ans = await DisplayAlert("Warning", "Debe escribir un nombre", "", "");
                }

            }

            this.txtelefono.Text = contac.ToString();
            {
                this.txtelefono.Text = "";
                {
                    var ans = await DisplayAlert("Warning", "Debe escribir un telefono", "", "");
                }

            }

            this.txtnota.Text = contac.ToString();
            {
                this.txtnota.Text = "";
          
                {
                    var ans = await DisplayAlert("Advertencia", "Debe escribir un nota", "", "");
                }

            }

            var picker = new Picker { Title = "Selecciones Un Pais", TitleColor = Color.White };
            picker.Items.Add("Honduras(504)");
            picker.Items.Add("Costa Rica");
            picker.Items.Add("Guatemala");
            picker.Items.Add("El Salvador");


            if (await App.dbcontac.StoreContac(contac)>0)
           await DisplayAlert("Aviso", "Registro Ingresado Con Exito!!", "OK");



        }

        private void btneliminar_Clicked(object sender, EventArgs e)
        {
            

        }

        private async void btnactualizar_Clicked(object sender, EventArgs e)
        {

            llenardatos();
            if (!string.IsNullOrEmpty(txtcodigo.Text))
            {
                var contac = new Models.Contactos 
                
                {
                    Id = Convert.ToInt32(txtcodigo.Text),
                    nombres = txtnombre.Text,
                    telefono = Convert.ToInt32(txtelefono.Text),
                    edad = Convert.ToInt32(txtedad.Text),
                    nota = txtnota.Text,
                };



                await App.dbcontac.SaveContacAsync(contac);
                await DisplayAlert("Registro", "Se actualizo de manera exitosa el contacto", "OK");
                txtcodigo.Text = "";
                txtnombre.Text = "";
                txtelefono.Text = "";
                txtedad.Text = "";
                txtnota.Text = "";
                txtcodigo.IsVisible = false;
                
                

                
            }
        }
    }
}