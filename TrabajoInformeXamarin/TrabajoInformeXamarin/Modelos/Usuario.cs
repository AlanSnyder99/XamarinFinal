using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoInformeXamarin.Modelos
{
   public class Usuario
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public int idRol { get; set; }
       



        public Usuario()
        {

        }

        public Usuario (string Email, string Contrasena)
        {
            this.Email = Email;
            this.Contrasena = Contrasena;
        }

        public List<Usuario> listaUsuarios()
        {
            Usuario usuarioProfesor = new Usuario();
            usuarioProfesor.Email = "profesor";
            usuarioProfesor.Contrasena = "1234";
            usuarioProfesor.idRol = 1;

            Usuario usuarioProfesore = new Usuario();
            usuarioProfesore.Email = "profesorDos";
            usuarioProfesore.Contrasena = "1234";
            usuarioProfesore.idRol = 1;

            Usuario usuarioAlumno = new Usuario();
            usuarioAlumno.Email = "alumno";
            usuarioAlumno.Contrasena = "1234";
            usuarioAlumno.idRol = 2;

            Usuario usuarioAlumno2 = new Usuario();
            usuarioAlumno2.Email = "alumno2";
            usuarioAlumno2.Contrasena = "1234";
            usuarioAlumno2.idRol = 2;


            Usuario usuarioAlumno3 = new Usuario();
            usuarioAlumno3.Email = "alumno3";
            usuarioAlumno3.Contrasena = "1234";
            usuarioAlumno3.idRol = 2;

            List<Usuario> listaUsuarios = new List<Usuario>();
            listaUsuarios.Add(usuarioProfesor);
            listaUsuarios.Add(usuarioAlumno);
            listaUsuarios.Add(usuarioAlumno2);
            listaUsuarios.Add(usuarioAlumno3);
            listaUsuarios.Add(usuarioProfesore);

            return listaUsuarios;
        }

      /*  public Boolean validarSiExiste()
        {
            Usuario usuarioProfesor = new Usuario();
            usuarioProfesor.Email = "profesor";
            usuarioProfesor.Contrasena = "1234";
            usuarioProfesor.idRol = 1;

            Usuario usuarioAlumno = new Usuario();
            usuarioAlumno.Email = "alumno";
            usuarioAlumno.Contrasena = "1234";
            usuarioAlumno.idRol = 2;

            List<Usuario> listaUsuarios = new List<Usuario>();
            listaUsuarios.Add(usuarioProfesor);
            listaUsuarios.Add(usuarioAlumno);

            foreach (Usuario usuarios in listaUsuarios)
            {
                if (this.Email == usuarios.Email && this.Contrasena == usuarios.Contrasena)
                {
                    return true;
                }
                else
                {
                    return false;
                }    
            }

        }*/

      


    }
}
