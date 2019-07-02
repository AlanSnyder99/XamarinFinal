using System;
using System.Collections.Generic;
using System.Text;
using TrabajoInformeXamarin.Modelos;

namespace TrabajoInformeXamarin.Servicios
{
    class ServicioPreguntas 
    {

        public List<Preguntas> ConsultarPreguntas()
        {
            var preguntas = new List<Preguntas>();

            preguntas.Add(new Preguntas() { Id = 1, Descripcion = "¿Pregunta 1?", idProfesor = 1 });
            preguntas.Add(new Preguntas() { Id = 2, Descripcion = "¿Pregunta 2?", idProfesor = 2 });
            preguntas.Add(new Preguntas() { Id = 3, Descripcion = "¿Pregunta 3?", idProfesor = 2 });
            
            return preguntas;
        }

    }
}
