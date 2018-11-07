using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Restar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            // crear un objeto de la clase Proxy del servicio
            Curso.Servicios objServicio = new Curso.Servicios();
            int intN1 = Convert.ToInt32(txtNumero1.Text);
            int intN2 = Convert.ToInt32(txtNumero2.Text);
            lblResta.Text = objServicio.Restar(intN1, intN2).ToString();

        }
    }
}