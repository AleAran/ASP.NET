using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCurso
{
    public partial class Ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ActualizaPagina();
        }
        protected void btnPanel_Click(object sender, EventArgs e)
        {
            ActualizaPanelAjax();
        }
        protected void btnFueraPanel_Click(object sender, EventArgs e)
        {
            ActualizaPanelFueraAjax();
        }
        protected void btnExterno_Click(object sender, EventArgs e)
        {
            ActualizaPanelAjax();
        }



        // procedimientos
        void ActualizaPanelAjax()
        {
            System.Threading.Thread.Sleep(20000);
            lblDentrodelPanel.Text = DateTime.Now.ToString();
        }
        void ActualizaPanelFueraAjax()
        {
            lblFueraDelPanel.Text= DateTime.Now.ToString();
        }
        void ActualizaPagina()
        {
            lblPagina.Text= DateTime.Now.ToString();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            ActualizaPanelAjax();
        }
    }
}