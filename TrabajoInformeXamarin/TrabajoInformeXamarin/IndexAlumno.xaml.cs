using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoInformeXamarin.Modelos;
using TrabajoInformeXamarin.Servicios;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TrabajoInformeXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndexAlumno : ContentPage
    {
        public IList<Preguntas> listaPreguntas { get;  private set; }
        public Preguntas preguntas = new Preguntas();
        public IndexAlumno()
        {
            InitializeComponent();
            listaPreguntas = new List<Preguntas>();
            listaPreguntas = preguntas.listaPreguntas();

            BindingContext = this;

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