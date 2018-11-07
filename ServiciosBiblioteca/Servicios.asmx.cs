using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServiciosBiblioteca
{
    /// <summary>
    /// Descripción breve de Servicios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Servicios : System.Web.Services.WebService
    {
        // metodo web que suma 2 numeros enteros
        [WebMethod]public int Sumar(int n1,int n2)
        {
            int intSuma = n1 + n2;
            System.Threading.Thread.Sleep(20000);// demora 20"
            return intSuma;
        }
        // metodo web que resta 2 numeros enteros
        [WebMethod]
        public int Restar(int n1, int n2)
        {
            int intResta = n1 - n2;
            return intResta;
        }
    }
}
