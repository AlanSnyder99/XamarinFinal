using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoInformeXamarin.Modelos
{
    public class Preguntas 
    {
        
        public int Id { get; set; }
        public int idProfesor { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
                return Descripcion;   
        }

        public List<Preguntas> listaPreguntas()
        {
            List<Preguntas> listaPreguntas = new List<Preguntas>();
            listaPreguntas.Add(new Preguntas { Id = 1, Descripcion = "¿Que significan las siglas MVC?", idProfesor = 1 });
            listaPreguntas.Add(new Preguntas { Id = 2, Descripcion = "¿Cuales son los principios de SOLID?", idProfesor = 2 });
            listaPreguntas.Add(new Preguntas { Id = 3, Descripcion = "¿Cuales son los principios de MVVM?", idProfesor = 2 });
            return listaPreguntas;
        }

    }
}
