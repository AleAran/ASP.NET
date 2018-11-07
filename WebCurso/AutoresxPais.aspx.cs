using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class AutoresxPais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarComboPaises();
                Filtrar(1);
            }
        }
        void LlenarComboPaises()
        {
            Logica.Autor objLogica = new Logica.Autor();
            ddlPaises.DataSource = objLogica.TraerPaises();
            ddlPaises.DataTextField = "Descripcion"; // campo a mostrar
            ddlPaises.DataValueField = "ID"; // campo a guardar
            ddlPaises.DataBind();
        }

        protected void ddlPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intPais =Convert.ToInt32(ddlPaises.SelectedValue);
            Filtrar(intPais);
        }
        void Filtrar(int pais)
        {
            Logica.Autor objLogica = new Logica.Autor();
            gvAutores.DataSource = objLogica.TraerAutores(pais);
            gvAutores.DataBind();
        }
    }
}