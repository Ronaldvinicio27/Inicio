using LoginAspNet.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginAspNet
{
    public partial class index : System.Web.UI.Page
    {
        acceso_datos datos = new acceso_datos();

        protected void Page_Load(object sender, EventArgs e)
        {
            //errors.Text = datos.UserName(); //solo para probar que podemos usar la clase data
        }

        protected void btn_acceder_Click(object sender, EventArgs e)
        {
            //obtenemos los datos de la caja de texto
            string username = txt_username.Text;
            string password = encriptarmd5(txt_password.Text); //llamamos a la funcion encriptarmd5 para encriptar la contraseña y guardar en la variable password

            //llamamos a la funcion AccesoUsuario de la clase acceso_datos pasandole el usuario y password obtenidos arriba
            string usuario = datos.AccesoUsuario(username, password);

            //verificamos con un if si es que encontro el usuario, si no lo encontro tendremos un string usuario vacio
            if (usuario != "")
            {
                //redirigimos hacia la pagina perfil mandandole un parametro por get llamado user
                Response.Redirect("perfil.aspx?user=" + usuario);
            }
            else
            {
                //enviamos un mensaje de error
                errors.Text = "Nombre de usuario o contraseña incorrectos";
            }

        }


        //encriptar texto en md5
        private string encriptarmd5(string texto)
        {
            //creamos una instancia de la libreria MD5
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();

            //establecemos el tipo de codificacion que trae el texto
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(texto);

            //calculamos el Hash para el md5
            bs = x.ComputeHash(bs);

            //creamos el string encriptado
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            String hash = s.ToString();

            //retornamos el string encriptado
            return hash;
        }
    }
}