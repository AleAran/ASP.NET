using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class AltaAutor : Utilidades
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.IsInRole("Administradores"))
            {
                Response.Redirect("Default.aspx");
            }
            else
            { 
                if (!Page.IsPostBack)
                {
                    LlenarComboPaises();
                }
            }
        }

        void LlenarComboPaises()
        {
            Logica.Autor objLogica = new Logica.Autor();
            ddlNacionalidad.DataSource = objLogica.TraerPaises();
            ddlNacionalidad.DataTextField = "Descripcion"; // campo a mostrar
            ddlNacionalidad.DataValueField = "ID"; // campo a guardar
            ddlNacionalidad.DataBind();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // todos los controles de validacion estan OK ( se cumplen)
                Modelo.Autore objModelo = new Modelo.Autore();
                Logica.Autor objLogica = new Logica.Autor();
                // lleno el modelo
                objModelo.Apellido = txtApellido.Text;
                objModelo.Nombre = txtNombre.Text;
                objModelo.FechaNacimiento =Convert.ToDateTime(txtFechaNacimiento.Text);
                objModelo.Nacionalidad = Convert.ToInt32(ddlNacionalidad.SelectedValue);
                // invoco el metodo Agregar de Logica y le paso el obj del modelo
                objLogica.Agregar(objModelo);
                lblMensaje.Text = "Autor agregado!!! ";

            }
            else
            {
                // algun control dio false en su validacion
                lblMensaje.Text = "Datos NO Validados!!!";
            }
        }

        protected void btnAyuda_Click(object sender, EventArgs e)
        {
            MsgBox("Todos los operadores estan ocupados,intente mas tarde...");
        }
    }
}