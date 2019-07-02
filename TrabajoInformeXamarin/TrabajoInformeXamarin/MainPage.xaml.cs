using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TrabajoInformeXamarin.Modelos;
using TrabajoInformeXamarin.Servicios;

namespace TrabajoInformeXamarin
{

    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void ProcedimientoDeLogin(object sender, EventArgs e)
        {
            Usuario usuarioIngresado = new Usuario(email.Text, contrasena.Text);
            ServicioUsuario servicioUsuario = new ServicioUsuario();

            if (servicioUsuario.ValidacionLogin(usuarioIngresado))
            {
                    int Rol = servicioUsuario.BuscarId(usuarioIngresado);
                    if (Rol == 1)
                    {
                        DisplayAlert("Login", "Inicio Exitoso", "Oka");
                        this.Navigation.PushModalAsync(new IndexProfesor());
                    } else if(Rol == 2)
                    {
                        DisplayAlert("Login", "Inicio Exitoso", "Oka");
                        this.Navigation.PushModalAsync(new IndexAlumno());
                    } else
                        {
                            DisplayAlert("Login", "Error de Login, Contraseña o Email invalidos", "Oka");
                         }
                
            }
            else
            {
                DisplayAlert("Login", "Error de Login, Contraseña o Email invalidos", "Oka");
            }

        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Preguntas selectedItem = e.SelectedItem as Preguntas;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Preguntas tappedItem = e.Item as Preguntas;
        }

    }
}
