using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebCurso
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // inicializo el contador de usuarios conectados
            Application["Conectados"] = 0;
        }
        void Session_Start(object sender, EventArgs e)
        {
            // codigo x cada usuario que inicia sesion
            Application["Conectados"] = Convert.ToInt32(Application["Conectados"])+1 ;
        }
        void Session_End(object sender, EventArgs e)
        {
            // codigo x cada usuario que cierra la sesion
            Application["Conectados"] = Convert.ToInt32(Application["Conectados"]) - 1;
        }
    }
}