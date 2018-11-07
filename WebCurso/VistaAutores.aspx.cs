using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class VistaAutores : System.Web.UI.Page
    {
        static int intTiempo = 20;
        protected void Page_Load(object sender, EventArgs e)
        {
            // comprobar si esta autenticado
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("Default.aspx");
            }
            else
            { 

                if (!Page.IsPostBack)
                {
                    TraerAutores();
                }
            }
        }
        void TraerAutores()
        {
            Logica.Autor objLogicaAutor = new Logica.Autor();
            gvAutores.DataSource = objLogicaAutor.TraerAutores();
            gvAutores.DataBind();
        }

        protected void gvAutores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAutores.PageIndex = e.NewPageIndex;
            TraerAutores();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text ="Estos datos se actualizaran en "+ intTiempo + " segundos";
            intTiempo--;
            if (intTiempo==0)
            {
                TraerAutores();
                intTiempo = 20;
            }
        }
    }
}