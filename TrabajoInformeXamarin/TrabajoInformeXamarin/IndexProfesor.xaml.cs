using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoInformeXamarin.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrabajoInformeXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndexProfesor : ContentPage
    {
        Usuario usuario = new Usuario();
        public IList<Usuario> listaUsuarios { get; private set; }
        public IndexProfesor()
        {
            InitializeComponent();
            listaUsuarios = new List<Usuario>();
            listaUsuarios = usuario.listaUsuarios();
            BindingContext = this;
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Usuario selectedItem = e.SelectedItem as Usuario;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Usuario tappedItem = e.Item as Usuario;
        }
    }
}