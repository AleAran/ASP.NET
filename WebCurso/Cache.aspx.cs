using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Cache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TraerLibros();
                Actualizar(); }
            }
        void TraerLibros()
        {
            Archivos.Libro objLibro = new Archivos.Libro();
            DataView dvLibros = objLibro.TraerLibros();
            Cache["Libros"] = dvLibros;

        }
        void Actualizar()
        {
            gvLibros.DataSource = (DataView)Cache["Libros"];
            gvLibros.DataBind();
        }

        protected void gvLibros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvLibros.PageIndex = e.NewPageIndex;
            Actualizar();
        }


    }
}