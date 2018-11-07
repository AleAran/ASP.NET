using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class CierreSesion : Utilidades
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // liberar sesion
            Session.Abandon();
            MsgBox("Su sesion ha finalizado, muchas gracias...");

        }
    }
}