using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginAspNet.datos
{
    public class acceso_datos
    {
        public acceso_datos()
        {
            
        }

        //select user with linq
        public string AccesoUsuario(string usu, string pass)
        {
            //obtenemos el string de conexion creada por el Linq
            string connection_str = System.Configuration.ConfigurationManager.ConnectionStrings["restauranteConnectionString"].ToString();

            //creamos el contexto con el que podemos usar los linq
            DataLinqUserDataContext context = new DataLinqUserDataContext(connection_str);
            
            //creamos la consulta de seleccion usando linq
            var user = from u in context.tbl_usuarios
                      where u.usuario == usu & u.pass_plain == pass
                      select u;

            string nombre = "";

            //recorremos el resultado de la consulta y ponemos el nombre y apellido en la variable nombre que retornaremos
            foreach (var u in user)
            {
                nombre = u.nombres + " " + u.apellidos;
            }

            return nombre;
        }
    }
}