using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Autor
    {
        Datos.Autor objDatos = new Datos.Autor();
        public void Agregar(Modelo.Autore pAutor)
        {
            
            objDatos.Agregar(pAutor);
        }
        public List<Modelo.Pais> TraerPaises()
        {
            return objDatos.TraerPaises();
        }
        public List<Modelo.VistaAutore> TraerAutores()
        {
            return objDatos.TraerAutores();
        }
        public List<Modelo.Autore> TraerAutores(int pais)
        {
            return objDatos.TraerAutores(pais);
        }
     }
}
