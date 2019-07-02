using System;
using System.Collections.Generic;
using System.Text;
using TrabajoInformeXamarin.Modelos;
using TrabajoInformeXamarin.Servicios;
using System.Linq;

    class ServicioUsuario
    {
        Usuario usuario = new Usuario();
 
        public Boolean ValidacionLogin(Usuario usuarioIngresado)
        {
          
            if (!usuarioIngresado.Email.Equals("") && !usuarioIngresado.Contrasena.Equals(""))
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public int BuscarId(Usuario usuarioIngresado)
        {
       
         List<Usuario> listaUsuarios = new List<Usuario>();
         listaUsuarios = usuario.listaUsuarios();
         Usuario usuarioBus = listaUsuarios.SingleOrDefault(x => x.Email == usuarioIngresado.Email && x.Contrasena == usuarioIngresado.Contrasena);
         //List<Usuario> usuarioBusc = listaUsuarios.Where(x => x.Email == usuarioIngresado.Email && x.Contrasena == usuarioIngresado.Contrasena).SingleOrDefault();

       if(usuarioBus == null)
        {
            return 3;
        }
        else
        {
            if (usuarioBus.idRol == 1)
            {
                return 1;
            }
            else if (usuarioBus.idRol == 2)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
            
        }
        
     

/*
        if (usuarioIngresado.Email == usuarioAlumno.Email)
            {
                return usuarioAlumno.idRol;
            }
            else if (usuarioIngresado.Email == usuarioProfesor.Email)
            {
                return usuarioProfesor.idRol;
            }
            else
            {
                return 3;
            }
            */

        }

    

