using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebCurso.Archivos
{
    public class Libro
    {
        public DataView TraerLibros()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(HttpContext.Current.Server.MapPath("/Archivos/Libros.xml"));
            DataView dv = new DataView(ds.Tables[0]);
            return dv;
        }

    }
}