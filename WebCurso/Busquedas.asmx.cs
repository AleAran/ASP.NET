using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebCurso
{
    /// <summary>
    /// Descripción breve de Busquedas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class Busquedas : System.Web.Services.WebService
    {
        [WebMethod]
        public string[] ObtenerAutores(string prefixText, int count)
        {
            string strCon = @"Server=.\SQLEXPRESS;Database=Biblioteca;Integrated Security=true";
            string strSQL = "Select Apellido from Autores where Apellido  LIKE '%' + @letras + '%' ";
            SqlConnection objConexion = new SqlConnection(strCon);
            SqlCommand comBuscar = new SqlCommand(strSQL, objConexion);
            comBuscar.Parameters.AddWithValue("@letras", prefixText);
            SqlDataReader dr;
            List<string> lista = new List<string>();
            objConexion.Open();
            dr = comBuscar.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr["Apellido"].ToString());

            }
            objConexion.Close();
            return lista.ToArray();

        }
        [WebMethod]
        public string[] ObtenerLibros(string prefixText, int count)
        {
            string strCon = @"Server=.\SQLEXPRESS;Database=Biblioteca;Integrated Security=true";
            string strSQL = "Select Titulo from Libros where Titulo  LIKE '%' + @letras + '%' ";
            SqlConnection objConexion = new SqlConnection(strCon);
            SqlCommand comBuscar = new SqlCommand(strSQL, objConexion);
            comBuscar.Parameters.AddWithValue("@letras", prefixText);
            SqlDataReader dr;
            List<string> lista = new List<string>();
            objConexion.Open();
            dr = comBuscar.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr["Titulo"].ToString());

            }
            objConexion.Close();
            return lista.ToArray();

        }

    }
}
