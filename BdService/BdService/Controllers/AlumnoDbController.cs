using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BdService.Controllers
{
    public class AlumnoDbController : ApiController
    {
        // GET: api/AlumnoDb
        public IEnumerable<Alumno> Get()
        {
            MyContext ctx = new MyContext();
            List<Alumno> listaAlumnosDb = new List<Alumno>();
            listaAlumnosDb = ctx.Alumno.ToList();
            List<Alumno> listaAlumnos = new List<Alumno>();
            foreach (Alumno alumnoDb in listaAlumnosDb)
            {
                Alumno alumno = new Alumno();
                alumno.IdAlumno = alumnoDb.IdAlumno;
                alumno.Nombre = alumnoDb.Nombre;
                alumno.Apellido = alumnoDb.Apellido;
                alumno.PuntosTotales = alumnoDb.PuntosTotales;
                alumno.CantidadRespuestasCorrectas = alumnoDb.CantidadRespuestasCorrectas;
                alumno.CantidadMejorRespuesta = alumnoDb.CantidadMejorRespuesta;
                listaAlumnos.Add(alumno);
            }
            return listaAlumnos;
        }

        // GET: api/AlumnoDb/5
        public Alumno Get(int id)
        {
            MyContext ctx = new MyContext();
            Alumno alumnoDb = ctx.Alumno.SingleOrDefault(a => a.IdAlumno == id);
            Alumno alumno = new Alumno();
            alumno.IdAlumno = alumnoDb.IdAlumno;
            alumno.Nombre = alumnoDb.Nombre;
            alumno.Apellido = alumnoDb.Apellido;
            alumno.PuntosTotales = alumnoDb.PuntosTotales;
            alumno.CantidadRespuestasCorrectas = alumnoDb.CantidadRespuestasCorrectas;
            alumno.CantidadMejorRespuesta = alumnoDb.CantidadMejorRespuesta;
            return alumno;
        }

        // POST: api/AlumnoDb
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AlumnoDb/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AlumnoDb/5
        public void Delete(int id)
        {
        }
    }
}
