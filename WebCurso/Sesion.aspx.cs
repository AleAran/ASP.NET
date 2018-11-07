using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Sesion : Utilidades
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // guardo el dato ingresado en txtNombre en un objeto Session
            Session["Nombre"] = txtNombre.Text;
            HttpCookie cookie = Request.Cookies["Valores"];
            // pregunto si tildo mantener sesion
            if (cbGuardar.Checked)
            {
                // guardo la cookie
                
                // sino encuentra la cookie
                if (cookie == null)
                {
                    cookie = new HttpCookie("Valores");
                }

                // guardo el contenido del txtNombre
                cookie["Usuario"] = this.txtNombre.Text;

                cookie.Expires = DateTime.MaxValue; // cookie permanente
                Response.Cookies.Add(cookie);// 
            }
            else
            {
                if (cookie == null)
                {
                    cookie = new HttpCookie("Valores");
                }

                // guardo el contenido del txtCookie
                cookie["Usuario"] = "";

                cookie.Expires = DateTime.MaxValue; // cookie permanente
                Response.Cookies.Add(cookie);// 
            }
            
            //lblMensaje.Text = "Nombre guardado mientras dure la sesion";
            MsgBox("Nombre guardado!!!");
        }
    }
}