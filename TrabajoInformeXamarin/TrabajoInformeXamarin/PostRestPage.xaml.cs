using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using TrabajoInformeXamarin.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;

namespace TrabajoInformeXamarin
{
    public class Post
    {
        public int IdAlumno { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Habilitado { get; set; }
        public long PuntosTotales { get; set; }
        public int CantidadRespuestasCorrectas { get; set; }
        public int CantidadRespuestasRegular { get; set; }
        public int CantidadRespuestasMal { get; set; }
        public int CantidadMejorRespuesta { get; set; }
        public System.DateTime FechaHoraCreacion { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<RespuestaAlumno> RespuestaAlumno { get; set; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostRestPage : ContentPage
    {
        private const string url = "http://localhost:49275/api/alumnodb/";
        private HttpClient _Client = new HttpClient();
        //WSClient client = new WSClient();
        //var result = await client.Get<WSResult>("http://localhost:49275/api/alumnodb/");
        //private ObservableCollection _post;
        public IList<Post> listaPosiciones { get; private set; }
        protected override async void OnAppearing()
        {
            var content = await _Client.GetStringAsync(url);
            var post = JsonConvert.DeserializeObject<IList>(content);
            //_post = new ObservableCollection(post);
            //Post_List.ItemsSource = _post;

            List<Post> listaPosicionesVista = new List<Post>();
            foreach (Post item in post)
            {
                Post wsResult = new Post();
                wsResult.Nombre = item.Nombre;
                wsResult.Email = item.Email;
                wsResult.PuntosTotales = item.PuntosTotales;
                listaPosicionesVista.Add(wsResult);
               
                BindingContext = this;

            }

            base.OnAppearing();
        }
        public PostRestPage()
        {
            InitializeComponent();
            base.OnAppearing();
            BindingContext = this;
        }

       
    }
}