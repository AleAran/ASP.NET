using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Sumar : Utilidades
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            if(User.Identity.Name=="ws@gmail.com")
            {
                // crear un objeto de la clase Proxy del servicio
                Curso.Servicios objServicio = new Curso.Servicios();
                int intN1 = Convert.ToInt32(txtNumero1.Text);
                int intN2 = Convert.ToInt32(txtNumero2.Text);
                lblSuma.Text = objServicio.Sumar(intN1, intN2).ToString();

            }
            else
            {
                MsgBox("No tiene permisos ejecutar esa accion!!!");
            }

        }
    }
}